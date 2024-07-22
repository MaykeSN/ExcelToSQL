using ConsumerSQLtoExcel.Controllers;
using ConsumerSQLtoExcel.Design.UsersControls;
using ConsumerSQLtoExcel.Entities;
using ConsumerSQLtoExcel.Exceptions;
using ConsumerSQLtoExcel.Helpers;
using ConsumerSQLtoExcel.Properties;
using ConsumerSQLtoExcel.Repositories;
using ConsumerSQLtoExcel.Views;
using DocumentFormat.OpenXml.Office2019.Presentation;
using MySql.Data.MySqlClient;
using static ConsumerSQLtoExcel.Design.WindowsConfigs;
using Timer = System.Windows.Forms.Timer;
namespace ConsumerSQLtoExcel
{
    public partial class FrmPrincipal : Form
    {
        #region Variaveis
        FoldersMap? foldersMap;
        ScriptConfig? scriptConfig;
        bool flagProcess = false;
        string query = string.Empty;
        bool checkFile = false, checkScript = false, checkCon = false;
        List<MySqlParameter> parameters;
        #endregion
        public FrmPrincipal() => InitializeComponent();
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                foldersMap = DialogsController.GetAllFilesCsvXlsx();

                foldersMap.Folders ??= [];

                LblFilename.Text = foldersMap.Folders[0].Filename
                                   ?? "Nenhum arquivo selecionado";

                _ = FillScripts(ScriptsController.GetAllScripts(), FlowScripts);

            }
            catch
            {

            }

            if (!string.IsNullOrWhiteSpace(Settings.Default.ScriptInUse))
            {
                foreach (UcScript scr in FlowScripts.Controls)
                {
                    if (scr.IsActive)
                    {
                        scriptConfig = scr.GetScript();
                    }
                }
            }

            LblScriptAtual.Text = scriptConfig?.ScriptName ?? "Nenhum script selecionado";
            TimerScriptChanged.Start();
        }

        private void TimerCode_Tick(object? sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        #region Timers
        private async void TimerIsAllOkTick(object sender, EventArgs e)
        {
            TimerIsAllOk.Stop();

            if (scriptConfig is not null)
            {
                checkScript = true;
            }

            if (foldersMap is not null)
            {
                if (foldersMap.Folders is not null)
                {
                    if (foldersMap.Folders[0] is not null)
                    {
                        checkFile = true;

                    }
                }
            }

            if (checkScript)
            {
                string con = RepositorieBase.GetConnectionString(scriptConfig.ConnectionString);
                var result = await RepositorieBase.IsOkConnection(con);
                if (result)
                {
                    checkCon = true;
                    PnSectionBotton.Visible = true;
                }
            }

            UpdateChecks();
        }
        private void TimerScriptChangedTick(object sender, EventArgs e)
        {
            if(scriptConfig is null) { return; }

            if (Settings.Default.ScriptInUse != scriptConfig.ScriptName)
            {
                foreach (UcScript scr in FlowScripts.Controls)
                {
                    if (scr.IsActive)
                    {
                        scriptConfig = scr.GetScript();
                    }
                }
            }

            LblScriptAtual.Text = scriptConfig?.ScriptName ?? "Nenhum script selecionado";
        }
        #endregion

        #region Metodos
        private void UpdateChecks()
        {
            CkArquivoSelecionado.Checked = checkFile;
            CkConexao.Checked = checkCon;
            CkScript.Checked = checkScript;
        }
        private static bool FillScripts(Scripts scripts, FlowLayoutPanel flow)
        {
            if (scripts is null)
            {
                return false;
            }

            if (scripts.AllScripts is null)
            {
                return false;
            }

            if (scripts.AllScripts.Count == 0)
            {
                return false;
            }

            flow.Controls.Clear();

            foreach (var script in scripts.AllScripts)
            {
                var uc = new UcScript(script, flow);

                if (script.ScriptName == Settings.Default.ScriptInUse)
                {
                    uc.SelectThis();
                }

                flow.Controls.Add(uc);
            }

            return true;
        }
        private void ChangeStep()
        {
            if (flagProcess)
            {
                PicStartImage.Image = Resources.go_image;
                PicStartImage.Cursor = Cursors.Hand;
                LblStatus.Text = "CONCLUIDO";
                LblStatus.ForeColor = Color.Green;
                flagProcess = false;
                PnFooter.Visible = true;
                TxtPreviewQuery.Text = query;
                return;
            }

            query = string.Empty;
            PicStartImage.Image = Resources.anime_gif;
            PicStartImage.Cursor = Cursors.WaitCursor;
            LblStatus.Text = "PROCESSANDO";
            LblStatus.ForeColor = Color.Gold;
        }
        #endregion

        private void FrmPrincipalMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Opacity = 0.5;
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            else
            {
                Opacity = 1.0;
            }
        }

        private void BtnSelecionarClick(object sender, EventArgs e)
        {
            if (DialogsController.OpenFileCsvXlsx() == DialogResult.OK)
            {
                try
                {
                    var files = DialogsController.GetAllFilesCsvXlsx();

                    LblFilename.Text = files?.Folders?[0]?.Filename
                                       ?? "Arquivo não selecionado!";
                    foldersMap = files;
                }
                catch (FilesControllersException ex)
                {
                    MessageBox.Show(ex.Message, "Excel to SQL", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSelecionarScriptClick(object sender, EventArgs e)
        {
            if (new FrmModalCreateScript().ShowDialog() == DialogResult.OK)
            {
                _ = FillScripts(ScriptsController.GetAllScripts(), FlowScripts);
                MessageBox.Show("Script criado com sucesso!", "Excel to SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Script cancelado!", "Excel to SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FlowScripts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private async void PicStartImageClick(object sender, EventArgs e)
        {
            ChangeStep();

            var data = await ExcelController.GetDataExcelAsync(foldersMap.Folders[0].Path, scriptConfig, CkbFirstLine.Checked, PgBarProcess);
            (query, parameters) = QueryBuilder.BuildInsertQuery2(scriptConfig, data);

            if (query != string.Empty)
            {
                flagProcess = true;
                ChangeStep();
            }
        }
        private void CkArquivoSelecionado_CheckedChanged(object sender, EventArgs e)
        {

            CkArquivoSelecionado.Checked = checkFile;
        }

        private void CkScript_CheckedChanged(object sender, EventArgs e)
        {

            CkScript.Checked = checkScript;

        }

        private void CkConexao_CheckedChanged(object sender, EventArgs e)
        {

            CkConexao.Checked = checkCon;

        }

        private void BtnTry_Click(object sender, EventArgs e)
        {
            TimerIsAllOk.Start();
        }

        private async void BtnExecuteClick(object sender, EventArgs e)
        {
            string con = RepositorieBase.GetConnectionString(scriptConfig.ConnectionString);
            InsertControl insert = new ();
            var count = await insert.InsertDataFromExcelToDatabase(query, parameters, con);

            TxtLinhas.Text = $"Foram inseridos {count} registros com sucesso!";
        }
    }
}
