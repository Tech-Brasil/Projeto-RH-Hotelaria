using Projeto_RH_HOTELARIA.Forms;
using System;
using System.Windows.Forms;

namespace Projeto_RH_HOTELARIA
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
            Application.Run(new frmCarregamento());
        }
    }
}
