namespace ConsumerSQLtoExcel.Design.UsersControls
{
    partial class ColumnsControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnsControl));
            LblColumn = new Label();
            pictureBox1 = new PictureBox();
            TxtSqlColumn = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblColumn
            // 
            LblColumn.AutoSize = true;
            LblColumn.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblColumn.ForeColor = Color.FromArgb(178, 243, 95);
            LblColumn.Location = new Point(15, 29);
            LblColumn.Name = "LblColumn";
            LblColumn.Size = new Size(26, 26);
            LblColumn.TabIndex = 0;
            LblColumn.Text = "A";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TxtSqlColumn
            // 
            TxtSqlColumn.BorderStyle = BorderStyle.FixedSingle;
            TxtSqlColumn.Font = new Font("Montserrat SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtSqlColumn.Location = new Point(121, 26);
            TxtSqlColumn.Name = "TxtSqlColumn";
            TxtSqlColumn.Size = new Size(168, 33);
            TxtSqlColumn.TabIndex = 14;
            TxtSqlColumn.TextChanged += TxtSqlColumnTextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 243, 95);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 12);
            panel1.TabIndex = 15;
            // 
            // ColumnsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 19);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(TxtSqlColumn);
            Controls.Add(pictureBox1);
            Controls.Add(LblColumn);
            Name = "ColumnsControl";
            Size = new Size(308, 71);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label LblColumn;
        public PictureBox pictureBox1;
        public TextBox TxtSqlColumn;
        public Panel panel1;
    }
}
