using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto
{
    public partial class frmCadFuncionario : Form
    {
        string Id, Nome;

        ConexaoBanco conexaoBanco = new ConexaoBanco();
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        public frmCadFuncionario(string id, string nome)
        {
            Id = id;
            Nome = nome;
            InitializeComponent();
        }


        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            var t = conexaoBanco.ConsultarPorId("1").Tables["FUNCIONARIO"].Rows.Count;
            if (t == 0)
            {
                MessageBox.Show("O primeiro cadastro será o Administrador do sistema, guarde bem a sua senha", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }

            if (Nome != null) //Alterando um cadastro
            {                
                this.Text = "Alterar Cadastro";                
                txtNome.Text = Nome;
                txtNome.Enabled = false;
                txtSenha.Text = "******";
                txtSenha.Enabled = false;
                btnVerSenha.Enabled = false;
                txtEmail.Enabled = false;

                var email = conexaoBanco.LocalizarEmailPorId(Id).Split('@');
                txtEmail.Text = email[0] + " * * * * *";

                if (conexaoBanco.VerificarCadastroAtivo(Id) == 0)
                {
                    lblDesativarCadastro.Text = "Ativar Cadastro";
                }
            }
            else //Cadastrando um novo funcionário
            {                
                lblAlterarNome.Visible = false;
                lblAlterarEmail.Visible = false;
                lblAlterarSenha.Visible = false;
                lblDesativarCadastro.Visible = false;
            }

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Enabled == true) //Novo cadastro
            {
                if (txtNome.TextLength < 3)
                {
                    MessageBox.Show("Preencha o campo Nome com no mínimo 3 letras", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (EmailValido(txtEmail.Text) == false)
                {
                    MessageBox.Show("O endereço de e-mail é inválido", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSenha.TextLength < 4)
                {
                    MessageBox.Show("Preencha o campo Senha com no mínimo 4 caracteres", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show($"Esse e-mail será usado para recuperar a sua senha futuramente, ele está correto? >>{txtEmail.Text}<<", "Confirme seu e-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conexaoBanco.SalvarCadastro(txtNome.Text, txtSenha.Text, txtEmail.Text);

                        txtNome.Text = "";
                        txtSenha.Text = "";
                        txtEmail.Text = "";
                        txtNome.Focus();
                    }

                }
            }
            else //Alterar cadastro
            {
                if (txtNome.Enabled)
                {
                    if (txtNome.TextLength < 3)
                    {
                        MessageBox.Show("Preencha o campo Nome com no mínimo 3 letras", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        conexaoBanco.SalvarNome(Id, txtNome.Text);
                        txtNome.Enabled = false;
                    }
                }


                if (txtEmail.Enabled)
                {
                    if (EmailValido(txtEmail.Text) == false)
                    {
                        MessageBox.Show("O endereço de e-mail é inválido", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show($"Esse e-mail será usado para recuperar a sua senha futuramente, ele está correto? >>{txtEmail.Text}<<", "Confirme seu e-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            conexaoBanco.SalvarEmail(Id, txtEmail.Text);

                            txtEmail.Enabled = false;
                        }
                    }
                }


            }

        }

        private static bool EmailValido(string email)
        {
            // Define a expressão regular para validar o formato do e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Verifica se o e-mail corresponde ao padrão
            return Regex.IsMatch(email, pattern);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Usado para redefinir a senha")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Usado para redefinir a senha";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void lblAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmailRecuperacao frmEmailRecuperacao = new frmEmailRecuperacao(Id);
            frmEmailRecuperacao.ShowDialog();
        }

        private void lblAlterarNome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSenhaDoAdmin senhaDoAdmin = new frmSenhaDoAdmin();
            if (senhaDoAdmin.ShowDialog() == DialogResult.OK)
            {
                txtNome.Enabled = true;
            }
        }

        private void lblAlterarEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSenhaDoAdmin senhaDoAdmin = new frmSenhaDoAdmin();
            if (senhaDoAdmin.ShowDialog() == DialogResult.OK)
            {
                txtEmail.Enabled = true;
                txtEmail.ForeColor = Color.Black;
                txtEmail.Text = conexaoBanco.LocalizarEmailPorId(Id);
            }
        }

        private void lblDesativarCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSenhaDoAdmin senhaDoAdmin = new frmSenhaDoAdmin();
            if (senhaDoAdmin.ShowDialog() == DialogResult.OK)
            {
                if (lblDesativarCadastro.Text == "Ativar Cadastro")
                {
                    if (conexaoBanco.DesativarCadastro(Id, 1) == 1)
                    {
                        MessageBox.Show("Cadastro Ativado!", "Ativado", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }

                    lblDesativarCadastro.Text = "Desativar Cadastro";
                }
                else
                {
                    if (conexaoBanco.DesativarCadastro(Id, 0) == 1)
                    {
                        MessageBox.Show("Cadastro Desativado!", "Desativado", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }

                    lblDesativarCadastro.Text = "Ativar Cadastro";
                }
                
            }
        }
               

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }


    }
}
