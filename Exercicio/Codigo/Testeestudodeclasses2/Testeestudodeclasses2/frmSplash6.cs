using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testeestudodeclasses2.inicio
{
    public partial class frmSplash6 : Form
    {
        public frmSplash6()
        {
            InitializeComponent();
        }

        private void FrmSplash6_Load(object sender, EventArgs e)
        {
            trmSplash6.Enabled = true;
        }

        private void TrmSplash6_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
