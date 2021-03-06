﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidracariaNovo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void showForm(Form obj)
        {
            obj.MdiParent = this;
            obj.ControlBox = false;
            obj.MaximizeBox = false;
            obj.ShowIcon = false;
            obj.Text = "";
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void psicologosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void triagemToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void artigoToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void caixaStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void reciboToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadCliente cadCli = new frmCadCliente();
            showForm(cadCli);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void funcionariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadFuncionario CadFun = new frmCadFuncionario();
            showForm(CadFun);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFornecedor CadFornecedor = new frmCadFornecedor();
            showForm(CadFornecedor);
        }

        private void psicologosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadProduto CadProd = new frmCadProduto();
            showForm(CadProd);
        }

        private void consultaStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            frmVendas vendas = new frmVendas();
            showForm(vendas);
        }
    }
}
