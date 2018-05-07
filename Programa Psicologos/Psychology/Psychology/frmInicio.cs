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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            labelDate.Text = (DateTime.Now.ToString("dd-MM-yyyy"));
            this.agendaTableAdapter.FillByCodP(this.psiEasy.agenda, Funcoes.codP);
            this.agendaBindingSource.Filter = "Status = 'Incompleto'";

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = (DateTime.Now.ToString("HH:mm"));
        }
    }
}
