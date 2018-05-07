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
    public partial class frmSaude : Form
    {
        public frmSaude()
        {
            InitializeComponent();
            medicaComboBox.SelectedIndex = 0;
        }

        private frmTriagem _instanciaTri = null;

        public frmTriagem instanciaTri
        {
            get
            {
                return _instanciaTri;
            }
            set
            {
                _instanciaTri = value;
            }
        }

        private void limp()
        {
            txtNomeM.Clear();
            txtDoses.Clear();
            txtDosa.Clear();
        }

        private void frmSaude_Load(object sender, EventArgs e)
        {

            this.medicamentosTableAdapter.FillByPront(this.psiEasy.medicamentos, Convert.ToInt32(Funcoes.pront));
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);
            // TODO: This line of code loads data into the 'psiDataSet.Medicamentos' table. You can move, or remove it, as needed.
      

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.triagemBindingSource.CancelEdit();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.triagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            MessageBox.Show("Dados Salvos");
        }

        private void btnInserirI_Click(object sender, EventArgs e)
        {
            medicamentosBindingSource.AddNew();

            DataRow rowCli = ((DataRowView)triagemBindingSource.Current).Row;
            DataRow rowMed = ((DataRowView)medicamentosBindingSource.Current).Row;

            rowMed["pront"] = rowCli["Pront"];
            rowMed["nome"] = txtNomeM.Text;
            rowMed["Dosagem"] = txtDosa.Text;
            rowMed["Dose"] = txtDoses.Text;


            this.medicamentosBindingSource.EndEdit();
            this.medicamentosTableAdapter.Update(this.psiEasy);


            this.medicamentosTableAdapter.FillByPront(this.psiEasy.medicamentos, Convert.ToInt32(rowMed["pront"]));
            medicamentosBindingSource.MoveLast();

            limp();
        }

        private void medicaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (medicaComboBox.SelectedIndex == 0)
            {
                panelMed.Visible = true;
               
            }
            if (medicaComboBox.SelectedIndex == 1)
            {
                panelMed.Visible = false;                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.triagemBindingSource.CancelEdit();
        }
    }
}
