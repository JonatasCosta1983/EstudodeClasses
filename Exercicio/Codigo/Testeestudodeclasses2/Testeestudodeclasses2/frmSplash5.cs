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
    public partial class frmSplash5 : Form
    {
        public frmSplash5()
        {
            InitializeComponent();
        }

        private void FrmSplash5_Load(object sender, EventArgs e)
        {
            trmSplash5.Enabled = true;
        }

        private void TrmSplash5_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
