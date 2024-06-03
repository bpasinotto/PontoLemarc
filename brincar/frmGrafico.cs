using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ponto
{
    public partial class frmGrafico : Form
    {
        ConexaoBanco conexaoBanco = new ConexaoBanco();

        string Funcionario;
        string DataInicio;
        string DataFim;
        
        public frmGrafico()
        {
            InitializeComponent();
        }

        public frmGrafico(string funcionario, string dataInicio, string dataFim)
        {
            Funcionario = funcionario;
            DataInicio = dataInicio;
            DataFim = dataFim;
            InitializeComponent();
        }

        private void frmGrafico_Load(object sender, EventArgs e)
        {
            if (Funcionario == "Todos")
            {
                chartGrafico.Series["Horas"].XValueMember = "Data";
                chartGrafico.Series["Horas"].YValueMembers = "Total/Dia";
                chartGrafico.DataSource = conexaoBanco.ConsultaGraficoTodos(DataInicio, DataFim);
                chartGrafico.DataBind();
            }
            else
            {
                chartGrafico.Series["Horas"].XValueMember = "Data";
                chartGrafico.Series["Horas"].YValueMembers = "Total/Dia";
                chartGrafico.DataSource = conexaoBanco.ConsultaGraficoFuncionario(Funcionario, DataInicio, DataFim);
                chartGrafico.DataBind();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
