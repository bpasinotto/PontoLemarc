﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ponto
{
    public partial class frmRelatorioPonto : Form
    {
        ConexaoBanco conexaoBanco = new ConexaoBanco();        
        
        public frmRelatorioPonto()
        {
            InitializeComponent();

            ConexaoBanco conexaoBanco = new ConexaoBanco();
            //cbFuncionario.DataSource = conexaoBanco.Mostrar().Tables["FUNCIONARIO"].AsEnumerable().Select(row => row["NOME"]).ToList();
            cbFuncionario.Items.Add("Todos");
            cbFuncionario.Items.AddRange(conexaoBanco.IdEnome().Tables["FUNCIONARIO"].AsEnumerable().Select(row => row["NOME"]).ToArray());
            

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
            // Obtenha os dados do DataGridView
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dgvConsultaPonto.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dgvConsultaPonto.Rows)
            {
                DataRow dataRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dataRow);
            }

            ds.Tables.Add(dt);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Faça uma Consulta primeiro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ds.WriteXmlSchema("applicant.xml");
                frmRelPonto fm = new frmRelPonto();
                CrystalReport1 cr = new CrystalReport1();
                cr.SetDataSource(ds);
                fm.crystalReportViewer1.ReportSource = cr;
                fm.crystalReportViewer1.Refresh();
                fm.Show();
            }
                        
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {  
            string dataInicial = dtDataInicial.Value.ToString("yyyy-MM-dd");
            string dataFinal = dtDataFinal.Value.ToString("yyyy-MM-dd");

            if(dgvConsultaPonto.DataSource != null)
            {
                frmGrafico fm = new frmGrafico(cbFuncionario.Text, dataInicial, dataFinal);
                fm.Show();
            }
            else
            {
                MessageBox.Show("Faça uma Consulta primeiro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

       
    }
}
