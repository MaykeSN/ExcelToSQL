namespace ConsumerSQLtoExcel.Views
{
    partial class FrmModalCreateScript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnExit = new Button();
            PnTextBox = new Panel();
            label6 = new Label();
            TxtTableName = new TextBox();
            label2 = new Label();
            TxtConnectionString = new TextBox();
            label1 = new Label();
            TxtNomeScript = new TextBox();
            label4 = new Label();
            BtnSalvar = new Button();
            panel1 = new Panel();
            CBoxFirstLine = new CheckBox();
            BtnSelecionar = new Button();
            LblFilename = new Label();
            label5 = new Label();
            panel3 = new Panel();
            CbxSheets = new ComboBox();
            label3 = new Label();
            BtnSelecionarSheet = new Button();
            FlowColumns = new FlowLayoutPanel();
            LblLoading = new Label();
            TxtPreviewQuery = new RichTextBox();
            PnTextBox.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            FlowColumns.SuspendLayout();
            SuspendLayout();
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Tomato;
            BtnExit.Cursor = Cursors.Hand;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = Color.White;
            BtnExit.ImageAlign = ContentAlignment.MiddleRight;
            BtnExit.Location = new Point(589, 627);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(384, 39);
            BtnExit.TabIndex = 9;
            BtnExit.Text = "Voltar";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExitClick;
            // 
            // PnTextBox
            // 
            PnTextBox.BackColor = Color.FromArgb(30, 30, 30);
            PnTextBox.Controls.Add(label6);
            PnTextBox.Controls.Add(TxtTableName);
            PnTextBox.Controls.Add(label2);
            PnTextBox.Controls.Add(TxtConnectionString);
            PnTextBox.Controls.Add(label1);
            PnTextBox.Controls.Add(TxtNomeScript);
            PnTextBox.Controls.Add(label4);
            PnTextBox.Location = new Point(24, 12);
            PnTextBox.Name = "PnTextBox";
            PnTextBox.Size = new Size(384, 239);
            PnTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(30, 30, 30);
            label6.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(16, 138);
            label6.Name = "label6";
            label6.Size = new Size(349, 23);
            label6.TabIndex = 18;
            label6.Text = "Ex: host;database;user;password";
            // 
            // TxtTableName
            // 
            TxtTableName.BorderStyle = BorderStyle.FixedSingle;
            TxtTableName.Font = new Font("Montserrat SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtTableName.Location = new Point(18, 194);
            TxtTableName.Name = "TxtTableName";
            TxtTableName.Size = new Size(349, 33);
            TxtTableName.TabIndex = 17;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(80, 80, 80);
            label2.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 169);
            label2.Name = "label2";
            label2.Size = new Size(150, 31);
            label2.TabIndex = 16;
            label2.Text = "Nome da Tabela";
            // 
            // TxtConnectionString
            // 
            TxtConnectionString.BorderStyle = BorderStyle.FixedSingle;
            TxtConnectionString.Font = new Font("Montserrat SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtConnectionString.Location = new Point(16, 107);
            TxtConnectionString.Name = "TxtConnectionString";
            TxtConnectionString.Size = new Size(349, 33);
            TxtConnectionString.TabIndex = 15;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(80, 80, 80);
            label1.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 82);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 14;
            label1.Text = "String de Conexão";
            // 
            // TxtNomeScript
            // 
            TxtNomeScript.BorderStyle = BorderStyle.FixedSingle;
            TxtNomeScript.Font = new Font("Montserrat SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtNomeScript.Location = new Point(16, 39);
            TxtNomeScript.Name = "TxtNomeScript";
            TxtNomeScript.Size = new Size(349, 33);
            TxtNomeScript.TabIndex = 13;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(80, 80, 80);
            label4.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 14);
            label4.Name = "label4";
            label4.Size = new Size(133, 31);
            label4.TabIndex = 12;
            label4.Text = "Nome do Script";
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.FromArgb(178, 243, 95);
            BtnSalvar.Cursor = Cursors.Hand;
            BtnSalvar.FlatAppearance.BorderSize = 0;
            BtnSalvar.FlatStyle = FlatStyle.Flat;
            BtnSalvar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvar.ForeColor = Color.FromArgb(19, 19, 19);
            BtnSalvar.ImageAlign = ContentAlignment.MiddleRight;
            BtnSalvar.Location = new Point(12, 627);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(545, 39);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar Script";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvarClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(CBoxFirstLine);
            panel1.Controls.Add(BtnSelecionar);
            panel1.Controls.Add(LblFilename);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(441, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 101);
            panel1.TabIndex = 20;
            // 
            // CBoxFirstLine
            // 
            CBoxFirstLine.AutoSize = true;
            CBoxFirstLine.Font = new Font("Montserrat Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBoxFirstLine.Location = new Point(8, 64);
            CBoxFirstLine.Name = "CBoxFirstLine";
            CBoxFirstLine.Size = new Size(252, 25);
            CBoxFirstLine.TabIndex = 25;
            CBoxFirstLine.Text = "Deseja pular a primeira linha?";
            CBoxFirstLine.UseVisualStyleBackColor = true;
            // 
            // BtnSelecionar
            // 
            BtnSelecionar.BackColor = Color.FromArgb(178, 243, 95);
            BtnSelecionar.Cursor = Cursors.Hand;
            BtnSelecionar.FlatAppearance.BorderSize = 0;
            BtnSelecionar.FlatStyle = FlatStyle.Flat;
            BtnSelecionar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSelecionar.ForeColor = Color.FromArgb(15, 15, 15);
            BtnSelecionar.Location = new Point(369, 14);
            BtnSelecionar.Name = "BtnSelecionar";
            BtnSelecionar.Size = new Size(139, 75);
            BtnSelecionar.TabIndex = 21;
            BtnSelecionar.Text = "Selecionar";
            BtnSelecionar.UseVisualStyleBackColor = false;
            BtnSelecionar.Click += BtnSelecionarClick;
            // 
            // LblFilename
            // 
            LblFilename.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFilename.ForeColor = Color.White;
            LblFilename.Location = new Point(6, 28);
            LblFilename.Name = "LblFilename";
            LblFilename.Size = new Size(338, 44);
            LblFilename.TabIndex = 23;
            LblFilename.Text = "Nenhum arquivo selecionado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 2);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 22;
            label5.Text = "Arquivo atual";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.Controls.Add(CbxSheets);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(BtnSelecionarSheet);
            panel3.Location = new Point(441, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(517, 93);
            panel3.TabIndex = 26;
            // 
            // CbxSheets
            // 
            CbxSheets.Font = new Font("Montserrat SemiBold", 15.75F, FontStyle.Bold);
            CbxSheets.FormattingEnabled = true;
            CbxSheets.Location = new Point(8, 44);
            CbxSheets.Name = "CbxSheets";
            CbxSheets.Size = new Size(349, 37);
            CbxSheets.TabIndex = 25;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(80, 80, 80);
            label3.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 13);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 18;
            label3.Text = "Nomes das Sheets";
            // 
            // BtnSelecionarSheet
            // 
            BtnSelecionarSheet.BackColor = Color.FromArgb(255, 128, 0);
            BtnSelecionarSheet.Cursor = Cursors.Hand;
            BtnSelecionarSheet.FlatAppearance.BorderSize = 0;
            BtnSelecionarSheet.FlatStyle = FlatStyle.Flat;
            BtnSelecionarSheet.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSelecionarSheet.ForeColor = Color.FromArgb(15, 15, 15);
            BtnSelecionarSheet.Location = new Point(368, 11);
            BtnSelecionarSheet.Name = "BtnSelecionarSheet";
            BtnSelecionarSheet.Size = new Size(140, 70);
            BtnSelecionarSheet.TabIndex = 24;
            BtnSelecionarSheet.Text = "Selecionar Sheet";
            BtnSelecionarSheet.UseVisualStyleBackColor = false;
            BtnSelecionarSheet.Click += BtnSelecionarSheetClick;
            // 
            // FlowColumns
            // 
            FlowColumns.AutoScroll = true;
            FlowColumns.Controls.Add(LblLoading);
            FlowColumns.Location = new Point(22, 268);
            FlowColumns.Name = "FlowColumns";
            FlowColumns.Size = new Size(987, 171);
            FlowColumns.TabIndex = 28;
            // 
            // LblLoading
            // 
            LblLoading.Font = new Font("Montserrat SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLoading.Location = new Point(3, 0);
            LblLoading.Name = "LblLoading";
            LblLoading.Size = new Size(960, 171);
            LblLoading.TabIndex = 0;
            LblLoading.Text = "Aguardando...";
            LblLoading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPreviewQuery
            // 
            TxtPreviewQuery.BackColor = Color.FromArgb(19, 19, 19);
            TxtPreviewQuery.BorderStyle = BorderStyle.None;
            TxtPreviewQuery.Font = new Font("Montserrat Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPreviewQuery.ForeColor = Color.Gray;
            TxtPreviewQuery.Location = new Point(22, 470);
            TxtPreviewQuery.Name = "TxtPreviewQuery";
            TxtPreviewQuery.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            TxtPreviewQuery.Size = new Size(933, 142);
            TxtPreviewQuery.TabIndex = 29;
            TxtPreviewQuery.Text = "INSERT INTO TABELA (ID, DATETIME, CURRENT TIME, ITEM_LIST) VALUES (123, 432423, 432432, 432432)";
            // 
            // FrmModalCreateScript
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 19);
            ClientSize = new Size(985, 678);
            Controls.Add(TxtPreviewQuery);
            Controls.Add(FlowColumns);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(BtnSalvar);
            Controls.Add(PnTextBox);
            Controls.Add(BtnExit);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmModalCreateScript";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Criar Script";
            Load += FrmModalCreateScriptLoad;
            PnTextBox.ResumeLayout(false);
            PnTextBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            FlowColumns.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnExit;
        private Panel PnTextBox;
        private Button BtnSalvar;
        private TextBox TxtNomeScript;
        private Label label4;
        private TextBox TxtConnectionString;
        private Label label1;
        private TextBox TxtTableName;
        private Label label2;
        private Panel panel1;
        private Button BtnSelecionar;
        private Label LblFilename;
        private Label label5;
        private CheckBox CBoxFirstLine;
        private Panel panel3;
        private Label label3;
        private Button BtnSelecionarSheet;
        private ComboBox CbxSheets;
        private FlowLayoutPanel FlowColumns;
        private RichTextBox TxtPreviewQuery;
        private Label LblLoading;
        private Label label6;
    }
}