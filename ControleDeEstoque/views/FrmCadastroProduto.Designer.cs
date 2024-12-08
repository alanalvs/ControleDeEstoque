namespace ControleDeEstoque.views
{
    partial class FrmCadastroProduto
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
            this.txtDescricao = new ControleDeEstoque.controls.novoTextBox();
            this.lbl_calendario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassificacao = new ControleDeEstoque.controls.novoTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new ControleDeEstoque.controls.novoTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstoque = new ControleDeEstoque.controls.novoTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNCM = new ControleDeEstoque.controls.novoTextBox();
            this.btnConfirmar = new ControleDeEstoque.controls.ModeloBotao();
            this.btnSair = new ControleDeEstoque.controls.ModeloBotao();
            this.btnExcluir = new ControleDeEstoque.controls.ModeloBotao();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new ControleDeEstoque.controls.novoTextBox();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtDescricao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescricao.BorderSize = 1;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtDescricao.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescricao.Location = new System.Drawing.Point(147, 154);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Padding = new System.Windows.Forms.Padding(9);
            this.txtDescricao.PasswordChar = false;
            this.txtDescricao.ReadOnly = false;
            this.txtDescricao.Size = new System.Drawing.Size(333, 35);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.TextNew = "";
            this.txtDescricao.UnderlinedStyle = true;
            // 
            // lbl_calendario
            // 
            this.lbl_calendario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_calendario.AutoSize = true;
            this.lbl_calendario.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calendario.Location = new System.Drawing.Point(42, 160);
            this.lbl_calendario.Name = "lbl_calendario";
            this.lbl_calendario.Size = new System.Drawing.Size(101, 29);
            this.lbl_calendario.TabIndex = 2;
            this.lbl_calendario.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Classificação";
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtClassificacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtClassificacao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtClassificacao.BorderSize = 1;
            this.txtClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtClassificacao.ForeColor = System.Drawing.Color.DimGray;
            this.txtClassificacao.Location = new System.Drawing.Point(179, 211);
            this.txtClassificacao.Margin = new System.Windows.Forms.Padding(5);
            this.txtClassificacao.Multiline = false;
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Padding = new System.Windows.Forms.Padding(9);
            this.txtClassificacao.PasswordChar = false;
            this.txtClassificacao.ReadOnly = false;
            this.txtClassificacao.Size = new System.Drawing.Size(333, 35);
            this.txtClassificacao.TabIndex = 3;
            this.txtClassificacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClassificacao.TextNew = "";
            this.txtClassificacao.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Window;
            this.txtPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtPreco.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPreco.BorderSize = 1;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtPreco.ForeColor = System.Drawing.Color.DimGray;
            this.txtPreco.Location = new System.Drawing.Point(147, 256);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(5);
            this.txtPreco.Multiline = false;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Padding = new System.Windows.Forms.Padding(9);
            this.txtPreco.PasswordChar = false;
            this.txtPreco.ReadOnly = false;
            this.txtPreco.Size = new System.Drawing.Size(333, 35);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPreco.TextNew = "";
            this.txtPreco.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estoque";
            // 
            // txtEstoque
            // 
            this.txtEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstoque.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtEstoque.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEstoque.BorderSize = 1;
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtEstoque.ForeColor = System.Drawing.Color.DimGray;
            this.txtEstoque.Location = new System.Drawing.Point(147, 301);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(5);
            this.txtEstoque.Multiline = false;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Padding = new System.Windows.Forms.Padding(9);
            this.txtEstoque.PasswordChar = false;
            this.txtEstoque.ReadOnly = false;
            this.txtEstoque.Size = new System.Drawing.Size(333, 35);
            this.txtEstoque.TabIndex = 7;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstoque.TextNew = "";
            this.txtEstoque.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "NCM";
            // 
            // txtNCM
            // 
            this.txtNCM.BackColor = System.Drawing.SystemColors.Window;
            this.txtNCM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtNCM.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNCM.BorderSize = 1;
            this.txtNCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtNCM.ForeColor = System.Drawing.Color.DimGray;
            this.txtNCM.Location = new System.Drawing.Point(593, 154);
            this.txtNCM.Margin = new System.Windows.Forms.Padding(5);
            this.txtNCM.Multiline = false;
            this.txtNCM.Name = "txtNCM";
            this.txtNCM.Padding = new System.Windows.Forms.Padding(9);
            this.txtNCM.PasswordChar = false;
            this.txtNCM.ReadOnly = false;
            this.txtNCM.Size = new System.Drawing.Size(190, 35);
            this.txtNCM.TabIndex = 9;
            this.txtNCM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNCM.TextNew = "";
            this.txtNCM.UnderlinedStyle = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmar.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmar.BorderRadius = 15;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(50, 389);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 40);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSair.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSair.BorderRadius = 15;
            this.btnSair.BorderSize = 0;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(362, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 40);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.BackgroundColor = System.Drawing.Color.Red;
            this.btnExcluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExcluir.BorderRadius = 15;
            this.btnExcluir.BorderSize = 0;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(206, 389);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 40);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextColor = System.Drawing.Color.White;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cadastro de produtos";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(147, 97);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(9);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.ReadOnly = false;
            this.txtCodigo.Size = new System.Drawing.Size(171, 35);
            this.txtCodigo.TabIndex = 15;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.TextNew = "";
            this.txtCodigo.UnderlinedStyle = true;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNCM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.lbl_calendario);
            this.Controls.Add(this.txtDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroProduto";
            this.Text = "Cadastro de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.novoTextBox txtDescricao;
        private System.Windows.Forms.Label lbl_calendario;
        private System.Windows.Forms.Label label1;
        private controls.novoTextBox txtClassificacao;
        private System.Windows.Forms.Label label2;
        private controls.novoTextBox txtPreco;
        private System.Windows.Forms.Label label3;
        private controls.novoTextBox txtEstoque;
        private System.Windows.Forms.Label label4;
        private controls.novoTextBox txtNCM;
        private controls.ModeloBotao btnConfirmar;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private controls.novoTextBox txtCodigo;
    }
}