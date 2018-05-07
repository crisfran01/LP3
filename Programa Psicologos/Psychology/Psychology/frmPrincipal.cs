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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.SetBevel(false);
        }

        private frmLogin _instanciaLogin = null;
        public frmLogin instanciaLogin
        {
            get
            {
                return _instanciaLogin;
            }
            set
            {
                _instanciaLogin = value;
            }
        }

        private void closeForm()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].IsMdiChild)
                {
                    Application.OpenForms[i].Dispose();
                }
            }
        }

        public void atualiazCaixa()
        {
            caixaTableAdapter.FillByData(this.psiEasy.caixa, DateTime.Today);
            if (caixaBindingSource.Count == 0)
            {
                caixaTableAdapter.Fill(this.psiEasy.caixa);
                caixaBindingSource.MoveLast();
                DataRow rowCaixa = ((DataRowView)caixaBindingSource.Current).Row;

                DateTime diaAnterior = Convert.ToDateTime( rowCaixa["data"].ToString());                

                caixaBindingSource.AddNew();

                DataRow rowCaixa1 = ((DataRowView)caixaBindingSource.Current).Row;
                DateTime data = DateTime.Now;
                rowCaixa1["data"] = data.ToShortDateString();
                rowCaixa1["valor"] = this.caixaTableAdapter.SumValor(diaAnterior); ;
                rowCaixa1["responsavel"] = "Sistema";
                rowCaixa1["detalhes"] = "Valor em caixa do dia anterior ";               
                                
                this.caixaBindingSource.EndEdit();
                this.caixaTableAdapter.Update(this.psiEasy.caixa);
            }
        }
        public void showForm(Form obj)
        {
            obj.MdiParent = this;
            obj.ControlBox = false;
            obj.MaximizeBox = false;
            obj.ShowIcon = false;
            obj.Text = "";
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        

        public frmAlterarSenha objAlterarSenha;
        public frmInsereUsu objInsereUsu;
        public frmTriagem objTriag;
        public frmDoc objDoc;
        public frmConsultaSessoes objSessoes;
        public frmSessoesFinanceiro objconS;


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.caixa' table. You can move, or remove it, as needed.
            this.caixaTableAdapter.Fill(this.psiEasy.caixa);
            frmInicio objInicio = new frmInicio();
            showForm(objInicio);
            atualiazCaixa();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCli cli = new frmCadCli();
            showForm(cli);
        }

        private void psicologosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPsico psi = new frmCadPsico();
            showForm(psi);
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFun objFunc = new frmCadFun();
            showForm(objFunc);
        }

        private void triagemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objTriag = new frmTriagem();
            showForm(objTriag);
            objTriag.chamaCon();
        }

        private void artigoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            objSessoes = new frmConsultaSessoes();
            showForm(objSessoes);
            
        }

        private void consultaStripMenuItem6_Click(object sender, EventArgs e)
        {
            objconS = new frmSessoesFinanceiro();
            showForm(objconS);
        }      

        private void caixaStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmCaixa objCaixa = new frmCaixa();
            showForm(objCaixa);
        }

        private void insereUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Funcoes.nivel == 1)
            {        
                if (objInsereUsu == null || objInsereUsu.IsDisposed)
                {
                    objInsereUsu = new frmInsereUsu();
                }
            }
            else
            {
                objInsereUsu.txtCod.Text = "v";
            }
            objInsereUsu.ShowDialog();  
        }

        private void alteraSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objAlterarSenha == null || objAlterarSenha.IsDisposed)
            {
                objAlterarSenha = new frmAlterarSenha();
                objAlterarSenha.instanciaLogin = instanciaLogin;
            }
            objAlterarSenha.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você deseja mesmo sair?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                frmLogin lg = new frmLogin();
                lg.Show();

                this.Dispose();
            }
            else
            {
                return;
            } 

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objDoc = new frmDoc();
            showForm(objDoc);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio objInicio = new frmInicio();
            showForm(objInicio);
        }
               

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveMdiChild.Close();
                if (ActiveMdiChild == null)
                {
                    frmInicio objDashBoard = new frmInicio();
                    showForm(objDashBoard);
                }
            }
            catch
            {
                return;
            }
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda objAgenda = new frmAgenda();
            showForm(objAgenda);
        }

        private void gerenciarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmUsuarios objUsuarios = new frmAdmUsuarios();
            objUsuarios.ShowDialog();
        }

        private void reciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrecibo objrecibo = new frmrecibo();
            showForm(objrecibo);
        }

        private void caixaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.caixaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
        
        }
    }
}
