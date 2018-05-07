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
    public partial class frmInsereUsu : Form
    {
        public frmInsereUsu()
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

                    DataRow row = ((DataRowView)usuariosBindingSource.Current).Row;
                    row["nome"] = txtNome.Text;
                    row["senha"] = txtNome.Text;
                    if (cbNivel.Text == "")
                    {
                        row["nivel"] = "2";
                    }
                    else
                    {
                        row["nivel"] = cbNivel.Text;
                    }
                    if (txtCod.Text == "v")
                    {

                    }
                    else
                    {
                       
                        row["codPsi"] = txtCod.Text;
                    }
                    if (txtCod.Text == "" || txtCod.Text == "0")
                    {
                        MessageBox.Show("Coloque object codigo do psicologo");
                    }
                    else
                    {
                        this.Validate();
                        this.usuariosBindingSource.EndEdit();
                   
                        MessageBox.Show("Usuario Inserido com Sucesso!");
                    }
                    
                    
                   
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

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
            }
        }
    }
}
