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
            if (Nome != null)
            {
                txtNome.Text = Nome;                
                txtSenha.Visible = false;
                btnVerSenha.Visible = false;
                txtEmail.Visible = false;
                lblEmail.Visible = false;
                lblSenha.Visible = false;
            }
            else
            {
                lblAlterarSenha.Visible = false;
            }

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Visible == true) //Novo cadastro
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
                    if (MessageBox.Show($"Esse e-mail será usado para recuperar a sua senha futuramente, ele está correto? >> {txtEmail.Text} <<", "Confirme seu e-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                if (txtNome.TextLength < 3)
                {
                    MessageBox.Show("Preencha o campo Nome com no mínimo 3 letras", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conexaoBanco.AlterarCadastro(Id, txtNome.Text);
                    Close();
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
            if(txtEmail.Text == "Usado para redefinir a senha")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
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
