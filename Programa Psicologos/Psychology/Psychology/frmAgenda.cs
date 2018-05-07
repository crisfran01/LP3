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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.FillByCodP(this.psiEasy.agenda, Funcoes.codP);
            agendaBindingSource.Filter = "Status = 'Incompleto'";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            agendaBindingSource.CancelEdit();
            agendaBindingSource.AddNew();
            txtCodP.Text = Convert.ToString(Funcoes.codP);
            panelNovo.Visible = true;
            panelNovo.BringToFront();
            txtTitulo.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Incompleto";
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            MessageBox.Show("Compromisso agendado");
            this.agendaTableAdapter.FillByCodP(this.psiEasy.agenda, Funcoes.codP);
            panelNovo.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            agendaBindingSource.CancelEdit();
            panelNovo.Visible = false;
        }
        private void agendaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            agendaBindingSource.CancelEdit();
            panelNovo.Visible = false;
        }

        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStatus.Checked == true)
            {
                agendaBindingSource.Filter = "";
            }
            else
            {
                agendaBindingSource.Filter = "Status = 'Incompleto'";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelNovo.Visible = true;
            panelNovo.BringToFront();
            txtTitulo.Focus();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Completo";
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            this.agendaTableAdapter.FillByCodP(this.psiEasy.agenda, Funcoes.codP);
        }
    }
}
