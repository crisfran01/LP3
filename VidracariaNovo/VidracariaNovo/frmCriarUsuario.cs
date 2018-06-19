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
    public partial class frmCriarUsuario : Form
    {
        public frmCriarUsuario()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.CancelEdit();
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.Equals(""))
                {
                    MessageBox.Show("Nome de usuário Vazio!");
                }
                else
                {
                    int nivel;
                   
                    if (cbNivel.Text == "")
                    {
                        nivel = 2;
                    }
                    else
                    {
                        nivel = Convert.ToInt32( cbNivel.Text);
                    }

                    usuariosTableAdapter.InsertQuery(txtNome.Text, txtNome.Text, nivel);
                   

                    MessageBox.Show("Usuario Inserido com Sucesso!");

                    txtNome.Clear();

                    usuariosBindingSource.AddNew();
                }
            }
            catch
            {
                MessageBox.Show("Nome de usuário já cadastrado");
                txtNome.Select();
                return;
            }
        }
        private void frmInsereUsu_Load(object sender, EventArgs e)
        {

            usuariosBindingSource.AddNew();

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == 95 || char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}
