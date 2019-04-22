using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigofonteEstudodeClasses.inicio
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            trmSplash.Enabled = true;
        }

        private void TrmSplash_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
