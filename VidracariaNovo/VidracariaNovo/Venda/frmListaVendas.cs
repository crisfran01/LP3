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
    public partial class frmListaVendas : Form
    {
        int usuario;
        public frmListaVendas(int usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void frmListaVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.caixa' table. You can move, or remove it, as needed.
            this.caixaTableAdapter.Fill(this.dataSet1.caixa);
            // TODO: This line of code loads data into the 'dataSet1.venda_cliente' table. You can move, or remove it, as needed.
            this.venda_clienteTableAdapter.Fill(this.dataSet1.venda_cliente);
            // TODO: This line of code loads data into the 'dataSet1.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.dataSet1.vendas);

            cbPesquisa.SelectedIndex = 0;

        }

        public void busca()
        {

            try
            {
                String pendente = cbPendente.Checked ? "Pendente" : "%p%";
                if (cbPesquisa.Text == "Nome")
                {
                    this.venda_clienteTableAdapter.FillByNome(this.dataSet1.venda_cliente, '%' + txtConsulta.Text + '%', pendente);
                }
                else if (cbPesquisa.Text == "Código Cliente")
                {
                    this.venda_clienteTableAdapter.FillByCodCli(this.dataSet1.venda_cliente, Convert.ToInt32(txtConsulta.Text), pendente);
                }
                else if (cbPesquisa.Text == "Código Venda")
                {
                    this.venda_clienteTableAdapter.FillByCodVenda(this.dataSet1.venda_cliente, Convert.ToInt32(txtConsulta.Text));
                }
                else if (cbPesquisa.Text == "CPF")
                {
                    this.venda_clienteTableAdapter.FillByCpf(this.dataSet1.venda_cliente, txtConsulta.Text, pendente);
                }
            }
            catch
            {
                return;
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            this.busca();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            frmBuscaCli buscaCli = new frmBuscaCli(txtConsulta.Text);
            buscaCli.ShowDialog();
            cbPesquisa.SelectedIndex = 1;
            txtConsulta.Text = buscaCli.clienteInfos["cod"];
        }

        private void vendas_cliDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(vendas_cliDataGridView.CurrentRow.Cells[0].Value.ToString());
                if (e.KeyCode == Keys.D)
                {
                    e.Handled = false;

                    this.vendasTableAdapter.DeleteByCod(cod);
                }
                else if (e.KeyCode == Keys.P)
                {
                    if (vendas_cliDataGridView.CurrentRow.Cells[6].Value.ToString() != "Pago")
                    {
                        decimal valor = Convert.ToDecimal(vendas_cliDataGridView.CurrentRow.Cells[5].Value.ToString());
                        this.vendasTableAdapter.UpdateStatusFinalizado(cod);
                        DateTime data = DateTime.Now;
                        this.caixaTableAdapter.InsertQuery(valor, "Pagamento da venda " + vendas_cliDataGridView.CurrentRow.Cells[0].Value.ToString(), usuario, data);
                    }
                }
                this.vendasTableAdapter.Update(this.dataSet1);
                this.busca();
            }
            catch
            {
                return;
            }

        }

        private void cbPendente_CheckedChanged(object sender, EventArgs e)
        {
            this.busca();
        }

        private void vendas_cliDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmVendaDetalhes obj = new frmVendaDetalhes(Convert.ToInt32(vendas_cliDataGridView.CurrentRow.Cells[0].Value.ToString()));
            obj.Show(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
