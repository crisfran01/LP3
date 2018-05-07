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
    public partial class frmTriagem : Form
    {
        public frmTriagem()
        {
            InitializeComponent();

        }

        private frmSaude _instanciaSa = null;

        public frmSaude instanciaSa
        {
            get
            {
                return _instanciaSa;
            }
            set
            {
                _instanciaSa = value;
            }
        }

        private frmQueixa _instanciaQ = null;

        public frmQueixa instanciaQ
        {
            get
            {
                return _instanciaQ;
            }
            set
            {
                _instanciaQ = value;
            }
        }
             
        private frmFamilia _instanciaFa = null;

        public frmFamilia instanciaFa
        {
            get
            {
                return _instanciaFa;
            }
            set
            {
                _instanciaFa = value;
            }
        }

        public void retiraMask()
        {
            cpfTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            rgTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            celTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telRespTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telEmerTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cepTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

        }

        public void showForm(Form obj)
        {
            obj.MdiParent = this.MdiParent;
            obj.ControlBox = false;
            obj.MaximizeBox = false;
            obj.ShowIcon = false;
            obj.Text = "";
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        public String pront;
      
        public frmPrincipal objPrin = new frmPrincipal();

        public void chamaCon()
        {
            Funcoes.consu = "T";
            frmConCli objCli = new frmConCli();
            objCli.instanciaTri = this;
            
            objCli.cbBuscTri.Visible = true;
            objCli.clienteDataGridView.DataSource = null;
            objCli.labTri.Visible = true;
            objCli.ShowDialog();

            if (Funcoes.consu == "Er")
            {
                this.Dispose();
            }
        }

        public void criaCon()
        {
            try
            {
                DataRow rowCon = ((DataRowView)sessoesBindingSource.Current).Row;
                DataRow rowTri = ((DataRowView)triagemBindingSource.Current).Row;
                rowCon["pront"] = rowTri["Pront"];
                rowCon["descr"] = "Sessão de triagem";
                rowCon["pg"] = "I";
                rowCon["valor"] = 0;
                this.sessoesBindingSource.EndEdit();
                this.sessoesTableAdapter.Update(this.psiEasy);
            }
            catch
            {
                return;
            }
        }
               

        private void frmTriagem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.sessoes' table. You can move, or remove it, as needed.
            this.sessoesTableAdapter.Fill(this.psiEasy.sessoes);
            // TODO: This line of code loads data into the 'psiEasy.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.psiEasy.cliente);
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);
            // TODO: This line of code loads data into the 'psiEasy.triagem' table. You can move, or remove it, as needed.
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);
            // TODO: This line of code loads data into the 'psiDataSet.Triagem' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.psiEasy.cliente);           

        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            frmFamilia objFami = new frmFamilia();
            showForm(objFami);
            objFami.triagemBindingSource.Position = this.triagemBindingSource.Position;
            objFami.irmaoBindingSource.Position = this.triagemBindingSource.Position;
        }

        private void btnSaude_Click(object sender, EventArgs e)
        {
            frmSaude objSau = new frmSaude();
            showForm(objSau);

            objSau.triagemBindingSource.Position = this.triagemBindingSource.Position;
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQueixa_Click(object sender, EventArgs e)
        {            
           frmQueixa objQ = new frmQueixa();
           showForm(objQ);
           objQ.triagemBindingSource.Position = this.triagemBindingSource.Position;
        }

        private void vlseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46))
            {
                e.KeyChar = (char)44;
                e.Handled = false;
            }

            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == 88 || e.KeyChar == 120 || e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == 46 || e.KeyChar == 44))
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            retiraMask();
            this.Validate();
            this.triagemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            this.triagemTableAdapter.Fill(this.psiEasy.triagem);

        }

        private void triagemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            retiraMask();
            this.Validate();
            this.triagemBindingSource.EndEdit();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            

        }
    }
}
