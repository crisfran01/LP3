﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychology
{
    public partial class frmConFun : Form
    {
        public frmConFun()
        {
            InitializeComponent();
        }

        private void frmConFun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.psiEasy.funcionarios);

        }
    }
}
