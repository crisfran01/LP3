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
    public partial class frmFamilia : Form
    {
        public frmFamilia()
        {
            InitializeComponent();
            triagemBindingSource.MoveLast();
        }

        private frmTriagem _instanciaTri = null;

        public frmTriagem instanciaTri
        {
            get
            {
                return _instanciaTri;
            }
            set
            {
                _instanciaTri = value;
            }
        }

        public void retiraMask()
        {
            celMTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telMTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            celPTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telPTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            
        }

        private void limp()
        {
            txtEscoI.Clear();
            txtIdadeI.Clear();
            txtNomeI.Clear();
        }

        private void frmFamilia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.irmao' table. You can move, or remove it, as needed.
            this.irmaoTableAdapter.Fill(this.psiEasy.irmao);
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);
            // TODO: This line of code loads data into the 'psiDataSet.Triagem' table. You can move, or remove it, as needed.
           this.irmaoTableAdapter.FillByPront(this.psiEasy.irmao, Convert.ToInt32(Funcoes.pront));
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            retiraMask();
            this.Validate();
            this.triagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            MessageBox.Show("Dados Salvos");
        }

        #region VerificarTeclas

        private void celMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)32 || e.KeyChar == (char)8 || e.KeyChar == (char)45 || e.KeyChar == (char)40 || e.KeyChar == (char)41))
            {
                e.Handled = true;
            }
        }

        private void telMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)32 || e.KeyChar == (char)8 || e.KeyChar == (char)45 || e.KeyChar == (char)40 || e.KeyChar == (char)41))
            {
                e.Handled = true;
            }
        }

        private void idadePTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void celPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)32 || e.KeyChar == (char)8 || e.KeyChar == (char)45 || e.KeyChar == (char)40 || e.KeyChar == (char)41))
            {
                e.Handled = true;
            }
        }

        private void telPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)32 || e.KeyChar == (char)8 || e.KeyChar == (char)45 || e.KeyChar == (char)40 || e.KeyChar == (char)41))
            {
                e.Handled = true;
            }
        }

        private void txtIdadeI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void irmaosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void btnInserirI_Click(object sender, EventArgs e)
        {
            irmaoBindingSource.AddNew();

            DataRow rowCli = ((DataRowView)triagemBindingSource.Current).Row;
            DataRow rowIrm = ((DataRowView)irmaoBindingSource.Current).Row;

            rowIrm["Pront"] = rowCli["Pront"];

            rowIrm["nome"] = txtNomeI.Text;
            rowIrm["Idade"] = txtIdadeI.Text;
            rowIrm["Escolari"] = txtEscoI.Text;
            

            this.irmaoBindingSource.EndEdit();
            this.irmaoTableAdapter.Update(this.psiEasy);


            this.irmaoTableAdapter.FillByPront(this.psiEasy.irmao, Convert.ToInt32(rowIrm["pront"]));
            irmaoBindingSource.MoveLast();

            limp();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            try
            {
                //abre a janela e verifica o retorno ok
                if (odfFoto.ShowDialog() == DialogResult.OK)
                {
                    //insere o arquivo JPG selecionado no PictureBox
                    genetoPictureBox.Image = Image.FromFile(odfFoto.FileName);

                }
                //libera os recursos do OpenFileDualog
                odfFoto.Dispose();
            }
            catch
            {
                return;
            }
        }

        private void triagemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            retiraMask();
            this.Validate();
            this.triagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            MessageBox.Show("Dados Salvos");

        }
   
    }
}
