using ControleDeEstoque.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque.views
{
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }
 
        #region Eventos

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos() && VerificarTamanhoCampos())
            {
                DescricaoNCM(txtNCM.TextNew);
                AlterarNomeClassificacao(txtClassificacao.TextNew);
                //MessageBox.Show("Cadastro concluído com sucesso!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //new Helpers().LimparTela(this);   
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Produto excluído com sucesso!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Helpers().LimparTela(this);
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                //Verifica no banco de existe o produto, se existir tras para tela e se não existir informar ao usuario e não permitir continuar...
            }
        }

        private void txtTabPreco_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTabPreco.TextNew) && !string.IsNullOrEmpty(txtEstoque.TextNew))
            {
                AjustarPrecoDeEstoque();
            }
        }

        private void txtTabPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        #endregion

        #region Metodos

        public bool VerificarTamanhoCampos()
        {
            if (txtDescricao.TextNew.Length > 10)
            {
                MessageBox.Show("Limite máximo de 10 caracteres!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool VerificarCampos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Campo código não preenchido!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Campo descrição não preenchido!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtClassificacao.Text))
            {
                MessageBox.Show("Campo classificação não preenchido!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtEstoque.Text))
            {
                MessageBox.Show("Campo estoque não preenchido!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtNCM.Text))
            {
                MessageBox.Show("Campo NCM não preenchido!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtTabPreco.Text))
            {
                MessageBox.Show("Campo tabela de preço não preenchido!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void DescricaoNCM(string descricaoNCM)
        {
            if (!txtNCM.Text.StartsWith("111"))
                txtNCM.Text = "111" + descricaoNCM;
        }

        public void AlterarNomeClassificacao(string classificacao)
        {
            txtClassificacao.Text = classificacao.Replace("Principal", "Secundário");
        }

        public void AjustarPrecoDeEstoque()
        {
            int calculoPreco = int.Parse(txtTabPreco.TextNew) * int.Parse(txtEstoque.TextNew);
            txtPreco.Text = calculoPreco.ToString();
        }

        #endregion
    }
}
