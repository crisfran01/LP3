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
    public partial class frmrecibo : Form
    {
        public frmrecibo()
        {
            InitializeComponent();
        }

        private void frmrecibo_Load(object sender, EventArgs e)
        {         
           
            ReportParameter cliente = new ReportParameter("cliente", "___________________________________________________");
            reportViewer1.LocalReport.SetParameters(cliente);

            ReportParameter valor = new ReportParameter("valor", "R$_____");
            reportViewer1.LocalReport.SetParameters(valor);

            ReportParameter NAte = new ReportParameter("NAte", "___");
            reportViewer1.LocalReport.SetParameters(NAte);

            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
