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
    public partial class frmCadCli : Form
    {
        public frmCadCli()
        {
            InitializeComponent();
        }
        Boolean newCad = false;
        private void frmCadCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);
            // TODO: This line of code loads data into the 'psiEasy.psicologos' table. You can move, or remove it, as needed.
            this.psicologosTableAdapter.Fill(this.psiEasy.psicologos);
            // TODO: This line of code loads data into the 'psiEasy.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.psiEasy.cliente);
            // TODO: This line of code loads data into the 'psiEasy.cliente' table. You can move, or remove it, as needed
            enableText(true, false);
        }

        public void criarTri()
        {
            try
            {
                DataRow rowCli = ((DataRowView)clienteBindingSource.Current).Row;
                DataRow rowTri = ((DataRowView)triagemBindingSource.Current).Row;
                rowTri["Pront"] = rowCli["Pront"];

                this.triagemBindingSource.EndEdit();
                this.triagemTableAdapter.Update(this.psiEasy);
            }
            catch
            {
                return;
            }

        }

        public void retiraMask()
        {
            cpfTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rgTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            celTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telRespTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cepTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
           
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConCli con = new frmConCli();

            con.instanciaCadCli = this;

            Funcoes.consu = "C";
            
            con.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        #region verificaTeclas

        private void txtCPsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void idadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void dtNacTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == (char)47 || e.KeyChar == (char)45 ))
            {
                e.Handled = true;
            }
        }

        private void numTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void cepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == (char)46 || e.KeyChar == (char)45))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)32 || e.KeyChar == (char)8 || e.KeyChar == (char)45 || e.KeyChar == (char)40 || e.KeyChar == (char)41))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)32 || e.KeyChar == (char)8 || e.KeyChar == (char)45 || e.KeyChar == (char)40 || e.KeyChar == (char)41))
            {
                e.Handled = true;
            }
        }

        private void cpfTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void rgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == 88 || e.KeyChar == 120))
            {
                e.Handled = true;
            }
        }

        private void telRespTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)32 || e.KeyChar == (char)8 || e.KeyChar == (char)45 || e.KeyChar == (char)40 || e.KeyChar == (char)41))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void txtCPsi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                psicologosTableAdapter.FillByCod(this.psiEasy.psicologos, Convert.ToInt32(txtCPsi.Text));
                txtNomePsi.Text = psiEasy.psicologos[psicologosBindingSource.Position].Nome;
            } 
            catch
            {
                return;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCPsi.Text == "")
                {
                    MessageBox.Show("Digite o codigo do psicologo!");
                }
                else
                {
                    retiraMask();
                    this.Validate();
                    this.clienteBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.psiEasy);
                    this.clienteTableAdapter.Fill(this.psiEasy.cliente);
                    panelEdit.SendToBack();
                    txtCPsi.ReadOnly = true;
                    enableText(true, false);
                    if (newCad)
                    {
                        triagemBindingSource.AddNew();
                        criarTri();                                                                      
                        newCad = false;
                    }
                }
            }
            catch
            {
                return;
            }
        }
        

           

        private void btnNovo_Click(object sender, EventArgs e)
        {
           
                panelEdit.BringToFront();
                clienteBindingSource.CancelEdit();
                clienteBindingSource.AddNew();
                txtCPsi.ReadOnly = false;
                enableText(false, true);
                nomeTextBox.Focus();
                newCad = true;
            
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            clienteBindingSource.MovePrevious();
            txtCPsi.ReadOnly = true;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            clienteBindingSource.MoveNext();
            txtCPsi.ReadOnly = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            enableText(false, true);
            nomeTextBox.Focus();
        }

        private void enableText(Boolean enable, Boolean enablec)
        {
            nomeTextBox.ReadOnly = enable;
            idadeTextBox.ReadOnly = enable;
            sexoComboBox.Enabled = enablec;
            dtNacTextBox.ReadOnly = enable;
            cpfTextBox.ReadOnly = enable;
            rgTextBox.ReadOnly = enable;
            escolaridadeTextBox.ReadOnly = enable;
            estCivilComboBox.Enabled = enablec;
            responsavelTextBox.ReadOnly = enable;
            telRespTextBox.ReadOnly = enable;
            endTextBox.ReadOnly = enable;
            numTextBox.ReadOnly = enable;
            bairroTextBox.ReadOnly = enable;
            cidadeTextBox.ReadOnly = enable;
            estadoComboBox.Enabled = enablec;
            cepTextBox.ReadOnly = enable;
            telTextBox.ReadOnly = enable;
            celTextBox.ReadOnly = enable;
            emailTextBox.ReadOnly = enable;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEdit.SendToBack();
            enableText(true, false);
            txtCPsi.ReadOnly = true;
            this.clienteBindingSource.CancelEdit();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.clienteBindingSource.CancelEdit();
            this.Dispose();
        }
    }
}
