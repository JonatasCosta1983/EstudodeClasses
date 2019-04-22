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
    public partial class frmSplash7 : Form
    {
        public frmSplash7()
        {
            InitializeComponent();
        }

        private void FrmSplash7_Load(object sender, EventArgs e)
        {
            trmSplash7.Enabled = true;
        }

        private void TrmSplash7_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
