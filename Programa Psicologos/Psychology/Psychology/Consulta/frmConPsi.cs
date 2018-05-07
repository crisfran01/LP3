using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychology
{
    public partial class frmConPsi : Form
    {
        public frmConPsi()
        {
            InitializeComponent();
        }

        private frmCadPsico _instanciaCadPsi = null;

        public frmCadPsico instanciaCadPsi
        {
            get
            {
                return _instanciaCadPsi;
            }
            set
            {
                _instanciaCadPsi = value;
            }
        }

        private void frmConPsi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.psicologos' table. You can move, or remove it, as needed.
            this.psicologosTableAdapter.Fill(this.psiEasy.psicologos);
        }

        private void qndoPsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbBusca.Text == "Nome")
                {
                    psicologosBindingSource.Filter = "Nome like '%" + txtBusca.Text + "%'";
                }
                else if (cbBusca.Text == "Endereço")
                {
                    psicologosBindingSource.Filter = "end like '%" + txtBusca.Text + "%'";
                }
                else if (cbBusca.Text == "Numero")
                {
                    psicologosBindingSource.Filter = "num =" + txtBusca.Text;
                }
                else if (cbBusca.Text == "CRP")
                {
                    psicologosBindingSource.Filter = "CRP like '%" + txtBusca.Text + "%'";
                }
                else if (cbBusca.Text == "Abordagem")
                {
                    psicologosBindingSource.Filter = "Abordagem like '%" + txtBusca.Text + "%'";
                }
                else if (cbBusca.Text == "Cod Psicologo")
                {
                    psicologosBindingSource.Filter = "CodP =" + txtBusca.Text;
                }
            }
            catch
            {
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void enviar()
        {
            frmCadPsico CadPsi = instanciaCadPsi;

            string cod_cli = psicologosDataGridView.CurrentRow.Cells[0].Value.ToString();
            string nome_cli = psicologosDataGridView.CurrentRow.Cells[1].Value.ToString();

            CadPsi.psicologosBindingSource.Position = CadPsi.psicologosBindingSource.Find("CodP", cod_cli);

            this.Dispose();
        }

        private void psicologosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            enviar();
        }

        private void psicologosDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enviar();
            }
        }
    }
}
