using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto
{
    public partial class frmAlterarSenha : Form
    {
        string Id, SenhaGerada;

        public frmAlterarSenha()
        {
            InitializeComponent();
        }
       
        public frmAlterarSenha(string id, string senhaGerada)
        {
            InitializeComponent();
            Id = id;
            SenhaGerada = senhaGerada;
        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.UseSystemPasswordChar == true)
            {
                txtNovaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtNovaSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtSenhaRecebida.Text != SenhaGerada)
            {
                MessageBox.Show("A senha informada está incorreta", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtNovaSenha.TextLength < 4)
            {
                MessageBox.Show("Preencha o campo 'Nova Senha' com no mínimo 4 caracteres", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ConexaoBanco conexaoBanco = new ConexaoBanco();
                int sucesso = conexaoBanco.InserirSenhaGerada(Id, txtNovaSenha.Text);
                if (sucesso == 1)
                {
                    MessageBox.Show("Senha alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
