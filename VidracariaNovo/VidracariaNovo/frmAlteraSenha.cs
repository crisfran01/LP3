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
    public partial class frmAlteraSenha : Form
    {
        int usuario;
        public frmAlteraSenha(int usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void frmAlteraSenha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.dataSet1.usuarios);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter.FillBySenha(this.dataSet1.usuarios, usuario);
            if (txtSenhaAt.Text == dataSet1.usuarios[usuariosBindingSource.Position].senha)
            {
                if (txtSenhaN.Text == txtSenhaNC.Text)
                {
                    if (txtSenhaN.Text == "" || txtSenhaN.Text == "")
                    {
                        MessageBox.Show("Há campos vazios");
                        txtSenhaN.Select();
                    }
                    else if (txtSenhaAt.Text == txtSenhaN.Text)
                    {
                        MessageBox.Show("Senha antiga igual a nova");
                        txtSenhaN.Select();

                    }
                    else
                    {
                        usuariosTableAdapter.UpdateSenha(txtSenhaN.Text, usuario);
                        MessageBox.Show("Senha Alterada com sucesso!");
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show(" Confirmação de senha incorreta!");
                    txtSenhaNC.Select();
                }
            }
            else
            {
                MessageBox.Show("Senha incorreta");
                txtSenhaAt.Select();
            }
        }

        private void txtSenhaNC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAlterar.PerformClick();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSenhaAt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAlterar.PerformClick();
            }
        }

        private void txtSenhaN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAlterar.PerformClick();
            }
        }
        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
