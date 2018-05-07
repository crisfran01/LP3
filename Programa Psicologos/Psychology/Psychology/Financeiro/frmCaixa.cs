using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;

namespace Psychology
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }              

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.caixa' table. You can move, or remove it, as needed.
            this.caixaTableAdapter.Fill(this.psiEasy.caixa);
            this.caixaTableAdapter.FillByData(this.psiEasy.caixa, DateTime.Now);
            total();
            this.reportCaixa.RefreshReport();
        }

        public void total()
        {
            txtTotal.Text = Convert.ToString( this.caixaTableAdapter.SumValor(dtCaixa.Value));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.caixaTableAdapter.FillByData(this.psiEasy.caixa, dtCaixa.Value );
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
                    
                    caixaBindingSource.AddNew();

                    DataRow rowCaixa = ((DataRowView)caixaBindingSource.Current).Row;
                    DateTime data = DateTime.Now;
                    rowCaixa["data"] = data.ToShortDateString();
                    rowCaixa["valor"] = "-" + txtValor.Text;
                    rowCaixa["responsavel"] = Funcoes.codUsuario + " - " + Funcoes.nomeUsuario;
                    rowCaixa["detalhes"] = txtDetalhe.Text;

                    this.caixaBindingSource.EndEdit();
                    this.caixaTableAdapter.Update(this.psiEasy.caixa);
                    this.caixaTableAdapter.FillByData(this.psiEasy.caixa, DateTime.Now);

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

        private void btnFecharImpre_Click(object sender, EventArgs e)
        {
            reportCaixa.Visible = false;
            btnFecharImpre.Visible = false;
        }

        private void btnImpre1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String time = string.Format("{0:HH:mm}", dt);
            String diaat =string.Format("{0:dd/MM/yyyy}", dt);

            ReportParameter dataCaixa = new ReportParameter("dataCaixa", dtCaixa.Text);
            reportCaixa.LocalReport.SetParameters(dataCaixa);

            ReportParameter horario = new ReportParameter("horario",time );
            reportCaixa.LocalReport.SetParameters(horario);


            ReportParameter dataReport = new ReportParameter("dataReport", diaat);
            reportCaixa.LocalReport.SetParameters(dataReport);

                    
                
            this.reportCaixa.RefreshReport();
            reportCaixa.Visible = true;
            btnFecharImpre.Visible = true;
        }
            
    }
}
