﻿using System;
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
    public partial class frmSplash1 : Form
    {
        public frmSplash1()
        {
            InitializeComponent();
        }

        private void FrmSplash1_Load(object sender, EventArgs e)
        {
            trmSplash1.Enabled = true;
        }

        private void TrmSplash1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
