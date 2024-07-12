using ConsumerSQLtoExcel.Design;

namespace ConsumerSQLtoExcel
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            PnRightSection = new Panel();
            LblScriptAtual = new Label();
            label4 = new Label();
            BtnSelecionarScript = new Button();
            LblFilename = new Label();
            label2 = new Label();
            panel1 = new Panel();
            BtnSelecionar = new Button();
            PnSectionBotton = new Panel();
            CkbFirstLine = new CheckBox();
            LblStatus = new Label();
            label3 = new Label();
            PicStartImage = new PictureBox();
            PgBarProcess = new ProgressBar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            FrmRounded = new ElipseControl();
            panel2 = new Panel();
            FlowScripts = new FlowLayoutPanel();
            BtnExit = new Button();
            TimerScriptChanged = new System.Windows.Forms.Timer(components);
            TimerIsAllOk = new System.Windows.Forms.Timer(components);
            PnRightSection.SuspendLayout();
            PnSectionBotton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicStartImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnRightSection
            // 
            PnRightSection.BackColor = Color.FromArgb(15, 15, 15);
            PnRightSection.Controls.Add(LblScriptAtual);
            PnRightSection.Controls.Add(label4);
            PnRightSection.Controls.Add(BtnSelecionarScript);
            PnRightSection.Controls.Add(LblFilename);
            PnRightSection.Controls.Add(label2);
            PnRightSection.Controls.Add(panel1);
            PnRightSection.Controls.Add(BtnSelecionar);
            PnRightSection.Location = new Point(771, 22);
            PnRightSection.Name = "PnRightSection";
            PnRightSection.Size = new Size(200, 278);
            PnRightSection.TabIndex = 0;
            // 
            // LblScriptAtual
            // 
            LblScriptAtual.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblScriptAtual.ForeColor = Color.White;
            LblScriptAtual.Location = new Point(20, 33);
            LblScriptAtual.Name = "LblScriptAtual";
            LblScriptAtual.Size = new Size(159, 52);
            LblScriptAtual.TabIndex = 9;
            LblScriptAtual.Text = "nenhum script selecionado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 8);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 8;
            label4.Text = "Script Atual";
            // 
            // BtnSelecionarScript
            // 
            BtnSelecionarScript.BackColor = Color.FromArgb(178, 243, 95);
            BtnSelecionarScript.Cursor = Cursors.Hand;
            BtnSelecionarScript.FlatAppearance.BorderSize = 0;
            BtnSelecionarScript.FlatStyle = FlatStyle.Flat;
            BtnSelecionarScript.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSelecionarScript.ForeColor = Color.FromArgb(15, 15, 15);
            BtnSelecionarScript.Location = new Point(20, 88);
            BtnSelecionarScript.Name = "BtnSelecionarScript";
            BtnSelecionarScript.Size = new Size(159, 39);
            BtnSelecionarScript.TabIndex = 7;
            BtnSelecionarScript.Text = "Criar Script";
            BtnSelecionarScript.UseVisualStyleBackColor = false;
            BtnSelecionarScript.Click += BtnSelecionarScriptClick;
            // 
            // LblFilename
            // 
            LblFilename.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFilename.ForeColor = Color.White;
            LblFilename.Location = new Point(20, 163);
            LblFilename.Name = "LblFilename";
            LblFilename.Size = new Size(159, 52);
            LblFilename.TabIndex = 6;
            LblFilename.Text = "Nenhum arquivo selecionado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 138);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 5;
            label2.Text = "Arquivo atual";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Location = new Point(8, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 2);
            panel1.TabIndex = 2;
            // 
            // BtnSelecionar
            // 
            BtnSelecionar.BackColor = Color.FromArgb(178, 243, 95);
            BtnSelecionar.Cursor = Cursors.Hand;
            BtnSelecionar.FlatAppearance.BorderSize = 0;
            BtnSelecionar.FlatStyle = FlatStyle.Flat;
            BtnSelecionar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSelecionar.ForeColor = Color.FromArgb(15, 15, 15);
            BtnSelecionar.Location = new Point(20, 218);
            BtnSelecionar.Name = "BtnSelecionar";
            BtnSelecionar.Size = new Size(159, 39);
            BtnSelecionar.TabIndex = 1;
            BtnSelecionar.Text = "Selecionar";
            BtnSelecionar.UseVisualStyleBackColor = false;
            BtnSelecionar.Click += BtnSelecionarClick;
            // 
            // PnSectionBotton
            // 
            PnSectionBotton.BackColor = Color.FromArgb(15, 15, 15);
            PnSectionBotton.Controls.Add(CkbFirstLine);
            PnSectionBotton.Controls.Add(LblStatus);
            PnSectionBotton.Controls.Add(label3);
            PnSectionBotton.Controls.Add(PicStartImage);
            PnSectionBotton.Controls.Add(PgBarProcess);
            PnSectionBotton.Location = new Point(209, 316);
            PnSectionBotton.Name = "PnSectionBotton";
            PnSectionBotton.Size = new Size(762, 118);
            PnSectionBotton.TabIndex = 2;
            // 
            // CkbFirstLine
            // 
            CkbFirstLine.AutoSize = true;
            CkbFirstLine.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            CkbFirstLine.ForeColor = Color.White;
            CkbFirstLine.Location = new Point(117, 47);
            CkbFirstLine.Name = "CkbFirstLine";
            CkbFirstLine.Size = new Size(273, 20);
            CkbFirstLine.TabIndex = 12;
            CkbFirstLine.Text = "Deseja pular a primeira linha da planilha ?";
            CkbFirstLine.UseVisualStyleBackColor = true;
            // 
            // LblStatus
            // 
            LblStatus.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStatus.ForeColor = Color.Yellow;
            LblStatus.Location = new Point(238, 17);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(470, 21);
            LblStatus.TabIndex = 10;
            LblStatus.Text = "AGUARDANDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(111, 17);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 11;
            label3.Text = "STATUS ATUAL:";
            // 
            // PicStartImage
            // 
            PicStartImage.Cursor = Cursors.Hand;
            PicStartImage.Image = Properties.Resources.go_image;
            PicStartImage.Location = new Point(15, 14);
            PicStartImage.Name = "PicStartImage";
            PicStartImage.Size = new Size(90, 90);
            PicStartImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PicStartImage.TabIndex = 1;
            PicStartImage.TabStop = false;
            PicStartImage.Click += PicStartImageClick;
            // 
            // PgBarProcess
            // 
            PgBarProcess.Location = new Point(111, 75);
            PgBarProcess.Name = "PgBarProcess";
            PgBarProcess.Size = new Size(570, 29);
            PgBarProcess.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 26);
            label1.Name = "label1";
            label1.Size = new Size(125, 26);
            label1.TabIndex = 4;
            label1.Text = "ExcelToSQL";
            // 
            // FrmRounded
            // 
            FrmRounded.CornerRadius = 50;
            FrmRounded.TargetControl = this;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 15, 15);
            panel2.Location = new Point(209, 452);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 159);
            panel2.TabIndex = 3;
            // 
            // FlowScripts
            // 
            FlowScripts.BackColor = Color.FromArgb(15, 15, 15);
            FlowScripts.Location = new Point(209, 22);
            FlowScripts.Name = "FlowScripts";
            FlowScripts.Size = new Size(544, 278);
            FlowScripts.TabIndex = 5;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Tomato;
            BtnExit.Cursor = Cursors.Hand;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.ForeColor = Color.White;
            BtnExit.Image = (Image)resources.GetObject("BtnExit.Image");
            BtnExit.ImageAlign = ContentAlignment.MiddleRight;
            BtnExit.Location = new Point(20, 567);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(170, 39);
            BtnExit.TabIndex = 7;
            BtnExit.Text = "       Exit App";
            BtnExit.TextAlign = ContentAlignment.MiddleLeft;
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // TimerScriptChanged
            // 
            TimerScriptChanged.Interval = 1000;
            TimerScriptChanged.Tick += TimerScriptChangedTick;
            // 
            // TimerIsAllOk
            // 
            TimerIsAllOk.Enabled = true;
            TimerIsAllOk.Interval = 500;
            TimerIsAllOk.Tick += TimerIsAllOkTick;
            // 
            // FrmPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(9, 9, 9);
            ClientSize = new Size(996, 633);
            Controls.Add(BtnExit);
            Controls.Add(FlowScripts);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(PnSectionBotton);
            Controls.Add(PnRightSection);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmPrincipal_Load;
            MouseMove += FrmPrincipalMouseMove;
            PnRightSection.ResumeLayout(false);
            PnRightSection.PerformLayout();
            PnSectionBotton.ResumeLayout(false);
            PnSectionBotton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicStartImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PnRightSection;
        private Panel PnSectionBotton;
        private Label label1;
        private PictureBox pictureBox1;
        private Button BtnSelecionar;
        private ElipseControl FrmRounded;
        private Panel panel1;
        private Label label2;
        private Label LblFilename;
        private Panel panel2;
        private FlowLayoutPanel FlowScripts;
        private Button BtnExit;
        private Label LblScriptAtual;
        private Label label4;
        private Button BtnSelecionarScript;
        private System.Windows.Forms.Timer TimerScriptChanged;
        private ProgressBar PgBarProcess;
        private Label LblStatus;
        private Label label5;
        private Label label3;
        private PictureBox PicStartImage;
        private System.Windows.Forms.Timer TimerIsAllOk;
        private CheckBox CkbFirstLine;
    }
}
