namespace VidracariaNovo
{
    partial class frmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codPGLabel;
            System.Windows.Forms.Label codFunLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label codLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImp = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCodV = new System.Windows.Forms.TextBox();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtFun = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreU = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtLa = new System.Windows.Forms.TextBox();
            this.txtDProd = new System.Windows.Forms.TextBox();
            this.txtCodP = new System.Windows.Forms.TextBox();
            this.itens_subtDataGridView = new System.Windows.Forms.DataGridView();
            this.seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VidracariaNovo.DataSet1();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codVendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.larguraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metragemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new VidracariaNovo.DataSet1TableAdapters.vendasTableAdapter();
            this.itensTableAdapter = new VidracariaNovo.DataSet1TableAdapters.itensTableAdapter();
            this.tableAdapterManager = new VidracariaNovo.DataSet1TableAdapters.TableAdapterManager();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new VidracariaNovo.DataSet1TableAdapters.produtosTableAdapter();
            this.clientesTableAdapter = new VidracariaNovo.DataSet1TableAdapters.clientesTableAdapter();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.condpgTableAdapter = new VidracariaNovo.DataSet1TableAdapters.condpgTableAdapter();
            this.condpgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label10 = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codPGLabel = new System.Windows.Forms.Label();
            codFunLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            codLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itens_subtDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condpgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(374, 531);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(100, 24);
            label10.TabIndex = 220;
            label10.Text = "Desconto:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.ForeColor = System.Drawing.SystemColors.Control;
            valorLabel.Location = new System.Drawing.Point(565, 531);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(62, 24);
            valorLabel.TabIndex = 208;
            valorLabel.Text = "Total:";
            // 
            // codPGLabel
            // 
            codPGLabel.AutoSize = true;
            codPGLabel.BackColor = System.Drawing.Color.Transparent;
            codPGLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codPGLabel.ForeColor = System.Drawing.SystemColors.Control;
            codPGLabel.Location = new System.Drawing.Point(159, 531);
            codPGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codPGLabel.Name = "codPGLabel";
            codPGLabel.Size = new System.Drawing.Size(32, 24);
            codPGLabel.TabIndex = 206;
            codPGLabel.Text = "Pg";
            // 
            // codFunLabel
            // 
            codFunLabel.AutoSize = true;
            codFunLabel.BackColor = System.Drawing.Color.Transparent;
            codFunLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codFunLabel.ForeColor = System.Drawing.SystemColors.Control;
            codFunLabel.Location = new System.Drawing.Point(707, 531);
            codFunLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codFunLabel.Name = "codFunLabel";
            codFunLabel.Size = new System.Drawing.Size(55, 24);
            codFunLabel.TabIndex = 203;
            codFunLabel.Text = "Func";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.BackColor = System.Drawing.Color.Transparent;
            obsLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            obsLabel.ForeColor = System.Drawing.SystemColors.Control;
            obsLabel.Location = new System.Drawing.Point(159, 481);
            obsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(51, 24);
            obsLabel.TabIndex = 201;
            obsLabel.Text = "Obs:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = System.Drawing.Color.Transparent;
            dataLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.ForeColor = System.Drawing.SystemColors.Control;
            dataLabel.Location = new System.Drawing.Point(454, 147);
            dataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(52, 24);
            dataLabel.TabIndex = 198;
            dataLabel.Text = "Data";
            // 
            // codLabel
            // 
            codLabel.AutoSize = true;
            codLabel.BackColor = System.Drawing.Color.Transparent;
            codLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codLabel.ForeColor = System.Drawing.SystemColors.Control;
            codLabel.Location = new System.Drawing.Point(175, 147);
            codLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codLabel.Name = "codLabel";
            codLabel.Size = new System.Drawing.Size(66, 24);
            codLabel.TabIndex = 188;
            codLabel.Text = "Venda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.descricaoComboBox);
            this.panel1.Controls.Add(this.btnImp);
            this.panel1.Controls.Add(label10);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.txtCodV);
            this.panel1.Controls.Add(this.txtNomeC);
            this.panel1.Controls.Add(this.txtCodCli);
            this.panel1.Controls.Add(this.txtFun);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPreU);
            this.panel1.Controls.Add(this.txtQtde);
            this.panel1.Controls.Add(this.txtLa);
            this.panel1.Controls.Add(this.txtDProd);
            this.panel1.Controls.Add(this.txtCodP);
            this.panel1.Controls.Add(this.itens_subtDataGridView);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Controls.Add(codPGLabel);
            this.panel1.Controls.Add(codFunLabel);
            this.panel1.Controls.Add(obsLabel);
            this.panel1.Controls.Add(dataLabel);
            this.panel1.Controls.Add(this.dt_date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(codLabel);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 660);
            this.panel1.TabIndex = 4;
            // 
            // btnImp
            // 
            this.btnImp.BackColor = System.Drawing.Color.Transparent;
            this.btnImp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp.ForeColor = System.Drawing.Color.Indigo;
            this.btnImp.Location = new System.Drawing.Point(847, 526);
            this.btnImp.Margin = new System.Windows.Forms.Padding(4);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(44, 33);
            this.btnImp.TabIndex = 205;
            this.btnImp.UseVisualStyleBackColor = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(485, 526);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(75, 30);
            this.txtDesc.TabIndex = 204;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Valor", true));
            this.lblTotal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(627, 531);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 24);
            this.lblTotal.TabIndex = 219;
            this.lblTotal.Text = "0.00";
            // 
            // txtCodV
            // 
            this.txtCodV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "cod", true));
            this.txtCodV.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodV.Location = new System.Drawing.Point(270, 142);
            this.txtCodV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodV.Name = "txtCodV";
            this.txtCodV.Size = new System.Drawing.Size(132, 30);
            this.txtCodV.TabIndex = 190;
            // 
            // txtNomeC
            // 
            this.txtNomeC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nome", true));
            this.txtNomeC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeC.Location = new System.Drawing.Point(527, 102);
            this.txtNomeC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(476, 30);
            this.txtNomeC.TabIndex = 189;
            this.txtNomeC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeC_KeyDown);
            // 
            // txtCodCli
            // 
            this.txtCodCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cod", true));
            this.txtCodCli.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCli.Location = new System.Drawing.Point(270, 102);
            this.txtCodCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(132, 30);
            this.txtCodCli.TabIndex = 187;
            this.txtCodCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodCli_KeyDown);
            // 
            // txtFun
            // 
            this.txtFun.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "codFun", true));
            this.txtFun.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFun.Location = new System.Drawing.Point(773, 526);
            this.txtFun.Margin = new System.Windows.Forms.Padding(4);
            this.txtFun.Name = "txtFun";
            this.txtFun.Size = new System.Drawing.Size(65, 30);
            this.txtFun.TabIndex = 218;
            // 
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Obs", true));
            this.txtObs.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(222, 477);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(783, 30);
            this.txtObs.TabIndex = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(515, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 217;
            this.label8.Text = "Altura";
            // 
            // txtAl
            // 
            this.txtAl.Enabled = false;
            this.txtAl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAl.Location = new System.Drawing.Point(485, 224);
            this.txtAl.Margin = new System.Windows.Forms.Padding(4);
            this.txtAl.Name = "txtAl";
            this.txtAl.Size = new System.Drawing.Size(131, 30);
            this.txtAl.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(886, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 216;
            this.label1.Text = "Preço Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(789, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 215;
            this.label6.Text = "Qtde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(647, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 214;
            this.label5.Text = "Largura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(323, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 213;
            this.label4.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(181, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 212;
            this.label3.Text = "Cod";
            // 
            // txtPreU
            // 
            this.txtPreU.Enabled = false;
            this.txtPreU.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreU.Location = new System.Drawing.Point(877, 224);
            this.txtPreU.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreU.Name = "txtPreU";
            this.txtPreU.Size = new System.Drawing.Size(128, 30);
            this.txtPreU.TabIndex = 211;
            // 
            // txtQtde
            // 
            this.txtQtde.Enabled = false;
            this.txtQtde.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(765, 224);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(103, 30);
            this.txtQtde.TabIndex = 199;
            this.txtQtde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtde_KeyDown);
            // 
            // txtLa
            // 
            this.txtLa.Enabled = false;
            this.txtLa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLa.Location = new System.Drawing.Point(625, 224);
            this.txtLa.Margin = new System.Windows.Forms.Padding(4);
            this.txtLa.Name = "txtLa";
            this.txtLa.Size = new System.Drawing.Size(131, 30);
            this.txtLa.TabIndex = 197;
            // 
            // txtDProd
            // 
            this.txtDProd.Enabled = false;
            this.txtDProd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDProd.Location = new System.Drawing.Point(253, 224);
            this.txtDProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDProd.Name = "txtDProd";
            this.txtDProd.Size = new System.Drawing.Size(223, 30);
            this.txtDProd.TabIndex = 195;
            this.txtDProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDProd_KeyDown);
            // 
            // txtCodP
            // 
            this.txtCodP.Enabled = false;
            this.txtCodP.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodP.Location = new System.Drawing.Point(163, 224);
            this.txtCodP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodP.Name = "txtCodP";
            this.txtCodP.Size = new System.Drawing.Size(80, 30);
            this.txtCodP.TabIndex = 193;
            this.txtCodP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodP_KeyDown);
            // 
            // itens_subtDataGridView
            // 
            this.itens_subtDataGridView.AutoGenerateColumns = false;
            this.itens_subtDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itens_subtDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.itens_subtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itens_subtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seq,
            this.codVendDataGridViewTextBoxColumn,
            this.codProdDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.larguraDataGridViewTextBoxColumn,
            this.qtdeDataGridViewTextBoxColumn,
            this.metragemDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.itens_subtDataGridView.DataSource = this.itensBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itens_subtDataGridView.DefaultCellStyle = dataGridViewCellStyle20;
            this.itens_subtDataGridView.Enabled = false;
            this.itens_subtDataGridView.Location = new System.Drawing.Point(163, 263);
            this.itens_subtDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.itens_subtDataGridView.Name = "itens_subtDataGridView";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itens_subtDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.itens_subtDataGridView.Size = new System.Drawing.Size(843, 188);
            this.itens_subtDataGridView.TabIndex = 209;
            // 
            // seq
            // 
            this.seq.DataPropertyName = "seq";
            this.seq.HeaderText = "seq";
            this.seq.Name = "seq";
            this.seq.Visible = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdicionar.Location = new System.Drawing.Point(899, 526);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 33);
            this.btnAdicionar.TabIndex = 207;
            this.btnAdicionar.Text = "Salvar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dt_date
            // 
            this.dt_date.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendasBindingSource, "data", true));
            this.dt_date.Enabled = false;
            this.dt_date.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_date.Location = new System.Drawing.Point(527, 142);
            this.dt_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(477, 30);
            this.dt_date.TabIndex = 192;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(447, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 194;
            this.label2.Text = "Nome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(159, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 191;
            this.label9.Text = "Codigo Cli";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1165, 34);
            this.panel5.TabIndex = 186;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(0, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 32);
            this.btnClose.TabIndex = 130;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label7.Location = new System.Drawing.Point(64, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 95;
            this.label7.Text = "Inserir Venda";
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dataSet1;
            // 
            // codVendDataGridViewTextBoxColumn
            // 
            this.codVendDataGridViewTextBoxColumn.DataPropertyName = "codVend";
            this.codVendDataGridViewTextBoxColumn.HeaderText = "codVend";
            this.codVendDataGridViewTextBoxColumn.Name = "codVendDataGridViewTextBoxColumn";
            // 
            // codProdDataGridViewTextBoxColumn
            // 
            this.codProdDataGridViewTextBoxColumn.DataPropertyName = "codProd";
            this.codProdDataGridViewTextBoxColumn.HeaderText = "codProd";
            this.codProdDataGridViewTextBoxColumn.Name = "codProdDataGridViewTextBoxColumn";
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            // 
            // larguraDataGridViewTextBoxColumn
            // 
            this.larguraDataGridViewTextBoxColumn.DataPropertyName = "largura";
            this.larguraDataGridViewTextBoxColumn.HeaderText = "largura";
            this.larguraDataGridViewTextBoxColumn.Name = "larguraDataGridViewTextBoxColumn";
            // 
            // qtdeDataGridViewTextBoxColumn
            // 
            this.qtdeDataGridViewTextBoxColumn.DataPropertyName = "qtde";
            this.qtdeDataGridViewTextBoxColumn.HeaderText = "qtde";
            this.qtdeDataGridViewTextBoxColumn.Name = "qtdeDataGridViewTextBoxColumn";
            // 
            // metragemDataGridViewTextBoxColumn
            // 
            this.metragemDataGridViewTextBoxColumn.DataPropertyName = "metragem";
            this.metragemDataGridViewTextBoxColumn.HeaderText = "metragem";
            this.metragemDataGridViewTextBoxColumn.Name = "metragemDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // itensBindingSource
            // 
            this.itensBindingSource.DataMember = "itens";
            this.itensBindingSource.DataSource = this.dataSet1;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // itensTableAdapter
            // 
            this.itensTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.condpgTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.itensTableAdapter = this.itensTableAdapter;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VidracariaNovo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = this.vendasTableAdapter;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.dataSet1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendasBindingSource, "codPG", true));
            this.descricaoComboBox.DataSource = this.condpgBindingSource;
            this.descricaoComboBox.DisplayMember = "descricao";
            this.descricaoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoComboBox.FormattingEnabled = true;
            this.descricaoComboBox.Location = new System.Drawing.Point(222, 524);
            this.descricaoComboBox.Name = "descricaoComboBox";
            this.descricaoComboBox.Size = new System.Drawing.Size(145, 36);
            this.descricaoComboBox.TabIndex = 221;
            this.descricaoComboBox.ValueMember = "cod";
            // 
            // condpgTableAdapter
            // 
            this.condpgTableAdapter.ClearBeforeFill = true;
            // 
            // condpgBindingSource
            // 
            this.condpgBindingSource.DataMember = "condpg";
            this.condpgBindingSource.DataSource = this.dataSet1;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVendas";
            this.Text = "frmVendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itens_subtDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condpgBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCodV;
        public System.Windows.Forms.TextBox txtNomeC;
        public System.Windows.Forms.TextBox txtCodCli;
        public System.Windows.Forms.TextBox txtFun;
        public System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPreU;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtLa;
        public System.Windows.Forms.TextBox txtDProd;
        public System.Windows.Forms.TextBox txtCodP;
        private System.Windows.Forms.DataGridView itens_subtDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn seq;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.vendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private DataSet1TableAdapters.itensTableAdapter itensTableAdapter;
        private System.Windows.Forms.BindingSource itensBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn larguraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metragemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private DataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSet1TableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.BindingSource condpgBindingSource;
        private DataSet1TableAdapters.condpgTableAdapter condpgTableAdapter;
    }
}