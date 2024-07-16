using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ponto
{
    public partial class frmConfiguracoes : Form
    {
        ConexaoBanco conexaoBanco = new ConexaoBanco();
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            if (conexaoBanco.CarregarConfiguracoesEmail() != null)
            {
                List<string> config = conexaoBanco.CarregarConfiguracoesEmail();
                txtEmailPonte.Text = config[0];
                txtSenha.Text = config[1];
                txtSmtp.Text = config[2];
                txtPorta.Text = config[3];
                if (config[4] == "1") { cbSSL.Checked = true; }
                txtEmailContabi.Text = config[5];
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void lblTestarEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Configurações do servidor SMTP
                SmtpClient smtpClient = new SmtpClient(txtSmtp.Text); // Substitua pelo seu servidor SMTP
                smtpClient.Port = int.Parse(txtPorta.Text); // Porta padrão para SMTP
                smtpClient.Credentials = new NetworkCredential(txtEmailPonte.Text, txtSenha.Text); // Substitua pelo seu e-mail e senha
                smtpClient.EnableSsl = cbSSL.Checked; // Habilitar SSL para segurança

                // Mensagem de e-mail
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(txtEmailPonte.Text); // Seu endereço de e-mail
                mailMessage.To.Add(txtEmailPonte.Text); // E-mail do destinatário
                mailMessage.Subject = "Teste de e-mail Lemarc"; // Assunto do e-mail
                mailMessage.Body = "Teste concluido com sucesso!"; // Corpo do e-mail

                // Envio do e-mail
                smtpClient.Send(mailMessage);
                MessageBox.Show("E-mail enviado com sucesso para: " + txtEmailPonte.Text, "E-mail enviado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception a)
            {
                MessageBox.Show("Erro ao enviar e-mail. " + a.Message);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int SSL = 0; if (cbSSL.Checked) { SSL = 1; }
            conexaoBanco.SalvarConfiguracoesEmail(txtEmailPonte.Text, txtSenha.Text, txtSmtp.Text, txtPorta.Text, SSL, txtEmailContabi.Text);
        }
    }
}
