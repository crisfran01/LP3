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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.condpg' table. You can move, or remove it, as needed.
            this.condpgTableAdapter.Fill(this.dataSet1.condpg);
            // TODO: This line of code loads data into the 'dataSet1.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.dataSet1.vendas);
            vendasBindingSource.AddNew();
        }

        int codV;
        private void atualizaTotal()
        {
            DataRow rowVenda = ((DataRowView)vendasBindingSource.Current).Row;
            int cod_vend = (int)rowVenda["cod"];
            lblTotal.Text = Convert.ToString( itensTableAdapter.TotalVend(cod_vend) - Convert.ToDecimal(txtDesc));
        }

        private void limp()
        {
            txtAl.Clear();
            txtLa.Clear();
            txtCodP.Clear();
            txtDProd.Clear();
            txtPreU.Clear();
            txtQtde.Clear();
        }

        public void habProd(bool hab)
        {
            txtCodP.Enabled = hab;
            txtDProd.Enabled = hab;
            txtAl.Enabled = hab;
            txtLa.Enabled = hab;
            txtQtde.Enabled = hab;
            txtNomeC.Enabled = hab;
            txtCodCli.Enabled = hab;
            itens_subtDataGridView.Enabled = hab;
        }

       

        private void salvaVend()
        {

            DataRow rowVend = ((DataRowView)vendasBindingSource.Current).Row;
            rowVend["data"] = dt_date.Value;
            this.Validate();
            this.vendasBindingSource.EndEdit();
            this.vendasTableAdapter.Update(this.dataSet1);
        }

        public void insereCliVend(String codigo, String name)
        {     
            DataRow rowVen = ((DataRowView)vendasBindingSource.Current).Row;
            rowVen["codCli"] = Convert.ToInt32(codigo);
            txtCodCli.Text = codigo;
            txtNomeC.Text = name;
            habProd(true);
            txtCodP.Select();

        }

        public void fillProductInfo()
        {
            produtosTableAdapter.FillByCod(this.dataSet1.produtos, Convert.ToInt32(txtCodP.Text));
            txtDProd.Text = dataSet1.produtos[produtosBindingSource.Position].nome;
            txtPreU.Text = Convert.ToString(dataSet1.produtos[produtosBindingSource.Position].pr_custo);
            txtAl.Select();
        }

       

        private void gravarItem(int codP, double al, double la, double qtde, double pr)
        {
            double met = al * la * qtde;
            double sub = met * pr;

            itensBindingSource.AddNew();

            DataRow rowVenda = ((DataRowView)vendasBindingSource.Current).Row;
            DataRow rowIteVend = ((DataRowView)itensBindingSource.Current).Row;

            rowIteVend["codVend"] = rowVenda["cod"];
            rowIteVend["codProd"] = codP;
            rowIteVend["altura"] = al;
            rowIteVend["largura"] = la;
            rowIteVend["qtde"] = qtde;
            rowIteVend["metragem"] = met;
            rowIteVend["preco"] = sub;

            codV = Convert.ToInt32(rowIteVend["codVend"]);
            this.itensBindingSource.EndEdit();
            this.itensTableAdapter.Update(this.dataSet1);

            this.item_produtoTableAdapter.FillByCod(this.dataSet1.item_produto, codV);
            item_produtoBindingSource.MoveLast();

            limp();
            atualizaTotal();

        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            salvaVend();           
            this.Dispose();
        }

        private void txtQtde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    gravarItem(Convert.ToInt32(txtCodP.Text), Convert.ToDouble(txtAl.Text),
                    Convert.ToDouble(txtLa.Text), Convert.ToDouble(txtQtde.Text),
                    Convert.ToDouble(txtPreU.Text));
                    txtCodP.Select();

                }
                catch
                {
                    return;
                }

            }
        }
       

        private void txtCodP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    fillProductInfo();
                }


            }
            catch
            {
                MessageBox.Show("Codigo invalido");
                return;
            }
        }

        private void txtCodCli_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int i = clientesTableAdapter.FillByCod(this.dataSet1.clientes, Convert.ToInt32(txtCodCli.Text));
                    if (i == 1)
                    {
                        
                        insereCliVend(txtCodCli.Text, Convert.ToString(dataSet1.clientes[clientesBindingSource.Position].nome));

                    }
                    else
                    {
                        MessageBox.Show("Código não encontrado");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Código não encontrado");
                return;
            }
        }

        private void txtNomeC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    frmBuscaCli buscaCli = new frmBuscaCli(txtNomeC.Text);
                    buscaCli.ShowDialog();
                    insereCliVend(buscaCli.clienteInfos["cod"], buscaCli.clienteInfos["name"]);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar");
                return;
            }
        }

        private void txtDProd_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    frmBuscaProdutos buscaProd = new frmBuscaProdutos();
                    buscaProd.ShowDialog();
                    txtCodP.Text = buscaProd.productInfos["cod"];
                    fillProductInfo();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Os dados da venda serão perdidos. Deseja mesmo sair? ", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void txtAl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLa.Select();
            }
        }

        private void txtLa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 txtQtde.Select();
            }
        }

        private void txtDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFun.Select();
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            double desc = Convert.ToDouble(lblTotal.Text);
            double valor = Convert.ToDouble(txtDesc.Text);

            lblTotal.Text = Convert.ToString(valor - desc);
        }
    }
}
