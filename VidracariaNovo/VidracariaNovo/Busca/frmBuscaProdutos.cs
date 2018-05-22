using System;
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
    public partial class frmBuscaProdutos : Form
    {
        public frmBuscaProdutos()
        {
            InitializeComponent();
        }

        private void frmBuscaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.dataSet1.produtos);

        }
        String codigo;
        String name;

        public Dictionary<string, String> productInfos
        {
            get
            {
                Dictionary<string, String> infos = new Dictionary<string, String>();
                infos.Add("cod", codigo);
                infos.Add("name", name);
                return infos;
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (cbPesquisa.Text == "Nome")
            {
                this.produtosTableAdapter.FillByName(this.dataSet1.produtos, "%" + txtConsulta.Text + "%");
            }
        }

        private void produtosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = produtosDataGridView.CurrentRow.Cells[0].Value.ToString();
            name = produtosDataGridView.CurrentRow.Cells[1].Value.ToString();
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
