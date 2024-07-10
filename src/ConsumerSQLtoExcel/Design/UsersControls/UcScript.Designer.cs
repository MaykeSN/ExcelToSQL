namespace ConsumerSQLtoExcel.Design.UsersControls
{
    partial class UcScript
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
            PnColor = new Panel();
            LblScriptName = new Label();
            SuspendLayout();
            // 
            // PnColor
            // 
            PnColor.BackColor = Color.OrangeRed;
            PnColor.Location = new Point(-6, -1);
            PnColor.Name = "PnColor";
            PnColor.Size = new Size(291, 12);
            PnColor.TabIndex = 16;
            // 
            // LblScriptName
            // 
            LblScriptName.Cursor = Cursors.Hand;
            LblScriptName.Dock = DockStyle.Fill;
            LblScriptName.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblScriptName.ForeColor = Color.White;
            LblScriptName.Location = new Point(0, 0);
            LblScriptName.Name = "LblScriptName";
            LblScriptName.Size = new Size(266, 68);
            LblScriptName.TabIndex = 17;
            LblScriptName.Text = "Script Atual";
            LblScriptName.TextAlign = ContentAlignment.MiddleCenter;
            LblScriptName.Click += LblScriptNameClick;
            // 
            // UcScript
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 19);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(PnColor);
            Controls.Add(LblScriptName);
            Name = "UcScript";
            Size = new Size(266, 68);
            ResumeLayout(false);
        }

        #endregion

        public Panel PnColor;
        private Label LblScriptName;
    }
}
