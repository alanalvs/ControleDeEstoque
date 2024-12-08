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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                MessageBox.Show("Cadastro concluído com sucesso!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new Helpers().LimparTela(this);
            }
            else
                MessageBox.Show("Preencha todos os campos!", "VIZZION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public bool VerificarCampos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text)) return false;
            if (string.IsNullOrEmpty(txtDescricao.Text)) return false;
            if (string.IsNullOrEmpty(txtClassificacao.Text)) return false;
            if (string.IsNullOrEmpty(txtEstoque.Text)) return false;
            if (string.IsNullOrEmpty(txtNCM.Text)) return false;
            if (string.IsNullOrEmpty(txtPreco.Text)) return false;

            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {

            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                //Verifica no banco de existe o produto, se existir tras para tela e se não existir informar ao usuario e não permitir continuar...
            }
        }
    }
}
