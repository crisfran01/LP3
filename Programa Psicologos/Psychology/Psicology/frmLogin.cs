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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter.FillByLogin(this.psiDatabaseDataSet1.Usuarios, txtLogin.Text, txtSenha.Text);

            if (usuariosBindingSource1.Count != 0)
            {
                frmPrincipal objPrin = new frmPrincipal();

                objPrin.instLogin = this;


                if (txtLogin.Text.Equals(txtSenha.Text))
                {
                    frmaAlteraSenha frmS = new frmaAlteraSenha();
                    frmS.instLogin = this;
                    frmS.txtSenhaAt.Text = txtSenha.Text;
                    frmS.txtSenhaN.Select();
                    frmS.ShowDialog();


                }
                objPrin.Show();
                objPrin.sslUsuarios.Text = psiDatabaseDataSet1.Usuarios[usuariosBindingSource1.Position].Nome;
                objPrin.nivel = psiDatabaseDataSet1.Usuarios[usuariosBindingSource1.Position].nivel;
                objPrin.usu = Convert.ToString(psiDatabaseDataSet1.Usuarios[usuariosBindingSource1.Position].cod);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario e/ou senha invalido(s)!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vidracariaDataSource1.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.psiDatabaseDataSet1.Usuarios);


        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiDatabaseDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.psiDatabaseDataSet1.Usuarios);
            // TODO: This line of code loads data into the 'psiDatabaseDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.psiDatabaseDataSet1.Usuarios);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSenha_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
