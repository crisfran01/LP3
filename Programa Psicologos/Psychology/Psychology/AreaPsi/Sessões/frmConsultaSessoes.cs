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
    public partial class frmConsultaSessoes : Form
    {
        public frmConsultaSessoes()
        {
            InitializeComponent();
        }
 
        private frmAddSessao _instanciaAddS = null;
        
        public frmAddSessao instanciaAddS
        {
            get
            {
                return _instanciaAddS;
            }
            set
            {
                _instanciaAddS = value;
            }
        }

      
        

        private void frmSessoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.sessoes_cli' table. You can move, or remove it, as needed.
            this.sessoes_cliTableAdapter.Fill(this.psiEasy.sessoes_cli);
            // TODO: This line of code loads data into the 'psiEasy.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.psiEasy.cliente);
            
        }

 

        public void atuaTab()
        {
            this.sessoesTableAdapter.FillByProntu(this.psiEasy.sessoes, Convert.ToInt32(Funcoes.pront));
        }

       

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddSes_Click(object sender, EventArgs e)
        {
            try
            {

                Funcoes.consu = "A";
                frmConCli objCli = new frmConCli();
                objCli.instanciaeSes = this;

                objCli.cbBuscTri.Visible = true;
                objCli.clienteDataGridView.DataSource = null;
                objCli.labTri.Visible = true;
                objCli.ShowDialog();

                frmAddSessao objAddses = new frmAddSessao();
                objAddses.instanciaSes = this;
                objAddses.MdiParent = this.MdiParent;
                objAddses.Dock = DockStyle.Fill;
                objAddses.Show();
                // objAddses.sessoesBindingSource.Position = ;
                objAddses.clienteBindingSource.Position = objAddses.clienteBindingSource.Find("pront", Funcoes.pront);


                this.Dispose();
            }
            catch
            {
                return;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sessoes_cliBindingSource.Filter = "nome like '%" + txtNome.Text + "%'";
            }
            catch
            {
                return;
            }
        }

        private void txtPront_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sessoes_cliBindingSource.Filter = "pront = " + txtPront.Text;
            }
            catch
            {
                return;
            }
        }

        private void psicologosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Funcoes.codPsiBanco = Convert.ToInt32( sesso_CliDataGridView.CurrentRow.Cells[0].Value.ToString());
            Funcoes.pront = sesso_CliDataGridView.CurrentRow.Cells[2].Value.ToString();

            if (Funcoes.codP == Funcoes.codPsiBanco)
            {
                frmSessoesInfor objSeInfo = new frmSessoesInfor();
                objSeInfo.MdiParent = this.MdiParent;
                objSeInfo.ControlBox = false;
                objSeInfo.MaximizeBox = false;
                objSeInfo.ShowIcon = false;
                objSeInfo.Text = "";
                objSeInfo.Dock = DockStyle.Fill;
                objSeInfo.Show();                
                objSeInfo.sessoesBindingSource.Position = objSeInfo.sessoesBindingSource.Find("numS", sesso_CliDataGridView.CurrentRow.Cells[1].Value.ToString());
                objSeInfo.clienteBindingSource.Position = objSeInfo.clienteBindingSource.Find("pront", Funcoes.pront);
                

            }
            else
            {
                MessageBox.Show("Acesso negado! Código do psicologo Errado");
            }


        }

        private void sesso_CliDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Funcoes.codPsiBanco = Convert.ToInt32(sesso_CliDataGridView.CurrentRow.Cells[0].Value.ToString());
            Funcoes.pront = sesso_CliDataGridView.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void btnRefre_Click(object sender, EventArgs e)
        {
            this.sessoesTableAdapter.Fill(psiEasy.sessoes);
        }
    }
}
