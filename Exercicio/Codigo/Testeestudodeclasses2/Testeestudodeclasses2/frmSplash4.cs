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
    public partial class frmSplash4 : Form
    {
        public frmSplash4()
        {
            InitializeComponent();
        }

        private void FrmSplash4_Load(object sender, EventArgs e)
        {
            trmSplash4.Enabled = true;
        }

        private void TrmSplash4_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
