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
    public partial class frmSplash2 : Form
    {
        public frmSplash2()
        {
            InitializeComponent();
        }

        private void FrmSplash2_Load(object sender, EventArgs e)
        {
            trmSplash2.Enabled = true;
        }

        private void TrmSplash2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
