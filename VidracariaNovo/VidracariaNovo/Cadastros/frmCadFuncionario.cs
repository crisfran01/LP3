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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
            enableText(true, false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            enableText(false, true);
            panelEdit.BringToFront();
            funcionariosBindingSource.CancelEdit();
            funcionariosBindingSource.AddNew();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.CancelEdit();
            funcionariosBindingSource.MovePrevious();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.CancelEdit();
            funcionariosBindingSource.MoveNext();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            retiraMask();
            this.Validate();
            funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            this.funcionariosTableAdapter.Fill(this.dataSet1.funcionarios);
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
            txtCod.ReadOnly = enable;
            nomeTextBox.ReadOnly = enable;
            endTextBox.ReadOnly = enable;
            numTextBox.ReadOnly = enable;
            bairroTextBox.ReadOnly = enable;
            cidadeTextBox.ReadOnly = enable;
            estadoComboBox.Enabled = enablec;
            cepTextBox.ReadOnly = enable;
            cpfTextBox.ReadOnly = enable;
            telTextBox.ReadOnly = enable;
            celTextBox.ReadOnly = enable;

        }

        public void retiraMask()
        {
            cpfTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rgTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            celTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtFgts.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cepTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEdit.SendToBack();
            enableText(true, false);
            this.funcionariosBindingSource.CancelEdit();
        }

        private void frmCadFun_Load(object sender, EventArgs e)
        {
            this.funcionariosTableAdapter.Fill(this.dataSet1.funcionarios);
        }

     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.funcionariosBindingSource.CancelEdit();
            this.Dispose();
        }


    }

}
