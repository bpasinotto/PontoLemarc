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
    public partial class frmSenhaDoAdmin : Form
    {
        ConexaoBanco conexaoBanco = new ConexaoBanco();

        public frmSenhaDoAdmin()
        {
            InitializeComponent();            
        }

        private void frmSenhaDoAdmin_Load(object sender, EventArgs e)
        {
            txtSenha.Focus();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        public void Validar()
        {
            if (conexaoBanco.ValidarSenhaAdmin("1", txtSenha.Text))
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Validar();
            }
        }
    }
}
