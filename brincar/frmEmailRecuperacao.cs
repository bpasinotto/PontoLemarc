using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ponto
{
    public partial class frmEmailRecuperacao : Form
    {
        string Id;

        public frmEmailRecuperacao()
        {
            InitializeComponent();
        }

        public frmEmailRecuperacao(string id)
        {
            Id = id;            
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ConexaoBanco banco = new ConexaoBanco();
            string emailBanco = banco.LocalizarEmailPorId(Id);

            string senhaGerada = GerenciadorDeSenha.GerarNovaSenha();

            if (emailBanco == txtEmail.Text)
            {
                bool emailEnviado = GerenciadorDeSenha.EnviarEmailRedefinicaoSenha(txtEmail.Text, senhaGerada);
                if (emailEnviado)
                {
                    banco.InserirSenhaGerada(Id, senhaGerada);

                    MessageBox.Show("E-mail enviado com sucesso para: " + txtEmail.Text, "E-mail enviado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();

                    //Chamar tela para inserir nova senha
                    frmAlterarSenha frmAlterarSenha = new frmAlterarSenha(Id, senhaGerada);
                    frmAlterarSenha.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Falha ao enviar o e-mail", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("E-mail não encontrado, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
