using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ponto
{
    public class ConexaoBanco
    {
        string strConexao = "";
        private FbConnection con;
        FbCommand comando;

        public ConexaoBanco()
        {            
        }

        //private string servidor = "localhost";
        //private string nomeBancoDados = @"C:\Ponto\Banco\PONTO.FDB";
        //private string usuario = "SYSDBA";
        //private string senha = "masterkey";

        //private string strConexao = @"DataSource=localhost; Database=C:\Ponto\Banco\PONTO.FDB; username=SYSDBA; password=masterkey";



        //criar arquivo de texto para armazenar caminho da base de dados
        public bool ArquivoConfig()
        {
            string caminhoConfig = AppDomain.CurrentDomain.BaseDirectory + "config.ini";
            string caminhoBanco = AppDomain.CurrentDomain.BaseDirectory + "PONTO.FDB";
            string usuarioEsenha = " username=SYSDBA; password=masterkey";

            // Verificando se o arquivo existe
            if (File.Exists(caminhoConfig))
            {

                try
                {

                    // Lendo todas as linhas do arquivo
                    string[] linhas = File.ReadAllLines(caminhoConfig);

                    string servidor = linhas[0].Split('=')[1];
                    string nomeBancoDados = linhas[1].Split('=')[1];
                    
                    if (servidor == "" || nomeBancoDados == "")
                    {
                        strConexao = $"DataSource=localhost; Database={caminhoBanco};" + usuarioEsenha;
                    }
                    else
                    {
                        strConexao = $"DataSource={servidor}; Database={nomeBancoDados};" + usuarioEsenha;
                    }

                    con = new FbConnection(strConexao);
                    con.Open();
                    con.Close();
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show($"Não foi possivel se conectar ao Banco de Dados, entre em contato com o Suporte.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {

                // Criando o conteúdo do arquivo de texto
                string conteudoArquivo = "Servidor=\nBancoDeDados=\nNomeDaEmpresa=";

                // Escrevendo o conteúdo no arquivo
                try
                {
                    File.WriteAllText(caminhoConfig, conteudoArquivo);
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show($"Não foi possivel criar o arquivo de configuração, tente executar como Administrador.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public DataSet IdEnome(int ativo)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT ID, NOME FROM FUNCIONARIO WHERE ATIVO = {ativo}", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            try
            {
                con.Open();
                data.Fill(dataset, "FUNCIONARIO");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro de conexão ao banco de dados: " + e.Message);

            }

            return dataset;
        }

        public DataSet ConsultarPorId(string id)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT NOME FROM FUNCIONARIO WHERE ID = {id} AND ATIVO = 1", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            try
            {
                con.Open();
                data.Fill(dataset, "FUNCIONARIO");
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro de conexão ao banco de dados: " + e.Message);
            }

            return dataset;
        }

        public DataSet ProcurarFuncionarioNome(string nome, int ativo)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT ID, NOME FROM FUNCIONARIO WHERE NOME LIKE '%{nome}%' AND ATIVO = {ativo}", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "FUNCIONARIO");
            con.Close();
            return dataset;
        }

        public int VerificarCadastroAtivo(string id)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT ATIVO FROM FUNCIONARIO WHERE ID = {id}", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "FUNCIONARIO");
            int ativo = int.Parse(dataset.Tables["FUNCIONARIO"].Rows[0]["ATIVO"].ToString());
            con.Close();
            return ativo;
        }

        public string LocalizarEmailPorId(string id)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT EMAIL FROM FUNCIONARIO WHERE ID = {id}", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "FUNCIONARIO");
            con.Close();
            string emailBanco = dataset.Tables["FUNCIONARIO"].Rows[0]["EMAIL"].ToString();
            return emailBanco;
        }

        public DataSet PontosPorData(string funcionario, string dataInicio, string dataFim)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT * FROM CONSULTA_PONTOS WHERE \"Funcionário\" = \'{funcionario}\' AND \"Data\" >= '{dataInicio}' AND \"Data\" <= '{dataFim}' ", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "CONSULTA_PONTOS");
            con.Close();
            return dataset;
        }

        public DataSet ConsultaGraficoFuncionario(string funcionario, string dataInicio, string dataFim)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT * FROM CONSULTA_GRAFICO WHERE \"Funcionário\" = \'{funcionario}\' AND \"Data\" >= '{dataInicio}' AND \"Data\" <= '{dataFim}' ", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "CONSULTA_GRAFICO");
            con.Close();
            return dataset;
        }

        public DataSet ConsultaGraficoTodos(string dataInicio, string dataFim)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT * FROM CONSULTA_GRAFICO WHERE \"Data\" >= '{dataInicio}' AND \"Data\" <= '{dataFim}' ", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "CONSULTA_GRAFICO");
            con.Close();
            return dataset;
        }

        public DataSet ConsultaPontosTodos(string dataInicio, string dataFim)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT * FROM CONSULTA_PONTOS WHERE \"Data\" >= '{dataInicio}' AND \"Data\" <= '{dataFim}' ", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "CONSULTA_PONTOS");
            con.Close();
            return dataset;
        }

        public DataSet PontosBatidos(string id)
        {
            ArquivoConfig();
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
            string dataAnterior = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");

            comando = new FbCommand($"SELECT HORA1, HORA2, HORA3, HORA4 FROM HORAS WHERE ID_FUNCIONARIO = {id} AND DATA = '{dataAnterior}'", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "HORAS");
            con.Close();

            if (dataset.Tables["HORAS"].Rows.Count > 0)
            {
                if (dataset.Tables["HORAS"].Rows[0]["HORA2"].ToString() == "")
                {
                    return dataset;
                }
                else
                {
                    comando = new FbCommand($"SELECT HORA1, HORA2, HORA3, HORA4 FROM HORAS WHERE ID_FUNCIONARIO = {id} AND DATA = '{dataAtual}'", con);
                    data = new FbDataAdapter(comando);
                    dataset = new DataSet();
                    con.Open();
                    data.Fill(dataset, "HORAS");
                    con.Close();
                    return dataset;
                }
            }
            else
            {
                comando = new FbCommand($"SELECT HORA1, HORA2, HORA3, HORA4 FROM HORAS WHERE ID_FUNCIONARIO = {id} AND DATA = '{dataAtual}'", con);
                data = new FbDataAdapter(comando);
                dataset = new DataSet();
                con.Open();
                data.Fill(dataset, "HORAS");
                con.Close();
                return dataset;
            }
        }

        public bool ValidarSenha(string id, string senha)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT * FROM FUNCIONARIO WHERE ID = {id}", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "FUNCIONARIO");
            con.Close();

            bool senhaCorreta = GerenciadorDeSenha.VerificarSenha(senha, dataset.Tables["FUNCIONARIO"].Rows[0]["SENHA"].ToString());

            if (senhaCorreta)
            {
                InserirHora(id);
                MessageBox.Show("Ponto registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Senha Incorreta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ValidarSenhaAdmin(string id, string senha)
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT * FROM FUNCIONARIO WHERE ID = {id}", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "FUNCIONARIO");
            con.Close();

            return GerenciadorDeSenha.VerificarSenha(senha, dataset.Tables["FUNCIONARIO"].Rows[0]["SENHA"].ToString());
        }

        public int InserirSenhaGerada(string id, string senha)
        {
            ArquivoConfig();
            // Faz o hash da senha antes de armazenar
            string senhaHashed = GerenciadorDeSenha.SenhaHash(senha);

            comando = new FbCommand($"UPDATE FUNCIONARIO SET SENHA = '{senhaHashed}' WHERE ID = {id}", con);
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public void SalvarCadastro(string nome, string senha, string email)
        {
            ArquivoConfig();
            // Faz o hash da senha antes de armazenar
            string senhaHashed = GerenciadorDeSenha.SenhaHash(senha);

            comando = new FbCommand($"INSERT INTO FUNCIONARIO (NOME, SENHA, EMAIL) VALUES ('{nome}', '{senhaHashed}', '{email}')", con);
            con.Open();

            if (comando.ExecuteNonQuery() == 1)
            {
                comando = new FbCommand("SELECT FIRST 1 * FROM funcionario ORDER BY id DESC;", con);
                FbDataAdapter data = new FbDataAdapter(comando);
                DataSet dataset = new DataSet();
                data.Fill(dataset, "FUNCIONARIO");

                MessageBox.Show("Funcionário Cadastrado - ID: " + dataset.Tables["FUNCIONARIO"].Rows[0]["ID"].ToString(), "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar Funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();

        }

        public void SalvarNome(string id, string nome)
        {
            ArquivoConfig();
            comando = new FbCommand($"UPDATE FUNCIONARIO SET NOME = '{nome}' WHERE ID = {id}", con);
            con.Open();

            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Nome do Funcionário alterado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao alterar nome do Funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public void SalvarEmail(string id, string email)
        {
            ArquivoConfig();
            comando = new FbCommand($"UPDATE FUNCIONARIO SET EMAIL = '{email}' WHERE ID = {id}", con);
            con.Open();

            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("E-mail do Funcionário alterado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao alterar o e-mail do Funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public void SalvarNomeEmpresa(string nome)
        {
            ArquivoConfig();
            comando = new FbCommand("SELECT * FROM CONFIG", con);
            con.Open();
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            data.Fill(dataset, "CONFIG");
            con.Close();

            if (dataset.Tables["CONFIG"].Rows.Count > 0)
            {
                comando = new FbCommand($"UPDATE CONFIG SET NOMEEMPRESA = '{nome}'", con);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                comando = new FbCommand($"INSERT INTO CONFIG (NOMEEMPRESA) VALUES ('{nome}')", con);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }

        }

        public string CarregarNomeEmpresa()
        {
            ArquivoConfig();
            comando = new FbCommand("SELECT NOMEEMPRESA FROM CONFIG", con);
            con.Open();
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            data.Fill(dataset, "CONFIG");
            con.Close();
            return dataset.Tables["CONFIG"].Rows[0]["NOMEEMPRESA"].ToString();            
        }

        public void SalvarConfiguracoesEmail(string emailPonte, string senha, string smtp, string porta, int ssl, string emailContabi)
        {
            ArquivoConfig();
            comando = new FbCommand("SELECT * FROM CONFIG", con);
            con.Open();
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            data.Fill(dataset, "CONFIG");
            con.Close();
            if (dataset.Tables["CONFIG"].Rows.Count > 0)
            {
                comando = new FbCommand($"UPDATE CONFIG SET EMAILPONTE = '{emailPonte}', SENHA = '{senha}', SMTP = '{smtp}', PORTA = '{porta}', SSL = {ssl}, EMAILCONTABI = '{emailContabi}'", con);
                con.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Configuracões de E-mail alteradas", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar as configuracões", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                comando = new FbCommand($"INSERT INTO CONFIG (EMAILPONTE, SENHA, SMTP, PORTA, SSL, EMAILCONTABI) VALUES ('{emailPonte}', '{senha}', '{smtp}', '{porta}', {ssl}, '{emailContabi}')", con);
                con.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Configuracões de E-mail salvas", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Erro ao salvar as configuracões", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        public List<string> CarregarConfiguracoesEmail()
        {
            ArquivoConfig();
            comando = new FbCommand($"SELECT * FROM CONFIG", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "CONFIG");
            con.Close();

            if (dataset.Tables["CONFIG"].Rows.Count == 0)
            {
                return null;
            }
            {
                List<string> config = new List<string>();
                config.Add(dataset.Tables["CONFIG"].Rows[0]["EMAILPONTE"].ToString());
                config.Add(dataset.Tables["CONFIG"].Rows[0]["SENHA"].ToString());
                config.Add(dataset.Tables["CONFIG"].Rows[0]["SMTP"].ToString());
                config.Add(dataset.Tables["CONFIG"].Rows[0]["PORTA"].ToString());
                config.Add(dataset.Tables["CONFIG"].Rows[0]["SSL"].ToString());
                config.Add(dataset.Tables["CONFIG"].Rows[0]["EMAILCONTABI"].ToString());

                return config;
            }

        }

        public int DesativarCadastro(string id, int ativo)
        {
            ArquivoConfig();
            comando = new FbCommand($"UPDATE FUNCIONARIO SET ATIVO = {ativo} WHERE ID = {id}", con);
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public void InserirHora(string id)
        {
            ArquivoConfig();
            var dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
            var data = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            var horaAtual = DateTime.Now.ToString("HH:mm:ss");
            var dataHoraAtual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            con.Open();
            FbCommand comando2 = new FbCommand($"SELECT * FROM HORAS WHERE ID_FUNCIONARIO = {id} AND DATA = '{data}' AND HORA2 IS NULL", con);
            FbDataAdapter data2 = new FbDataAdapter(comando2);
            DataSet hora2 = new DataSet();
            data2.Fill(hora2, "HORAS");
            if (hora2.Tables["HORAS"].Rows.Count == 0)
            {
                data = dataAtual;
                comando2 = new FbCommand($"SELECT * FROM HORAS WHERE ID_FUNCIONARIO = {id} AND DATA = '{data}' AND HORA2 IS NULL", con);
                data2 = new FbDataAdapter(comando2);
                hora2 = new DataSet();
                data2.Fill(hora2, "HORAS");
            }

            FbCommand comando3 = new FbCommand($"SELECT * FROM HORAS WHERE ID_FUNCIONARIO = {id} AND DATA = '{dataAtual}' AND HORA3 IS NULL", con);
            FbDataAdapter data3 = new FbDataAdapter(comando3);
            DataSet hora3 = new DataSet();
            data3.Fill(hora3, "HORAS");

            FbCommand comando4 = new FbCommand($"SELECT * FROM HORAS WHERE ID_FUNCIONARIO = {id} AND DATA = '{dataAtual}' AND HORA4 IS NULL", con);
            FbDataAdapter data4 = new FbDataAdapter(comando4);
            DataSet hora4 = new DataSet();
            data4.Fill(hora4, "HORAS");
            con.Close();


            if (hora2.Tables["HORAS"].Rows.Count > 0)
            {
                comando = new FbCommand($"UPDATE HORAS SET HORA2 = '{dataHoraAtual}' WHERE ID_FUNCIONARIO = {id} AND DATA = '{data}'", con);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
            else if (hora3.Tables["HORAS"].Rows.Count > 0)
            {
                comando = new FbCommand($"UPDATE HORAS SET HORA3 = '{dataHoraAtual}' WHERE ID_FUNCIONARIO = {id} AND DATA = '{dataAtual}'", con);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
            else if (hora4.Tables["HORAS"].Rows.Count > 0)
            {
                comando = new FbCommand($"UPDATE HORAS SET HORA4 = '{dataHoraAtual}' WHERE ID_FUNCIONARIO = {id} AND DATA = '{dataAtual}'", con);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                comando = new FbCommand($"INSERT INTO horas (id_funcionario, data, hora1) VALUES ({id}, '{dataAtual}', '{dataHoraAtual}')", con);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }


    }
}
