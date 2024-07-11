using ConsumerSQLtoExcel.Controllers;
using ConsumerSQLtoExcel.Design.UsersControls;
using ConsumerSQLtoExcel.Entities;
using ConsumerSQLtoExcel.Exceptions;
using ConsumerSQLtoExcel.Repositories;
using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumerSQLtoExcel.Views
{
    public partial class FrmModalCreateScript : Form
    {
        private string? filePath;
        private Scripts Scripts;
        List<Columns> cols = [];
        public FrmModalCreateScript()
        {
            InitializeComponent();
        }
        private static bool ValidateTextBox(Panel pn)
        {
            foreach (Control ct in pn.Controls)
            {
                if (ct != null)
                {
                    if (ct is TextBox)
                    {
                        if (string.IsNullOrEmpty(ct.Text)) { return false; }
                    }
                }
            }

            return true;
        }

        private static bool ValidateControls(FlowLayoutPanel flow)
        {
            int count = 0;
            foreach (ColumnsControl ct in flow.Controls)
            {
                if (!ct.ValidateControl())
                {
                    count++;
                    break;
                }
            }
            return count == 0;
        }

        private async void BtnSelecionarClick(object sender, EventArgs e)
        {
            if (!ValidateTextBox(PnTextBox))
            {
                MessageBox.Show("Preencha os campos vazios!", "Excel to SQL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            using OpenFileDialog dialog = new()
            {
                Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx",
                Title = "Selecione um arquivo CSV ou XLSX",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                LblFilename.Text = filePath;

                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Arquivo não selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                BtnSelecionar.Text = "Carregando\n Sheets...";
                BtnSelecionar.BackColor = Color.Gold;
                BtnSelecionar.Enabled = false;

                CbxSheets.Items.Clear();

                List<string> sheets = await ExcelController.GetWorkSheets(filePath); ;

                foreach (var sheet in sheets)
                {
                    CbxSheets.Items.Add(sheet);
                }

                if (CbxSheets.Items.Count > 0)
                {
                    BtnSelecionar.Text = "Selecione a\n Sheet";
                    BtnSelecionar.BackColor = Color.DarkBlue;
                }
            }
        }

        private void FrmModalCreateScriptLoad(object sender, EventArgs e)
        {
            InterfaceController.PersonalizarComboBox(CbxSheets, "Selecione a Sheet");
        }

        private async void BtnSelecionarSheetClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CbxSheets.Text))
                return;

            List<string> listColumns = [];
            try
            {
                listColumns = await ExcelController.GetAllColumns(filePath: filePath ?? throw new FilesControllersException("Arquivo não selecionado!"), sheetName: CbxSheets.Text.Trim());
            }
            catch (FilesControllersException ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "SQL to Excel", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            FlowColumns.Controls.Clear();

            foreach (var column in listColumns)
            {
                FlowColumns.Controls.Add(new ColumnsControl(column));
            }

        }

        private void BtnSalvarColunasClick(object sender, EventArgs e)
        {
            if (!ValidateControls(FlowColumns))
            {
                MessageBox.Show("Faltam colunas a serem preenchidas", "SQL to Excel", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

           
        }

        private void BtnSalvarClick(object sender, EventArgs e)
        {
            if (RepositorieBase.IsConnectionString(TxtConnectionString.Text) == false)
            {
                MessageBox.Show("Insira uma string de conexão valida!", "Excel to SQL", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return ;
            }

            if (ValidateControls(FlowColumns) && ValidateTextBox(PnTextBox))
            {
                cols.Clear();

                foreach (ColumnsControl cc in FlowColumns.Controls)
                {
                    cols.Add(cc.GetColumns());
                }

                ScriptsController.CreateScript(TxtNomeScript.Text, TxtConnectionString.Text.Trim(), TxtTableName.Text.Trim(), CbxSheets.Text.Trim(), cols);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("Ha campos que precisam ser preenchidos", "Excel to SQL", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
