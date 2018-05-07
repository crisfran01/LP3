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
    public partial class frmInseUsu : Form
    {
        public frmInseUsu()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)usuBindingSource.Current).Row;
            row["Nome"] = txtNome.Text;
            row["senha"] = txtNome.Text;
            this.usuBindingSource.EndEdit();
            this.usuariosTableAdapter.Update(this.psiDatabaseDataSet1);
            MessageBox.Show("Usuário inserido com sucesso!");
            this.usuariosTableAdapter.Fill(this.psiDatabaseDataSet1.Usuarios);
            txtNome.Clear();
            usuBindingSource.AddNew();
        }

        private void frmInseUsu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiDatabaseDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.psiDatabaseDataSet1.Usuarios);
            usuBindingSource.AddNew();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            usuBindingSource.CancelEdit();

        }
    }
}
