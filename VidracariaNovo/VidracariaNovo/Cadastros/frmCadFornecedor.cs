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
    public partial class frmCadFornecedor : Form
    {
        public frmCadFornecedor()
        {
            InitializeComponent();
        }


        public void retiraMask()
        {
            cnpjTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            ieTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            celTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cepTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

        }

        private void enableText(Boolean enable, Boolean enablec)
        {
            razaoTextBox.ReadOnly = enable;
            cnpjTextBox.ReadOnly = enable;
            ieTextBox.ReadOnly = enable;
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

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.dataSet1.fornecedores);
            // TODO: This line of code loads data into the 'dataSet1.fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.dataSet1.fornecedores);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            fornecedoresBindingSource.CancelEdit();
            fornecedoresBindingSource.AddNew();
            enableText(false, true);
            razaoTextBox.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            enableText(false, true);
            nomeTextBox.Focus();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            fornecedoresBindingSource.CancelEdit();
            fornecedoresBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            fornecedoresBindingSource.CancelEdit();
            fornecedoresBindingSource.MoveNext();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEdit.SendToBack();
            enableText(true, false);
            this.fornecedoresBindingSource.CancelEdit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                retiraMask();
                this.Validate();
                this.fornecedoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
                this.fornecedoresTableAdapter.Fill(this.dataSet1.fornecedores);
                panelEdit.SendToBack();
                enableText(true, false);
            }
            catch
            {
                MessageBox.Show("CNPJ já cadastrado");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            Verificacao valida = new Verificacao();
            valida.validaEmail(emailTextBox.Text);
        }
    }
}
