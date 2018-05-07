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
    public partial class frmConCli : Form
    {
        public frmConCli()
        {
            InitializeComponent();
            cbBusca.SelectedIndex = 0;
            cbBuscTri.SelectedIndex = 0;
        }

        private frmCadCli _instanciaCadCli = null;

        public frmCadCli instanciaCadCli
        {
            get
            {
                return _instanciaCadCli;
            }
            set
            {
                _instanciaCadCli = value;
            }
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
        private frmConsultaSessoes _instanciaeSes = null;

        public frmConsultaSessoes instanciaeSes
        {
            get
            {
                return _instanciaeSes;
            }
            set
            {
                _instanciaeSes = value;
            }
        }

        private frmDoc _instanciaDoc = null;

        public frmDoc instanciaDoc
        {
            get
            {
                return _instanciaDoc;
            }
            set
            {
                _instanciaDoc = value;
            }
        }

        private frmSessoesFinanceiro _instanciaConS = null;

        public frmSessoesFinanceiro instanciaConS
        {
            get
            {
                return _instanciaConS;
            }
            set
            {
                _instanciaConS = value;
            }
        }

        private frmConsultaSessoes _instanciaSe = null;

        public frmConsultaSessoes instanciaSe
        {
            get
            {
                return _instanciaSe;
            }
            set
            {
                _instanciaSe = value;
            }
        }

        private void frmConCli_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.psiEasy.cliente);
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Funcoes.consu == "T" || Funcoes.consu == "D"|| Funcoes.consu == "A")
                {

                    clienteDataGridView.DataSource = clienteBindingSource;
                    if (cbBuscTri.Text == "Nome")
                    {
                        this.clienteTableAdapter.FillByNome(this.psiEasy.cliente,Funcoes.codP, "%" + txtBusca.Text + "%");
                    }
                    else if (cbBuscTri.Text == "CPF")
                    {
                        this.clienteTableAdapter.FillByCpf(this.psiEasy.cliente, Funcoes.codP, "%" + txtBusca.Text + "%");
                    }
                    else if (cbBuscTri.Text == "Prontuario")
                    {
                        this.clienteTableAdapter.FillByProntEPsi(this.psiEasy.cliente, Funcoes.codP, Convert.ToInt32(txtBusca.Text));                       
                    }
                }
                else
                {                    
                    if (cbBusca.Text == "Nome")
                    {
                        clienteBindingSource.Filter = "Nome like '%" + txtBusca.Text + "%'";
                    }
                    else if (cbBusca.Text == "Endereço")
                    {
                        clienteBindingSource.Filter = "ende like '%" + txtBusca.Text + "%'";
                    }
                    else if (cbBusca.Text == "Numero")
                    {
                        clienteBindingSource.Filter = "num =" + txtBusca.Text;
                    }
                    else if (cbBusca.Text == "CPF")
                    {
                        clienteBindingSource.Filter = "CPF like '%" + txtBusca.Text + "%'";
                    }
                    else if (cbBusca.Text == "Cod Psicologo")
                    {
                        clienteBindingSource.Filter = "Psicologo =" + txtBusca.Text;
                    }
                    else if (cbBusca.Text == "Prontuario")
                    {
                        clienteBindingSource.Filter = "Pront =" + txtBusca.Text;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Funcoes.consu == "T")
            {
                Funcoes.consu = "Er";
            }
            this.Dispose();
        }

        public void enviar()
        {

            Funcoes.pront = clienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            string nome_cli = clienteDataGridView.CurrentRow.Cells[1].Value.ToString();
                       
            if (Funcoes.consu == "C")
            {
                frmCadCli CadCli = instanciaCadCli;
                CadCli.clienteBindingSource.Position = CadCli.clienteBindingSource.Find("Pront", Funcoes.pront);
            }
            if (Funcoes.consu == "T")
            {
                frmTriagem objTri = instanciaTri;
                objTri.triagemBindingSource.Position = objTri.triagemBindingSource.Find("pront", Funcoes.pront);
                objTri.clienteBindingSource.Position = objTri.clienteBindingSource.Find("Pront", Funcoes.pront);
            }
                   
            this.Dispose();
        }
        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            enviar();
        }

        private void clienteDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enviar();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
            
    }
}
