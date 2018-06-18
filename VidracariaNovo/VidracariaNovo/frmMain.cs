using System;
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

     

        private void consultaStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            frmVendas vendas = new frmVendas();
            showForm(vendas);
        }

        private void tlCadProd_Click(object sender, EventArgs e)
        {
            frmCadProduto CadProd = new frmCadProduto();
            showForm(CadProd);
        }

        private void tlBuscaCli_Click(object sender, EventArgs e)
        {
            frmBuscaCli obj = new frmBuscaCli();
            showForm(obj);
        }


    }
}
