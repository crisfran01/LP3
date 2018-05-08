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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        public void retiraMask()
        {
            cpfTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rgTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            celTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cepTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

        }

        private void enableText(Boolean enable, Boolean enablec)
        {
            nomeTextBox.ReadOnly = enable;
            idadeTextBox.ReadOnly = enable;
            sexoComboBox.Enabled = enablec;
            dtNacTextBox.ReadOnly = enable;
            cpfTextBox.ReadOnly = enable;
            rgTextBox.ReadOnly = enable;
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

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dataSet1.clientes);

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            clientesBindingSource.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            clientesBindingSource.MovePrevious();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            clientesBindingSource.CancelEdit();
            clientesBindingSource.AddNew();
            enableText(false, true);
            nomeTextBox.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
         
                retiraMask();
                this.Validate();
                this.clientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
                this.clientesTableAdapter.Fill(this.dataSet1.clientes);
                panelEdit.SendToBack();
                txtCPsi.ReadOnly = true;
                enableText(true, false);    
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.BringToFront();
            enableText(false, true);
            nomeTextBox.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEdit.SendToBack();
            enableText(true, false);
            this.clientesBindingSource.CancelEdit();
        }
    }
}
