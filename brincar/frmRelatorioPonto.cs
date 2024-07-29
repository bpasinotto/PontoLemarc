using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using OfficeOpenXml;
using static System.Net.Mime.MediaTypeNames;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Ponto
{
    public partial class frmRelatorioPonto : Form
    {
        ConexaoBanco conexaoBanco = new ConexaoBanco();

        public frmRelatorioPonto()
        {
            InitializeComponent();
        }

        private void frmRelatorioPonto_Load(object sender, EventArgs e)
        {
            cbFuncionario.Items.Add("Todos");
            cbFuncionario.Items.AddRange(conexaoBanco.IdEnome(1).Tables["FUNCIONARIO"].AsEnumerable().Select(row => row["NOME"]).ToArray());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //DataSet dataset = conexaoBanco.ConsultaPorNome(cbFuncionario.Text);

            if (cbFuncionario.Text == "Todos")
            {
                string dataInicial = dtDataInicial.Value.ToString("yyyy-MM-dd");
                string dataFinal = dtDataFinal.Value.ToString("yyyy-MM-dd");

                dgvConsultaPonto.DataSource = conexaoBanco.ConsultaPontosTodos(dataInicial, dataFinal);
                dgvConsultaPonto.DataMember = "CONSULTA_PONTOS";
                dgvConsultaPonto.AutoGenerateColumns = true;
                dgvConsultaPonto.Sort(dgvConsultaPonto.Columns[0], ListSortDirection.Ascending);
                dgvConsultaPonto.Font = new Font("Montserrat SemiBold", 10, FontStyle.Bold);
                dgvConsultaPonto.Refresh();
            }
            else
            {
                //int id = (int)dataset.Tables["FUNCIONARIO"].Rows[0]["ID"];

                string dataInicial = dtDataInicial.Value.ToString("yyyy-MM-dd");
                string dataFinal = dtDataFinal.Value.ToString("yyyy-MM-dd");

                dgvConsultaPonto.DataSource = conexaoBanco.PontosPorData(cbFuncionario.Text, dataInicial, dataFinal);
                dgvConsultaPonto.DataMember = "CONSULTA_PONTOS";
                dgvConsultaPonto.AutoGenerateColumns = true;
                dgvConsultaPonto.Sort(dgvConsultaPonto.Columns[0], ListSortDirection.Ascending);
                dgvConsultaPonto.Refresh();
            }



        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvConsultaPonto.Rows.Count == 0)
            {
                MessageBox.Show("Faça uma Consulta primeiro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Obtenha os dados do DataGridView
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                DataRow dataRow;

                foreach (DataGridViewColumn column in dgvConsultaPonto.Columns)
                {
                    dt.Columns.Add(column.HeaderText);
                }

                dt.Columns.Add("Empresa");

                foreach (DataGridViewRow row in dgvConsultaPonto.Rows)
                {
                    dataRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value;
                    }
                    dataRow["Empresa"] = VariaveisGlobais.NomeEmpresa;
                    dt.Rows.Add(dataRow);
                }

                ds.Tables.Add(dt);

                ds.WriteXmlSchema("applicant.xml");
                frmRelPonto fm = new frmRelPonto();
                CrystalReport1 cr = new CrystalReport1();
                cr.SetDataSource(ds);
                fm.crystalReportViewer1.ReportSource = cr;
                fm.crystalReportViewer1.Refresh();
                fm.ShowDialog();
            }

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            if (dgvConsultaPonto.Rows.Count > 0)
            {
                string dataInicial = dtDataInicial.Value.ToString("yyyy-MM-dd");
                string dataFinal = dtDataFinal.Value.ToString("yyyy-MM-dd");

                if (dgvConsultaPonto.DataSource != null)
                {
                    frmGrafico fm = new frmGrafico(cbFuncionario.Text, dataInicial, dataFinal);
                    fm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Faça uma Consulta primeiro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Faça uma Consulta primeiro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            int ativo = 0;
            if (cbAtivo.Checked == true)
            {
                ativo = 1;
            }
            cbFuncionario.Items.Clear();
            cbFuncionario.Items.Add("Todos");
            cbFuncionario.Items.AddRange(conexaoBanco.IdEnome(ativo).Tables["FUNCIONARIO"].AsEnumerable().Select(row => row["NOME"]).ToArray());
            cbFuncionario.Text = "Todos";
            dgvConsultaPonto.DataSource = null;
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            frmConfiguracoes frmConfiguracoes = new frmConfiguracoes();
            frmConfiguracoes.ShowDialog();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if (dgvConsultaPonto.Rows.Count > 0)
            {
                try
                {
                    // Definir o contexto da licença para EPPlus
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    // Gerar planilha Excel a partir do DataGridView
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Dados");

                        // Cabeçalho
                        for (int i = 0; i < dgvConsultaPonto.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dgvConsultaPonto.Columns[i].HeaderText;
                        }

                        // Linhas
                        for (int i = 0; i < dgvConsultaPonto.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvConsultaPonto.Columns.Count; j++)
                            {
                                var cellValue = dgvConsultaPonto.Rows[i].Cells[j].Value;

                                // Verificar se o valor da célula é uma data ou hora e formatar adequadamente
                                if (j == 0 && DateTime.TryParse(cellValue?.ToString(), out DateTime dateValue))
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = dateValue;
                                    worksheet.Cells[i + 2, j + 1].Style.Numberformat.Format = "dd/MM/yyyy"; // Formato de data
                                }
                                else if (j >= 2 && j <= 5 && DateTime.TryParse(cellValue?.ToString(), out DateTime timeValue))
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = timeValue;
                                    worksheet.Cells[i + 2, j + 1].Style.Numberformat.Format = "HH:mm:ss"; // Formato de hora
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = cellValue;
                                }
                            }
                        }

                        // Ajustar a largura das colunas para caber o conteúdo
                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        // Salvar planilha em um MemoryStream
                        var stream = new MemoryStream();
                        package.SaveAs(stream);
                        stream.Position = 0;

                        // Enviar email com anexo
                        SendEmail(stream);
                    }

                    MessageBox.Show("Email enviado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Faça uma Consulta primeiro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        static void SendEmail(MemoryStream stream)
        {
            ConexaoBanco conexaoBanco = new ConexaoBanco();
            if (conexaoBanco.CarregarConfiguracoesEmail() != null)
            {
                List<string> config = conexaoBanco.CarregarConfiguracoesEmail();
                //txtEmailPonte.Text = config[0];
                //txtSenha.Text = config[1];
                //txtSmtp.Text = config[2];
                //txtPorta.Text = config[3];
                //if (config[4] == "1") { smtp.EnableSsl = true; }
                //txtEmailContabi.Text = config[5];


                string emailPonte = config[0];
                string emailContabi = config[5];
                string assunto = "Relatório de Ponto " + VariaveisGlobais.NomeEmpresa;
                string corpo = "Por favor, veja a planilha em anexo.";
                string smtpServer = config[2];
                int porta = int.Parse(config[3]);
                string smtpEmail = config[0];
                string senha = config[1];

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailPonte);
                    mail.To.Add(emailContabi);
                    mail.Subject = assunto;
                    mail.Body = corpo;
                    mail.IsBodyHtml = false;

                    stream.Seek(0, SeekOrigin.Begin);
                    Attachment attachment = new Attachment(stream, "Relatório de Ponto " + VariaveisGlobais.NomeEmpresa +".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                    mail.Attachments.Add(attachment);

                    using (SmtpClient smtp = new SmtpClient(smtpServer, porta))
                    {
                        smtp.Credentials = new NetworkCredential(smtpEmail, senha);
                        if (config[4] == "1") { smtp.EnableSsl = true; }
                        smtp.Send(mail);
                    }
                }

            }
            else
            {
                MessageBox.Show("Preencha as configurações de e-mail", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
