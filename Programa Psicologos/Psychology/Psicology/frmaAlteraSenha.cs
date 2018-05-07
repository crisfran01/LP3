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
    public partial class frmaAlteraSenha : Form
    {
        public frmaAlteraSenha()
        {
            InitializeComponent();
        }



        private frmLogin _instLogin = null;

        public frmLogin instLogin
        {
            get
            {
                return _instLogin;
            }
            set
            {
                _instLogin = value;
            }
        }

        public frmLogin objfrmLogin = null;
       

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           /* if (txtSenhaAt.Text == objfrmLogin.psiDatabaseDataSet1.Usuarios[objfrmLogin.usuariosBindingSource1.Position].senha)
                
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
                        objfrmLogin.psiDatabaseDataSet1.Usuarios[objfrmLogin.usuariosBindingSource1.Position].senha = txtSenhaN.Text;
                        objfrmLogin.usuariosBindingSource1.EndEdit();
                        objfrmLogin.usuariosTableAdapter.Update(objfrmLogin.psiDatabaseDataSet1);
                      
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
            }*/
        }

       
        private void txtSenhaNC_KeyDown(object sender, KeyEventArgs e)
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

        private void txtSenhaAt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAlterar.PerformClick();
            }
        }

        private void frmaAlteraSenha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiDatabaseDataSet.Usuarios' table. You can move, or remove it, as needed.
            //this.usuariosTableAdapter.Fill(this.psiDatabaseDataSet.Usuarios);
            objfrmLogin = instLogin;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
