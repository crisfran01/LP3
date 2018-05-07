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
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private frmLogin _instanciaLogin = null;
        public frmLogin instanciaLogin
        {
            get
            {
                return _instanciaLogin;
            }
            set
            {
                _instanciaLogin = value;
            }
        }

        frmLogin frmLogin = new frmLogin();

        public String senha;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
             //MessageBox.Show(txtSenhaAt.Text);

            //MessageBox.Show(frmLogin.psiDataSet1.usuario[frmLogin.usuarioBindingSource.Position].senha);
            if (txtSenhaAt.Text == frmLogin.psiEasy.usuarios[frmLogin.usuariosBindingSource.Position].senha)
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
                        frmLogin.psiEasy.usuarios[frmLogin.usuariosBindingSource.Position].senha = txtSenhaN.Text;
                        frmLogin.usuariosBindingSource.EndEdit();
                        frmLogin.usuariosTableAdapter.Update(frmLogin.psiEasy);
                        frmLogin.psiEasy.AcceptChanges();
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

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {
           frmLogin = instanciaLogin;
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
    }
}
