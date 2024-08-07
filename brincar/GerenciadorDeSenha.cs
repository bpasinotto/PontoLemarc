using BCrypt.Net;
using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using Ponto;

public class GerenciadorDeSenha
{
    // Método para criar um hash seguro de uma senha com salt
    public static string SenhaHash(string senha)
    {
        // Geração de um salt aleatório
        string salt = BCrypt.Net.BCrypt.GenerateSalt(12); // O número 12 é o custo (work factor) recomendado

        // Hashing da senha com o salt
        string senhaHashed = BCrypt.Net.BCrypt.HashPassword(senha, salt);

        // Retorno do hash da senha concatenado com o salt (para ser armazenado no banco de dados)
        return senhaHashed + ":" + salt;
    }

    // Método para verificar se a senha fornecida corresponde ao hash armazenado
    public static bool VerificarSenha(string senha, string senhaHashed)
    {
        try
        {
            // Separando o hash da senha do salt
            string[] partes = senhaHashed.Split(':');
            string armazenaHash = partes[0];
            string salt = partes[1];

            // Verificando se a senha fornecida corresponde ao hash armazenado
            return BCrypt.Net.BCrypt.Verify(senha, armazenaHash);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao verificar a senha: " + ex.Message);
            return false;
        }
    }

    public static string GerarNovaSenha()
    {
        // Aqui você pode implementar lógica para gerar uma nova senha aleatória
        // Por exemplo, você pode usar classes do System.Security.Cryptography para gerar uma senha segura
        // Neste exemplo, estamos apenas gerando uma senha simples
        string caracteresPermitidos = "0123456789";
        Random random = new Random();
        char[] senha = new char[5];

        for (int i = 0; i < senha.Length; i++)
        {
            senha[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
        }

        return new string(senha);
    }

    public static bool EnviarEmailRedefinicaoSenha(string email, string novaSenha)
    {             

        try
        {
            // Configurações do servidor SMTP
            SmtpClient smtpClient = new SmtpClient("smtp.lemarcsistemas.com.br"); // Substitua pelo seu servidor SMTP
            smtpClient.Port = 587; // Porta padrão para SMTP
            smtpClient.Credentials = new NetworkCredential("no-reply@lemarcsistemas.com.br", "lemarc@sistemas"); // Substitua pelo seu e-mail e senha
            smtpClient.EnableSsl = false; // Habilitar SSL para segurança

            // Mensagem de e-mail
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("no-reply@lemarcsistemas.com.br"); // Seu endereço de e-mail
            mailMessage.To.Add(email); // E-mail do destinatário
            mailMessage.Subject = "Redefinição de senha Ponto Lemarc"; // Assunto do e-mail
            mailMessage.Body = "No campo 'Senha recebida por e-mail' digite: " + novaSenha; // Corpo do e-mail

            // Envio do e-mail
            smtpClient.Send(mailMessage);

            return true;
        }
        catch (Exception e)
        {    
            MessageBox.Show("Erro ao enviar e-mail. " + e.Message);
            return false;
        }
    }
}
