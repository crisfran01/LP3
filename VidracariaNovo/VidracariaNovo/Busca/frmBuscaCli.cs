﻿using System;
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
    public partial class frmBuscaCli : Form
    {
        public frmBuscaCli()
        {
            InitializeComponent();
            cbPesquisa.SelectedIndex = 0;

        }

        public frmBuscaCli(String name)
        {
            InitializeComponent();
            this.txtConsulta.Text = name;
            cbPesquisa.SelectedIndex= 1;
        }

        private void frmBuscaCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dataSet1.clientes);

        }
        string codigo;
        string name;
        public Dictionary<string, String> clienteInfos
        {
            get
            {
                Dictionary<string, String> infos = new Dictionary<string, String>();
                infos.Add("cod", codigo);
                infos.Add("name", name);
                return infos;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (cbPesquisa.Text == "Nome")
            {
                this.clientesTableAdapter.FillByName(this.dataSet1.clientes, "%" + txtConsulta.Text + "%");
            }
        }

        private void clientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = clientesDataGridView.CurrentRow.Cells[0].Value.ToString();
            name = clientesDataGridView.CurrentRow.Cells[1].Value.ToString();
            this.Dispose();
        }
    }
}
