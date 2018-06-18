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
    public partial class frmCaixa : Form
    {
        int usuario;
        public frmCaixa(int usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.caixa' table. You can move, or remove it, as needed.
            this.caixaTableAdapter.Fill(this.dataSet1.caixa);
            // TODO: This line of code loads data into the 'dataSet1.caixa_usu' table. You can move, or remove it, as needed.
            this.caixa_usuTableAdapter.Fill(this.dataSet1.caixa_usu);
            total();

        }

        public void total()
        {
            txtTotal.Text = Convert.ToString(this.caixa_usuTableAdapter.SumValor(dtCaixa.Value));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.caixa_usuTableAdapter.FillByData(this.dataSet1.caixa_usu, dtCaixa.Value);
            total();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                double totaln = Convert.ToDouble(txtTotal.Text);
                double desconto = Convert.ToDouble(txtValor.Text);

                if (totaln - desconto >= 0)
                {

                    caixa_usuBindingSource.AddNew();
                    DataRow rowCaixa = ((DataRowView)caixa_usuBindingSource.Current).Row;
                    DateTime data =  DateTime.Now;
                    this.caixaTableAdapter.InsertQuery(Convert.ToDecimal("-" + txtValor.Text), txtDetalhe.Text , usuario, data);
                    this.caixa_usuTableAdapter.FillByData(this.dataSet1.caixa_usu, DateTime.Now);
                    dtCaixa.Value = DateTime.Now;
                    total();
                }
                else
                {
                    MessageBox.Show("Não há este valor em caixa!");
                }
            }
            catch
            {
                return;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46))
            {
                e.KeyChar = (char)44;
                e.Handled = false;
            }

            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == 88 || e.KeyChar == 120 || e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == 46 || e.KeyChar == 44))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
