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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.dataSet1.usuarios);

        }

      
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    usuariosTableAdapter.FillByLogin(this.dataSet1.usuarios, txtLogin.Text, txtSenha.Text);
                    if (usuariosBindingSource.Count != 0)
                    {
                        frmMain objPrin = new frmMain();

                        objPrin.instanciaLogin = this;

                        int usuario = dataSet1.usuarios[usuariosBindingSource.Position].cod; ;
                        if (txtLogin.Text.Equals(txtSenha.Text))
                        {
                            frmAlteraSenha frmS = new frmAlteraSenha(usuario);
                            
                            frmS.ShowDialog();
                        }
                        objPrin.Show();
                        objPrin.nivel = dataSet1.usuarios[usuariosBindingSource.Position].nivel;
                        objPrin.usuario = usuario;
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Usuario e/ou senha invalido(s)!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch
                {
                    return;
                }

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
