using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using FirebirdSql.Data.FirebirdClient;
using System.Threading;
using System.Drawing.Text;
using System.IO;

namespace Ponto
{
    public partial class Form1 : Form
    {
        private MaskedTextBox activeTextBox; // Armazena o campo de texto ativo
        private ConexaoBanco conexaoBanco;
        public Form1()
        {
            InitializeComponent();                        
        }


        private void Form1_Load(object sender, EventArgs e)
        {            
            activeTextBox = txtId;            
            txtId.Focus();
            LimparCampos();
            conexaoBanco = new ConexaoBanco();
            if (conexaoBanco.ArquivoConfig() == false)
            {
                Close();
            }
            if (VariaveisGlobais.NomeEmpresa != "")
            {
                txtNomeEmpresa.Text = VariaveisGlobais.NomeEmpresa;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataAtual.Text = DateTime.Now.ToShortDateString();
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString();
        }



        private void num2_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null && activeTextBox.Text.Length > 0)
            {
                activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (activeTextBox == txtId)
            {
                txtId_KeyDown(sender, new KeyEventArgs(Keys.Enter));                
            }
            else
            {
                txtSenha_KeyDown(sender, new KeyEventArgs(Keys.Enter));
            }

        }

        private void num4_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            if (activeTextBox != null)
            {
                activeTextBox.Text += numButton.Text; // Adiciona o número ao campo ativo
            }
        }

        private void txtId_Click(object sender, EventArgs e)
        {            
            activeTextBox = (MaskedTextBox)sender; // Define o campo de texto como ativo
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            activeTextBox = (MaskedTextBox)sender; // Define o campo de texto como ativo
        }

        private void btnLupa_Click(object sender, EventArgs e)
        {
            LimparCampos();
            frmConsultaFuncionario consultaFuncionario = new frmConsultaFuncionario();
            consultaFuncionario.ShowDialog();
            txtSenha.Enabled = true;
            if (VariaveisGlobais.CodigoTroca.ToString() == "0")
            {
                txtId.Text = "";
            }
            else
            {
                txtId.Text = VariaveisGlobais.CodigoTroca.ToString();
            }

            if (txtId.Text != "")
            {
                txtId_KeyDown(sender, new KeyEventArgs(Keys.Enter));
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadFuncionario cadFuncionario = new frmCadFuncionario();
            cadFuncionario.ShowDialog();
        }


        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {           
            // Opcional: Evita a movimentação do cursor com as teclas de seta
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter && txtId.Text != "")
            {                

                // Chamar o método ConsultarPorId e obter o resultado da consulta
                conexaoBanco = new ConexaoBanco();
                DataSet dataset = conexaoBanco.ConsultarPorId(txtId.Text);
                               
                // Acessar o valor da coluna "NOME" e exibi-lo no rótulo

                if (dataset.Tables["FUNCIONARIO"].Rows.Count > 0)
                {
                    pnHoras.Visible = true;

                    string nome = dataset.Tables["FUNCIONARIO"].Rows[0]["NOME"].ToString();
                    lblNomeFuncionario.Text = nome;

                    dataset = conexaoBanco.PontosBatidos(txtId.Text);

                    if (dataset.Tables["HORAS"].Rows.Count > 0)
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (dataset.Tables["HORAS"].Rows[0][$"HORA{i}"].ToString() != "")
                            {
                                if (i == 1)
                                {                                    
                                    lblHora1.Text = DateTime.Parse(dataset.Tables["HORAS"].Rows[0][$"HORA{i}"].ToString()).ToString("HH:mm:ss");
                                }
                                else if (i == 2)
                                {
                                    lblHora2.Text = DateTime.Parse(dataset.Tables["HORAS"].Rows[0][$"HORA{i}"].ToString()).ToString("HH:mm:ss");
                                }
                                else if (i == 3)
                                {
                                    lblHora3.Text = DateTime.Parse(dataset.Tables["HORAS"].Rows[0][$"HORA{i}"].ToString()).ToString("HH:mm:ss");
                                }
                                else
                                {
                                    lblHora4.Text = DateTime.Parse(dataset.Tables["HORAS"].Rows[0][$"HORA{i}"].ToString()).ToString("HH:mm:ss");
                                }

                            }

                        }
                    }
                                      

                    if (lblHora4.Text == "Vazio")
                    {
                        txtSenha.Focus();
                        activeTextBox = txtSenha;
                    }
                    else
                    {
                        txtSenha.Enabled = false;
                        txtId.Focus();
                        activeTextBox = txtId;
                    }

                }
                else
                {
                    MessageBox.Show("Funcionário não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {            
            if (txtId.Text == "")
            {
                LimparCampos();
                txtSenha.Enabled = true;
            }

        }


        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Opcional: Evita a movimentação do cursor com as teclas de seta
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter && txtSenha.Text != "" && txtId.Text != "" && lblNomeFuncionario.Text != "")
            {
                conexaoBanco = new ConexaoBanco();
                bool validar = conexaoBanco.ValidarSenha(txtId.Text, txtSenha.Text);
                if (validar)
                {
                    LimparCampos();
                    txtId.Focus();
                    activeTextBox = txtId;
                }

            }
        }

        public void LimparCampos()
        {
            txtId.Text = "";
            txtSenha.Text = "";
            lblNomeFuncionario.Text = "";
            lblHora1.Text = "Vazio";
            lblHora2.Text = "Vazio";
            lblHora3.Text = "Vazio";
            lblHora4.Text = "Vazio";
            pnHoras.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void lblHoraAtual_DoubleClick(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmRelatorioPonto consultaPonto = new frmRelatorioPonto();
            consultaPonto.ShowDialog();
        }
               

        private void txtId_MouseDown(object sender, MouseEventArgs e)
        {
            // Evita a movimentação do cursor ao clicar com o mouse
            txtId.SelectionStart = txtId.Text.Length;            
        }

        private void txtId_MouseMove(object sender, MouseEventArgs e)
        {
            // Evita selecionar o texto com o mouse
            txtId.SelectionLength = 0;
        }

        private void txtSenha_MouseDown(object sender, MouseEventArgs e)
        {
            // Evita a movimentação do cursor ao clicar com o mouse
            txtSenha.SelectionStart = txtSenha.Text.Length;
        }

        private void txtSenha_MouseMove(object sender, MouseEventArgs e)
        {
            // Evita selecionar o texto com o mouse
            txtSenha.SelectionLength = 0;
        }

        private void txtNomeEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtNomeEmpresa.Text == "Nome da Empresa")
            {
                txtNomeEmpresa.Text = "";                
            }
        }

        private void txtNomeEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtNomeEmpresa.Text == "")
            {
                txtNomeEmpresa.Text = "Nome da Empresa";                
            }

            try
            {
                string caminhoConfig = AppDomain.CurrentDomain.BaseDirectory + "config.ini";

                string[] linhas = File.ReadAllLines(caminhoConfig);

                string servidor = linhas[0].Split('=')[1];
                string nomeBancoDados = linhas[1].Split('=')[1];
                string nomeDaEmpresa = linhas[2].Split('=')[1];

                string conteudoArquivo = $"Servidor={servidor}\nBancoDeDados={nomeBancoDados}\nNomeDaEmpresa={txtNomeEmpresa.Text}";
                File.WriteAllText(caminhoConfig, conteudoArquivo);
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao salvar o nome da empresa");
            }

        }
    }
}