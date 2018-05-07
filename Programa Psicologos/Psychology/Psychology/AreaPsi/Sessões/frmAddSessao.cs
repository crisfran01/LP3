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
    public partial class frmAddSessao : Form
    {
        public frmAddSessao()
        {
            InitializeComponent();
        }

        private frmConsultaSessoes _instanciaSes = null;

        public frmConsultaSessoes instanciaSes
        {
            get
            {
                return _instanciaSes;
            }
            set
            {
                _instanciaSes = value;
            }
        }

        private frmSessoesInfor _instanciaSesI = null;

        public frmSessoesInfor instanciaSesI
        {
            get
            {
                return _instanciaSesI;
            }
            set
            {
                _instanciaSesI = value;
            }
        }

        private void frmAddSes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psiEasy.sessoes' table. You can move, or remove it, as needed.
            this.sessoesTableAdapter.Fill(this.psiEasy.sessoes);
            // TODO: This line of code loads data into the 'psiEasy.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.psiEasy.cliente);
            
            sessoesBindingSource.AddNew();
            
            
          

        }
        
        public void criarses()
        {

            DataRow rowCli = ((DataRowView)clienteBindingSource.Current).Row;
            DataRow rowSes = ((DataRowView)sessoesBindingSource.Current).Row;
            rowSes["Pront"] = rowCli["Pront"];

            int pront = Convert.ToInt32( rowCli["Pront"]);
            String nSes = sessoesTableAdapter.SumSes(pront).ToString();

            
            this.sessoesBindingSource.EndEdit();
            this.sessoesTableAdapter.Update(this.psiEasy);

            txtDescr.Select();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       /* public void passarPront(){
            sessoesBindingSource.Find("pront", Funcoes.pront);
            clienteBindingSource.Find("pront", Funcoes.pront);
            }*/

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            criarses();
            this.Validate();
            this.sessoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.psiEasy);
            MessageBox.Show("Dados Salvos");

            if (cbNComp.Checked)
            {
                DataRow rowSes = ((DataRowView)sessoesBindingSource.Current).Row;
                rowSes["pg"] = "N";
                this.sessoesBindingSource.EndEdit();
                this.sessoesTableAdapter.Update(this.psiEasy);
                
            } else
            {
                DataRow rowSes = ((DataRowView)sessoesBindingSource.Current).Row;
                rowSes["pg"] = "A";
                this.sessoesBindingSource.EndEdit();
                this.sessoesTableAdapter.Update(this.psiEasy);
                

            } 

        }

        private void datDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void datDateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            btnSalvar.Enabled = true;
        }
    }
}
