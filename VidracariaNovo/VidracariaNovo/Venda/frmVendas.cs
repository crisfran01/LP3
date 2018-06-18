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
            // TODO: This line of code loads data into the 'vidracariaDataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.vidracariaDataSet.usuarios);
            // TODO: This line of code loads data into the 'dataSet1.condpg' table. You can move, or remove it, as needed.
            this.condpgTableAdapter.Fill(this.dataSet1.condpg);
            // TODO: This line of code loads data into the 'dataSet1.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.dataSet1.vendas);
            vendasBindingSource.AddNew();
            descricaoComboBox.SelectedIndex = 0;

        }
        decimal totalBanco;
        int codV;
        private void atualizaTotal()
        {
            DataRow rowVenda = ((DataRowView)vendasBindingSource.Current).Row;
            int cod_vend = (int)rowVenda["cod"];
            totalBanco = Convert.ToDecimal( itensTableAdapter.TotalVend(cod_vend));
            lblTotal.Text = Convert.ToString(totalBanco - Convert.ToDecimal(txtDesc.Text));
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
            this.Validate();
            DataRow rowVend = ((DataRowView)vendasBindingSource.Current).Row;
            rowVend["data"] = dt_date.Value;
            rowVend["status"] = "Pendente";
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
            txtPreU.Text = Convert.ToString(dataSet1.produtos[produtosBindingSource.Position].pr_venda);
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
            rowIteVend["Preco"] = sub;

            codV = Convert.ToInt32(rowIteVend["codVend"]);
            this.itensBindingSource.EndEdit();
            this.itensTableAdapter.Update(this.dataSet1);

            this.item_produtoTableAdapter.FillbyCod(this.dataSet1.item_produto, codV);
            item_produtoBindingSource.MoveLast();

            limp();
            atualizaTotal();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (item_produtoTableAdapter.HaveItem(codV) > 0)
            {
                salvaVend();           
                this.Dispose();
            }else
            {
                MessageBox.Show("Não há itens na venda");
            }
        }

        private void txtQtde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    gravarItem(Convert.ToInt32(txtCodP.Text), Convert.ToDouble(txtAl.Text.Replace('.', ',')),
                    Convert.ToDouble(txtLa.Text.Replace('.', ',')), Convert.ToDouble(txtQtde.Text.Replace('.', ',')),
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
                itensTableAdapter.DeleteAll(codV);
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
                cbFun.Select();
            }
        }
     
        private void itens_subtDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow rowIS = ((DataRowView)item_produtoBindingSource.Current).Row;

            int seq = Convert.ToInt32(itens_subtDataGridView.CurrentRow.Cells[8].Value.ToString());

            decimal qtde = Convert.ToDecimal(itens_subtDataGridView.CurrentRow.Cells[6].Value.ToString().Replace('.',','));

            decimal a = Convert.ToDecimal(itens_subtDataGridView.CurrentRow.Cells[4].Value.ToString().Replace('.', ','));

            decimal l = Convert.ToDecimal(itens_subtDataGridView.CurrentRow.Cells[5].Value.ToString().Replace('.', ','));

            decimal met = a * l * qtde;

            decimal precoUnitario = Convert.ToDecimal(itens_subtDataGridView.CurrentRow.Cells[9].Value.ToString());

            decimal precoFinal = a * l * qtde * precoUnitario;

            itensTableAdapter.UpdateItem(a, l, qtde, met, precoFinal, seq);

            this.item_produtoTableAdapter.FillbyCod(this.dataSet1.item_produto, Convert.ToInt32(rowIS["CodVend"]));
            item_produtoBindingSource.MoveLast();

            atualizaTotal();
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            decimal desc = Convert.ToDecimal(txtDesc.Text);
            lblTotal.Text = Convert.ToString(totalBanco - desc);
        }

        private void itens_subtDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                int seq = Convert.ToInt32(itens_subtDataGridView.CurrentRow.Cells[8].Value.ToString());
                itensTableAdapter.DeleteItem(seq);
            }
        }
        private void txtAl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == ',' || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void btnImp_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabCImpre.Visible)
                {
                    tabCImpre.Visible = false;
                }
                else
                {
                    tabCImpre.Visible = true;
                }
            }
            catch
            {
                return;
            }
        }
    }
}
