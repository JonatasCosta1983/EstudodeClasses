using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigofonteEstudodeClasses.inicio
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

            //Aqui o sistema está chamando o o splash.
            frmSplash splash = new frmSplash();
            splash.ShowDialog();



            Application.Run(new Form1());// Aqui o sistema da início
        }
    }
}
