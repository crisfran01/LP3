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
    public partial class frmVendaDetalhes : Form
    {
        int codV;
        public frmVendaDetalhes(int cod)
        {
            InitializeComponent();
            codV = cod;
        }
        private void vendasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmVendaDetalhes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.venda_cliente' table. You can move, or remove it, as needed.
            this.venda_clienteTableAdapter.FillByCodVenda(this.dataSet1.venda_cliente, codV);
            // TODO: This line of code loads data into the 'dataSet1.vendas' table. You can move, or remove it, as needed.

            this.vendasTableAdapter.FillByCod(this.dataSet1.vendas, codV);
            this.item_produtoTableAdapter.FillbyCod(this.dataSet1.item_produto, codV);

        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
