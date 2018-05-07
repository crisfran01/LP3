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
    public partial class frmSessoesFinanceiro : Form
    {
        public frmSessoesFinanceiro()
        {
            InitializeComponent();
            chamarConsulta();            
        }

        public frmConCli objConCli;
        int contSes = 0;
        bool impre = false;

        private void frmConSes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.caixa' table. You can move, or remove it, as needed.
            this.caixaTableAdapter.Fill(this.psiEasy.caixa);
            this.clienteTableAdapter.Fill(this.psiEasy.cliente);
            this.sessoesTableAdapter.Fill(this.psiEasy.sessoes);

            if (sessoes_cliTableAdapter.FillByPront(this.psiEasy.sessoes_cli, Convert.ToInt32(Funcoes.pront)) > 0)
            {
                numETotalSes();
            }
            else
            {
                MessageBox.Show("Não ha sessões cadastradas!");               
            }
            this.reportViewerRecibo.RefreshReport();
        }

        public void numETotalSes()
        {
            txtNSes.Text = Convert.ToString(sessoes_cliTableAdapter.ContNSe( Convert.ToInt32( Funcoes.pront)));
            txtTotal.Text = Convert.ToString(sessoes_cliTableAdapter.SomaValorSes(Convert.ToInt32(Funcoes.pront)));
            psicologosDataGridView.Focus();
        }

        public void chamarConsulta(){
            Funcoes.consu = "CS";
            objConCli = new frmConCli();
            objConCli.instanciaConS = this;
            objConCli.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      
        private void btnImpr_Click(object sender, EventArgs e)
        {
            try
            {
                if (impre)
                {
                    reportViewerRecibo.Visible = false;
                    btnFecharImpre.Visible = false;

                    impre = false;
                }
                else
                {

                    ReportParameter cliente = new ReportParameter("cliente", psicologosDataGridView.CurrentRow.Cells[1].Value.ToString());
                    reportViewerRecibo.LocalReport.SetParameters(cliente);

                    int valor1 = Convert.ToInt32(psicologosDataGridView.CurrentRow.Cells[8].Value.ToString());

                    ReportParameter valor = new ReportParameter("valor", Convert.ToString(valor1 * contSes));
                    reportViewerRecibo.LocalReport.SetParameters(valor);

                    ReportParameter NAte = new ReportParameter("NAte", Convert.ToString(contSes));
                    reportViewerRecibo.LocalReport.SetParameters(NAte);

                    this.reportViewerRecibo.RefreshReport();

                    btnFecharImpre.Visible = true;
                    reportViewerRecibo.Visible = true;
                    impre = true;
                }
            }
            catch
            {
                return;
            }
        }

        
        private void psicologosDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.P))
            {
                if (psicologosDataGridView.CurrentRow.Cells[7].Value.ToString() != "Pg" ) {
                    DataRow rowSesCli = ((DataRowView)sessoes_cliBindingSource.Current).Row;
                
                    sessoesBindingSource.Filter = "numS = " + rowSesCli["numS"];
                    DataRow rowSessoes = ((DataRowView)sessoesBindingSource.Current).Row;

                    rowSessoes["pg"] = "Pg";

                    caixaBindingSource.AddNew();

                    DataRow rowCaixa = ((DataRowView)caixaBindingSource.Current).Row;
                    DateTime data = DateTime.Now;              
                    rowCaixa["data"] = data.ToShortDateString(); 
                    rowCaixa["valor"] = rowSessoes["valor"];
                    rowCaixa["responsavel"] = Funcoes.codUsuario + " - " + Funcoes.nomeUsuario;
                    rowCaixa["detalhes"] = "Pagamento da sessão " + rowSesCli["numS"] + " do Cliente " + rowSesCli["nome"] + ". Psicologo: código " + rowSesCli["CodP"];
                    rowCaixa["pront"] = rowSessoes["pront"];

                    this.sessoesBindingSource.EndEdit();
                    this.sessoesTableAdapter.Update(this.psiEasy.sessoes);
                    this.caixaBindingSource.EndEdit();
                    this.caixaTableAdapter.Update(this.psiEasy.caixa);
                    this.sessoes_cliTableAdapter.FillByPront(this.psiEasy.sessoes_cli, Convert.ToInt16(txtPront.Text));
                                
                    numETotalSes();

                    contSes += 1;
                }
            }
        }

        private void txtPront_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (sessoes_cliTableAdapter.FillByPront(this.psiEasy.sessoes_cli, Convert.ToInt32(txtPront.Text)) > 0)
                    {
                        contSes = 0;
                        Funcoes.pront = txtPront.Text;
                        numETotalSes();
                    }
                    else
                    {
                        MessageBox.Show("Não ha sessões cadastradas!");
                        // this.ResumeLayout();
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            chamarConsulta();
            if (sessoes_cliTableAdapter.FillByPront(this.psiEasy.sessoes_cli, Convert.ToInt32(Funcoes.pront)) > 0)
            {
                numETotalSes();
            }
            else
            {
                MessageBox.Show("Não ha sessões cadastradas!");
                txtNSes.Text = "0";
                txtTotal.Text = "0";                
            }
            contSes = 0;
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
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
            reportViewerRecibo.Visible = false;
            impre = false;
            btnFecharImpre.Visible = false;
        }

   
    }
}
