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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter.FillByLogin(this.psiEasy.usuarios, txtLogin.Text, txtSenha.Text);
            if (usuariosBindingSource.Count != 0)
            {
                
               String senha = psiEasy.usuarios[usuariosBindingSource.Position].senha;
               
                frmPrincipal objPrin = new frmPrincipal();
                objPrin.instanciaLogin = this;
                frmAlterarSenha frmS = new frmAlterarSenha();
                frmS.instanciaLogin = this;

                if (txtLogin.Text.Equals(txtSenha.Text))
                {
                   
                    
                    frmS.txtSenhaAt.Text = txtSenha.Text;
                    frmS.txtSenhaN.Select();
                    frmS.ShowDialog();


                }
                objPrin.Show();
                //objPrin.lblUsuario.Text = psiEasy.usuarios[usuariosBindingSource.Position].nome;
                Funcoes.nivel = psiEasy.usuarios[usuariosBindingSource.Position].nivel;
                Funcoes.codP = psiEasy.usuarios[usuariosBindingSource.Position].codPsi;
                Funcoes.nomeUsuario = psiEasy.usuarios[usuariosBindingSource.Position].nome;
                Funcoes.codUsuario = psiEasy.usuarios[usuariosBindingSource.Position].cod;
                
                this.Visible = false;
            }
            
            else
            {
                MessageBox.Show("Senha invalida!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.usuarioss' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.psiEasy.usuarios);
           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
