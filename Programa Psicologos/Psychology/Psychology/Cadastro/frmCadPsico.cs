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
    public partial class frmCadPsico : Form
    {
        public frmCadPsico()
        {
            InitializeComponent();
        }

        private void frmCadPsico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.psicologos' table. You can move, or remove it, as needed.
            this.psicologosTableAdapter.Fill(this.psiEasy.psicologos);
            enableText(true, false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConPsi objPsi = new frmConPsi();
            objPsi.instanciaCadPsi = this;
            objPsi.Show();
        }

        #region VerificaTeclas

        private void cRPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
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

        private void cepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == (char)46 || e.KeyChar == (char)45))
            {
                e.Handled = true;
            }
        }

#endregion

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            psicologosBindingSource.CancelEdit();
            psicologosBindingSource.AddNew();
            enableText(false, true);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            psicologosBindingSource.CancelEdit();
            psicologosBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            psicologosBindingSource.CancelEdit();
            psicologosBindingSource.MoveNext();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.psicologosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            this.psicologosTableAdapter.Fill(this.psiEasy.psicologos);
            panelEdit.SendToBack();
            enableText(true, false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            enableText(false, true);
            nomeTextBox.Focus();
        }

        private void enableText(Boolean enable, Boolean enablec)
        {
            txtCPsi.ReadOnly = enable;
            cRPTextBox.ReadOnly = enable;
            txtAbordagem.ReadOnly = enable;
            nomeTextBox.ReadOnly = enable;
            endTextBox.ReadOnly = enable;
            numTextBox.ReadOnly = enable;
            bairroTextBox.ReadOnly = enable;
            cidadeTextBox.ReadOnly = enable;
            estadoComboBox.Enabled = enablec;
            cepTextBox.ReadOnly = enable;
            telTextBox.ReadOnly = enable;
            celTextBox.ReadOnly = enable;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEdit.SendToBack();
            enableText(true, false);
            this.psicologosBindingSource.CancelEdit();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.psicologosBindingSource.CancelEdit();
            this.Dispose();
        }
    }
}
