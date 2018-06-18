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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.item_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VidracariaNovo.DataSet1();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabCImpre = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbFun = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vidracariaDataSet = new VidracariaNovo.vidracariaDataSet();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.condpgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImp = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCodV = new System.Windows.Forms.TextBox();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreU = new System.Windows.Forms.TextBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtLa = new System.Windows.Forms.TextBox();
            this.txtDProd = new System.Windows.Forms.TextBox();
            this.txtCodP = new System.Windows.Forms.TextBox();
            this.itens_subtDataGridView = new System.Windows.Forms.DataGridView();
            this.seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.larguraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.itensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new VidracariaNovo.DataSet1TableAdapters.vendasTableAdapter();
            this.itensTableAdapter = new VidracariaNovo.DataSet1TableAdapters.itensTableAdapter();
            this.tableAdapterManager = new VidracariaNovo.DataSet1TableAdapters.TableAdapterManager();
            this.produtosTableAdapter = new VidracariaNovo.DataSet1TableAdapters.produtosTableAdapter();
            this.clientesTableAdapter = new VidracariaNovo.DataSet1TableAdapters.clientesTableAdapter();
            this.condpgTableAdapter = new VidracariaNovo.DataSet1TableAdapters.condpgTableAdapter();
            this.item_produtoTableAdapter = new VidracariaNovo.DataSet1TableAdapters.item_produtoTableAdapter();
            this.usuariosTableAdapter = new VidracariaNovo.vidracariaDataSetTableAdapters.usuariosTableAdapter();
            label10 = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codPGLabel = new System.Windows.Forms.Label();
            codFunLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            codLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.item_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabCImpre.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidracariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condpgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_subtDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(345, 531);
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
            valorLabel.Location = new System.Drawing.Point(536, 531);
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
            codFunLabel.Location = new System.Drawing.Point(680, 530);
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
            // item_produtoBindingSource
            // 
            this.item_produtoBindingSource.DataMember = "item_produto";
            this.item_produtoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.dataSet1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.tabCImpre);
            this.panel1.Controls.Add(this.cbFun);
            this.panel1.Controls.Add(this.descricaoComboBox);
            this.panel1.Controls.Add(this.btnImp);
            this.panel1.Controls.Add(label10);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.txtCodV);
            this.panel1.Controls.Add(this.txtNomeC);
            this.panel1.Controls.Add(this.txtCodCli);
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
            // tabCImpre
            // 
            this.tabCImpre.Controls.Add(this.tabPage1);
            this.tabCImpre.Controls.Add(this.tabPage2);
            this.tabCImpre.Location = new System.Drawing.Point(302, 41);
            this.tabCImpre.Name = "tabCImpre";
            this.tabCImpre.SelectedIndex = 0;
            this.tabCImpre.Size = new System.Drawing.Size(433, 456);
            this.tabCImpre.TabIndex = 225;
            this.tabCImpre.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.item_produtoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.vendasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VidracariaNovo.repOrdS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(419, 421);
            this.reportViewer1.TabIndex = 224;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbFun
            // 
            this.cbFun.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendasBindingSource, "codFun", true));
            this.cbFun.DataSource = this.usuariosBindingSource;
            this.cbFun.DisplayMember = "nome";
            this.cbFun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFun.FormattingEnabled = true;
            this.cbFun.Location = new System.Drawing.Point(736, 526);
            this.cbFun.Name = "cbFun";
            this.cbFun.Size = new System.Drawing.Size(167, 36);
            this.cbFun.TabIndex = 223;
            this.cbFun.ValueMember = "cod";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.vidracariaDataSet;
            // 
            // vidracariaDataSet
            // 
            this.vidracariaDataSet.DataSetName = "vidracariaDataSet";
            this.vidracariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.descricaoComboBox.Size = new System.Drawing.Size(114, 36);
            this.descricaoComboBox.TabIndex = 221;
            this.descricaoComboBox.ValueMember = "cod";
            // 
            // condpgBindingSource
            // 
            this.condpgBindingSource.DataMember = "condpg";
            this.condpgBindingSource.DataSource = this.dataSet1;
            // 
            // btnImp
            // 
            this.btnImp.BackColor = System.Drawing.Color.Transparent;
            this.btnImp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp.ForeColor = System.Drawing.Color.Indigo;
            this.btnImp.Location = new System.Drawing.Point(924, 527);
            this.btnImp.Margin = new System.Windows.Forms.Padding(4);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(44, 33);
            this.btnImp.TabIndex = 205;
            this.btnImp.UseVisualStyleBackColor = false;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(456, 526);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(75, 30);
            this.txtDesc.TabIndex = 204;
            this.txtDesc.Text = "0";
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            this.txtDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesc_KeyDown);
            this.txtDesc.Leave += new System.EventHandler(this.txtDesc_Leave);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Valor", true));
            this.lblTotal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(598, 531);
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
            this.txtNomeC.Size = new System.Drawing.Size(556, 30);
            this.txtNomeC.TabIndex = 189;
            this.txtNomeC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeC_KeyDown);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dataSet1;
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
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Obs", true));
            this.txtObs.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(222, 477);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(861, 30);
            this.txtObs.TabIndex = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(593, 199);
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
            this.txtAl.Location = new System.Drawing.Point(563, 225);
            this.txtAl.Margin = new System.Windows.Forms.Padding(4);
            this.txtAl.Name = "txtAl";
            this.txtAl.Size = new System.Drawing.Size(131, 30);
            this.txtAl.TabIndex = 196;
            this.txtAl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAl_KeyDown);
            this.txtAl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAl_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(964, 199);
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
            this.label6.Location = new System.Drawing.Point(867, 199);
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
            this.label5.Location = new System.Drawing.Point(725, 199);
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
            this.txtPreU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "pr_venda", true));
            this.txtPreU.Enabled = false;
            this.txtPreU.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreU.Location = new System.Drawing.Point(955, 225);
            this.txtPreU.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreU.Name = "txtPreU";
            this.txtPreU.Size = new System.Drawing.Size(128, 30);
            this.txtPreU.TabIndex = 211;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.dataSet1;
            // 
            // txtQtde
            // 
            this.txtQtde.Enabled = false;
            this.txtQtde.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(843, 225);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(103, 30);
            this.txtQtde.TabIndex = 199;
            this.txtQtde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtde_KeyDown);
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAl_KeyPress);
            // 
            // txtLa
            // 
            this.txtLa.Enabled = false;
            this.txtLa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLa.Location = new System.Drawing.Point(703, 225);
            this.txtLa.Margin = new System.Windows.Forms.Padding(4);
            this.txtLa.Name = "txtLa";
            this.txtLa.Size = new System.Drawing.Size(131, 30);
            this.txtLa.TabIndex = 197;
            this.txtLa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLa_KeyDown);
            this.txtLa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAl_KeyPress);
            // 
            // txtDProd
            // 
            this.txtDProd.Enabled = false;
            this.txtDProd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDProd.Location = new System.Drawing.Point(253, 224);
            this.txtDProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDProd.Name = "txtDProd";
            this.txtDProd.Size = new System.Drawing.Size(302, 30);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itens_subtDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itens_subtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itens_subtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seq,
            this.codVendDataGridViewTextBoxColumn,
            this.codProdDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.larguraDataGridViewTextBoxColumn,
            this.qtdeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.pr_venda});
            this.itens_subtDataGridView.DataSource = this.item_produtoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itens_subtDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.itens_subtDataGridView.Enabled = false;
            this.itens_subtDataGridView.Location = new System.Drawing.Point(163, 263);
            this.itens_subtDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.itens_subtDataGridView.Name = "itens_subtDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itens_subtDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.itens_subtDataGridView.Size = new System.Drawing.Size(920, 188);
            this.itens_subtDataGridView.TabIndex = 209;
            this.itens_subtDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.itens_subtDataGridView_CellEndEdit);
            this.itens_subtDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itens_subtDataGridView_KeyDown);
            // 
            // seq
            // 
            this.seq.DataPropertyName = "seq";
            this.seq.HeaderText = "seq";
            this.seq.Name = "seq";
            this.seq.Visible = false;
            // 
            // codVendDataGridViewTextBoxColumn
            // 
            this.codVendDataGridViewTextBoxColumn.DataPropertyName = "codVend";
            this.codVendDataGridViewTextBoxColumn.HeaderText = "codVend";
            this.codVendDataGridViewTextBoxColumn.Name = "codVendDataGridViewTextBoxColumn";
            this.codVendDataGridViewTextBoxColumn.ReadOnly = true;
            this.codVendDataGridViewTextBoxColumn.Visible = false;
            // 
            // codProdDataGridViewTextBoxColumn
            // 
            this.codProdDataGridViewTextBoxColumn.DataPropertyName = "codProd";
            this.codProdDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codProdDataGridViewTextBoxColumn.Name = "codProdDataGridViewTextBoxColumn";
            this.codProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "Altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            // 
            // larguraDataGridViewTextBoxColumn
            // 
            this.larguraDataGridViewTextBoxColumn.DataPropertyName = "largura";
            this.larguraDataGridViewTextBoxColumn.HeaderText = "Largura";
            this.larguraDataGridViewTextBoxColumn.Name = "larguraDataGridViewTextBoxColumn";
            // 
            // qtdeDataGridViewTextBoxColumn
            // 
            this.qtdeDataGridViewTextBoxColumn.DataPropertyName = "qtde";
            this.qtdeDataGridViewTextBoxColumn.HeaderText = "QTDE";
            this.qtdeDataGridViewTextBoxColumn.Name = "qtdeDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "seq";
            this.dataGridViewTextBoxColumn1.HeaderText = "seq";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // pr_venda
            // 
            this.pr_venda.DataPropertyName = "pr_venda";
            this.pr_venda.HeaderText = "pr_venda";
            this.pr_venda.Name = "pr_venda";
            this.pr_venda.Visible = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdicionar.Location = new System.Drawing.Point(976, 526);
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
            this.dt_date.Size = new System.Drawing.Size(556, 30);
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
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // condpgTableAdapter
            // 
            this.condpgTableAdapter.ClearBeforeFill = true;
            // 
            // item_produtoTableAdapter
            // 
            this.item_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.item_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCImpre.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidracariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condpgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_subtDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.vendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private DataSet1TableAdapters.itensTableAdapter itensTableAdapter;
        private System.Windows.Forms.BindingSource itensBindingSource;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private DataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSet1TableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.BindingSource condpgBindingSource;
        private DataSet1TableAdapters.condpgTableAdapter condpgTableAdapter;
        private System.Windows.Forms.BindingSource item_produtoBindingSource;
        private DataSet1TableAdapters.item_produtoTableAdapter item_produtoTableAdapter;
        private System.Windows.Forms.ComboBox cbFun;
        private vidracariaDataSet vidracariaDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private vidracariaDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn larguraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_venda;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl tabCImpre;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}