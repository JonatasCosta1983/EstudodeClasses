using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testeestudodeclasses2.inicio

{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo .
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //chamando o splash 
            frmSplash splash = new frmSplash();
            splash.ShowDialog();

            //chmando o splash1
            frmSplash1 splash1 = new frmSplash1();
            splash1.ShowDialog();

            //chamando o splash2
            frmSplash2 splash2 = new frmSplash2();
            splash2.ShowDialog();

            //chamndo o splash3
            frmSplash3 splash3 = new frmSplash3();
            splash3.ShowDialog();

            // chamdando o splash4
            frmSplash4 splash4 = new frmSplash4();
            splash4.ShowDialog();

            //chamando o splash5
            frmSplash5 splash5 = new frmSplash5();
            splash5.ShowDialog();

            //chamando o splash6 
            frmSplash6 splash6 = new frmSplash6();
            splash6.ShowDialog();

            //chamando o splash7
            frmSplash7 splash7 = new frmSplash7();
            splash7.ShowDialog();

            //chamando o splash8
            frmSplash8 splash8 = new frmSplash8();
            splash8.ShowDialog();




            Application.Run(new Form1());// esse chama o arquivo principal
        }
    }
}
