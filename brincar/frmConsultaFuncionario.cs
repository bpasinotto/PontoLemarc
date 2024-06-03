using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto
{
    public partial class frmConsultaFuncionario : Form
    {
        string Id, Nome;
        ConexaoBanco conexaoBanco = new ConexaoBanco();

        public frmConsultaFuncionario()
        {
            InitializeComponent();
        }


        private void ConsultaFuncionario_Load(object sender, EventArgs e)
        {
            txtBarraDeBusca.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void funcionarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariaveisGlobais.CodigoTroca = int.Parse(funcionarioDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            this.Dispose();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadFuncionario cadFuncionario = new frmCadFuncionario();
            cadFuncionario.ShowDialog();
            txtBarraDeBusca.Text = "";
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void txtBarraDeBusca_TextChanged(object sender, EventArgs e)
        {
            funcionarioDataGridView.DataSource = null;

            if (txtBarraDeBusca.Text != "")
            {
                funcionarioDataGridView.DataSource = conexaoBanco.ProcurarFuncionarioNome(txtBarraDeBusca.Text);
                funcionarioDataGridView.DataMember = "FUNCIONARIO";
                funcionarioDataGridView.Font = new Font("Montserrat SemiBold", 10, FontStyle.Bold);
                funcionarioDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                funcionarioDataGridView.DataSource = null;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Id != null && Nome != null)
            {                
                frmCadFuncionario cadFuncionario = new frmCadFuncionario(Id, Nome);
                cadFuncionario.ShowDialog();
                txtBarraDeBusca.Text = "";
                Id = null;
            }
            else
            {
                MessageBox.Show("Selecione um nome para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void funcionarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = funcionarioDataGridView.Rows[funcionarioDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            Nome = funcionarioDataGridView.Rows[funcionarioDataGridView.CurrentRow.Index].Cells[1].Value.ToString();
        }
    }
}
