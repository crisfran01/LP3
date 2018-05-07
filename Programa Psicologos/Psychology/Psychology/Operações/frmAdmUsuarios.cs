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
    public partial class frmAdmUsuarios : Form
    {
        public frmAdmUsuarios()
        {
            InitializeComponent();
        }

        private void frmAdmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.psiEasy.usuarios);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Salvar?", "Atenção!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.usuariosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.psiEasy);
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Erro ao salvar registro");
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.CancelEdit();
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja excluir esse registro?", "Atenção!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    this.usuariosBindingSource.RemoveCurrent();
                    this.usuariosBindingSource.EndEdit();
                }
                catch
                {
                    MessageBox.Show("Erro ao excluir registro");
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
