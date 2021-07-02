using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaApresentacao;

namespace SysEstoque
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FrmLogin log = new FrmLogin();
            if( log.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmPrincipal());
            }
        }
    }
}
