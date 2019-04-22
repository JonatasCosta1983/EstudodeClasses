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
    public partial class frmSplash3 : Form
    {
        public frmSplash3()
        {
            InitializeComponent();
        }

        private void FrmSplash3_Load(object sender, EventArgs e)
        {
            trmSplash3.Enabled = true;
        }

        private void TrmSplash3_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
