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
    public partial class frmAgenda : Form
    {
        int usuario;
        public frmAgenda(int usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.dataSet1.agenda);
            // TODO: This line of code loads data into the 'dataSet1.agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.dataSet1.agenda);

            agendaBindingSource.Filter = "Status = 'Incompleto'";

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            agendaBindingSource.CancelEdit();
            agendaBindingSource.AddNew();
            panelNovo.Visible = true;
            panelNovo.BringToFront();
            txtTitulo.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DataRow rowVend = ((DataRowView)agendaBindingSource.Current).Row;
            rowVend["Data"] = dataDateTimePicker.Value;
            rowVend["CodFun"] = usuario;
            rowVend["Status"] =  "Incompleto";
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            MessageBox.Show("Compromisso agendado");
            this.agendaTableAdapter.Fill(this.dataSet1.agenda);

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
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            this.agendaTableAdapter.Fill(this.dataSet1.agenda);
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void agendaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {                    }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

