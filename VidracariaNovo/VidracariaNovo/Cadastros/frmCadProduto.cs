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
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void enableText(Boolean enable, Boolean enablec)
        {
            txtNome.ReadOnly = enable;
            txtUnidadeDeMedida.ReadOnly = enable;
            txtDescricao.ReadOnly = enable;
            txtPrCompra.ReadOnly = enable;
            txtPrVenda.ReadOnly = enable;
            txtQtde.ReadOnly = enable;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            produtosBindingSource.CancelEdit();
            produtosBindingSource.AddNew();
            enableText(false, true);
            txtNome.Focus();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            produtosBindingSource.CancelEdit();
            produtosBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            produtosBindingSource.CancelEdit();
            produtosBindingSource.MoveNext();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            enableText(false, true);
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            this.produtosTableAdapter.Fill(this.dataSet1.produtos);
            panelEdit.SendToBack();
            enableText(true, false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            panelEdit.SendToBack();
            enableText(true, false);
            this.produtosBindingSource.CancelEdit();
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.dataSet1.produtos);

        }
    }
}
