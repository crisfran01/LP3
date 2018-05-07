using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psicology
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public int nivel;

        private frmLogin _instLogin = null;
        public frmLogin instLogin
        {
            get
            {
                return _instLogin;
            }
            set
            {
                _instLogin = value;
            }

        }

        public frmaAlteraSenha objAltSenha = null;
        public frmInseUsu objInseUsu = null;
        

        public String usu;

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCli  cli = new frmCadCli();
            cli.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void insereUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nivel == 1)
            {
                if (objInseUsu == null || objInseUsu.IsDisposed)
                {
                    objInseUsu = new frmInseUsu();
                    //objInserirUsuarios.MdiParent = this;

                }

                objInseUsu.Show();
            }
            else
            {
                if (objInseUsu == null || objInseUsu.IsDisposed)
                {
                    objInseUsu = new frmInseUsu();
                    objInseUsu.MdiParent = this;

                }

                objInseUsu.cbNivel.Visible = false;
                objInseUsu.lbNivel.Visible = false;
                objInseUsu.Show();
            }
        }

        private void alteraSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objAltSenha == null || objAltSenha.IsDisposed)
            {
                objAltSenha = new frmaAlteraSenha();
                //objAltSenha.MdiParent = this;
                objAltSenha.instLogin = instLogin;
                
            }

            objAltSenha.ShowDialog();
        }
    }
}
