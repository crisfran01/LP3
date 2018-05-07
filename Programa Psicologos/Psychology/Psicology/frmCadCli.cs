using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psicology
{
    public partial class frmCadCli : Form
    {
        public frmCadCli()
        {
            InitializeComponent();
        }

        private void frmCadCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiDatabaseDataSet.psicologos' table. You can move, or remove it, as needed.
            this.psicologosTableAdapter.Fill(this.psiDatabaseDataSet.psicologos);
            // TODO: This line of code loads data into the 'psiDatabaseDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.psiDatabaseDataSet.Cliente);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiDatabaseDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
