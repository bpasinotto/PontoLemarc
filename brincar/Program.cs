using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            ConexaoBanco conexaoBanco = new ConexaoBanco();
            if (conexaoBanco.ArquivoConfig() == false)
            {
                Application.Exit();
            }
            else
            {
                Application.Run(new Form1());
            }
        }

        
    }
}
