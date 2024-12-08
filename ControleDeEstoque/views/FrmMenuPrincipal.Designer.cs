namespace ControleDeEstoque.views
{
    partial class FrmMenuPrincipal
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
            this.cabecalhoAplicacao1 = new ControleDeEstoque.controls.CabecalhoAplicacao();
            this.SuspendLayout();
            // 
            // cabecalhoAplicacao1
            // 
            this.cabecalhoAplicacao1.AutoSize = true;
            this.cabecalhoAplicacao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(153)))), ((int)(((byte)(135)))));
            this.cabecalhoAplicacao1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabecalhoAplicacao1.Location = new System.Drawing.Point(0, 0);
            this.cabecalhoAplicacao1.Name = "cabecalhoAplicacao1";
            this.cabecalhoAplicacao1.Size = new System.Drawing.Size(1063, 51);
            this.cabecalhoAplicacao1.TabIndex = 0;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 690);
            this.Controls.Add(this.cabecalhoAplicacao1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.CabecalhoAplicacao cabecalhoAplicacao1;
    }
}