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
    public partial class frmSessoesInfor : Form
    {
        public frmSessoesInfor()
        {
            InitializeComponent();
        }

        private frmConsultaSessoes _instanciaSessoes = null;

        public frmConsultaSessoes instanciaSessoes
        {
            get
            {
                return _instanciaSessoes;
            }
            set
            {
                _instanciaSessoes = value;
            }
        }


        private void frmSessoesInfor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.psiEasy.cliente);
            // TODO: This line of code loads data into the 'psiEasy.sessoes' table. You can move, or remove it, as needed.
            this.sessoesTableAdapter.Fill(this.psiEasy.sessoes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sessoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
        }

        private void btnAddSes_Click(object sender, EventArgs e)
        {
            if (Funcoes.codP == Funcoes.codPsiBanco)
            {
                frmAddSessao objAddses = new frmAddSessao();
                objAddses.instanciaSesI = this;
                objAddses.MdiParent = this.MdiParent;
                objAddses.Show();               
                objAddses.clienteBindingSource.Position = objAddses.clienteBindingSource.Find("pront", Funcoes.pront);


            }
            else
            {
                MessageBox.Show("Acesso negado! Código do psicologo Errado");
            }
            this.Dispose();
        }

        private void txtDescr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
