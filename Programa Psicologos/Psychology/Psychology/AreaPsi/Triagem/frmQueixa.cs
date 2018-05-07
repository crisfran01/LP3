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
    public partial class frmQueixa : Form
    {
        public frmQueixa()
        {
            InitializeComponent();
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

        private void triagemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.triagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);

        }

        private void frmQueixa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.triagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            MessageBox.Show("Dados Salvos");
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
