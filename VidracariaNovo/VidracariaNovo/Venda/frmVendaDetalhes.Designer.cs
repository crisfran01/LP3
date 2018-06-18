namespace VidracariaNovo
{
    partial class frmVendaDetalhes
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
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codPGLabel;
            System.Windows.Forms.Label codFunLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label codLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VidracariaNovo.DataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnImp = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCodV = new System.Windows.Forms.TextBox();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.venda_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.itens_subtDataGridView = new System.Windows.Forms.DataGridView();
            this.codProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.larguraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.vendasTableAdapter = new VidracariaNovo.DataSet1TableAdapters.vendasTableAdapter();
            this.tableAdapterManager = new VidracariaNovo.DataSet1TableAdapters.TableAdapterManager();
            this.venda_clienteTableAdapter = new VidracariaNovo.DataSet1TableAdapters.venda_clienteTableAdapter();
            this.item_produtoTableAdapter = new VidracariaNovo.DataSet1TableAdapters.item_produtoTableAdapter();
            valorLabel = new System.Windows.Forms.Label();
            codPGLabel = new System.Windows.Forms.Label();
            codFunLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            codLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venda_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_subtDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_produtoBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.ForeColor = System.Drawing.SystemColors.Control;
            valorLabel.Location = new System.Drawing.Point(451, 528);
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
            codPGLabel.Location = new System.Drawing.Point(130, 528);
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
            codFunLabel.Location = new System.Drawing.Point(723, 528);
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
            obsLabel.Location = new System.Drawing.Point(130, 481);
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
            dataLabel.Location = new System.Drawing.Point(425, 147);
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
            codLabel.Location = new System.Drawing.Point(146, 147);
            codLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codLabel.Name = "codLabel";
            codLabel.Size = new System.Drawing.Size(66, 24);
            codLabel.TabIndex = 188;
            codLabel.Text = "Venda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnImp);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.txtCodV);
            this.panel1.Controls.Add(this.txtNomeC);
            this.panel1.Controls.Add(this.txtCodCli);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.itens_subtDataGridView);
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
            this.panel1.Size = new System.Drawing.Size(1185, 685);
            this.panel1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "codFun", true));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(806, 525);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 30);
            this.textBox2.TabIndex = 227;
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
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "codPG", true));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(190, 525);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 30);
            this.textBox1.TabIndex = 226;
            // 
            // btnImp
            // 
            this.btnImp.BackColor = System.Drawing.Color.Transparent;
            this.btnImp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp.ForeColor = System.Drawing.Color.Indigo;
            this.btnImp.Image = global::VidracariaNovo.Properties.Resources._326675_20;
            this.btnImp.Location = new System.Drawing.Point(1006, 524);
            this.btnImp.Margin = new System.Windows.Forms.Padding(4);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(44, 33);
            this.btnImp.TabIndex = 205;
            this.btnImp.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Valor", true));
            this.lblTotal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(539, 528);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 24);
            this.lblTotal.TabIndex = 219;
            this.lblTotal.Text = "0.00";
            // 
            // txtCodV
            // 
            this.txtCodV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "cod", true));
            this.txtCodV.Enabled = false;
            this.txtCodV.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodV.Location = new System.Drawing.Point(241, 142);
            this.txtCodV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodV.Name = "txtCodV";
            this.txtCodV.Size = new System.Drawing.Size(132, 30);
            this.txtCodV.TabIndex = 190;
            // 
            // txtNomeC
            // 
            this.txtNomeC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.venda_clienteBindingSource, "nome", true));
            this.txtNomeC.Enabled = false;
            this.txtNomeC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeC.Location = new System.Drawing.Point(498, 102);
            this.txtNomeC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(556, 30);
            this.txtNomeC.TabIndex = 189;
            // 
            // venda_clienteBindingSource
            // 
            this.venda_clienteBindingSource.DataMember = "venda_cliente";
            this.venda_clienteBindingSource.DataSource = this.dataSet1;
            // 
            // txtCodCli
            // 
            this.txtCodCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "codCli", true));
            this.txtCodCli.Enabled = false;
            this.txtCodCli.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCli.Location = new System.Drawing.Point(241, 102);
            this.txtCodCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(132, 30);
            this.txtCodCli.TabIndex = 187;
            // 
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Obs", true));
            this.txtObs.Enabled = false;
            this.txtObs.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(193, 477);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(861, 30);
            this.txtObs.TabIndex = 200;
            // 
            // itens_subtDataGridView
            // 
            this.itens_subtDataGridView.AllowUserToAddRows = false;
            this.itens_subtDataGridView.AllowUserToDeleteRows = false;
            this.itens_subtDataGridView.AllowUserToResizeColumns = false;
            this.itens_subtDataGridView.AllowUserToResizeRows = false;
            this.itens_subtDataGridView.AutoGenerateColumns = false;
            this.itens_subtDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itens_subtDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itens_subtDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.itens_subtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itens_subtDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.larguraDataGridViewTextBoxColumn,
            this.qtdeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.itens_subtDataGridView.DataSource = this.item_produtoBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itens_subtDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.itens_subtDataGridView.Enabled = false;
            this.itens_subtDataGridView.Location = new System.Drawing.Point(134, 207);
            this.itens_subtDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.itens_subtDataGridView.Name = "itens_subtDataGridView";
            this.itens_subtDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itens_subtDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.itens_subtDataGridView.Size = new System.Drawing.Size(920, 231);
            this.itens_subtDataGridView.TabIndex = 209;
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
            this.alturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // larguraDataGridViewTextBoxColumn
            // 
            this.larguraDataGridViewTextBoxColumn.DataPropertyName = "largura";
            this.larguraDataGridViewTextBoxColumn.HeaderText = "Largura";
            this.larguraDataGridViewTextBoxColumn.Name = "larguraDataGridViewTextBoxColumn";
            this.larguraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdeDataGridViewTextBoxColumn
            // 
            this.qtdeDataGridViewTextBoxColumn.DataPropertyName = "qtde";
            this.qtdeDataGridViewTextBoxColumn.HeaderText = "QTDE";
            this.qtdeDataGridViewTextBoxColumn.Name = "qtdeDataGridViewTextBoxColumn";
            this.qtdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // item_produtoBindingSource
            // 
            this.item_produtoBindingSource.DataMember = "item_produto";
            this.item_produtoBindingSource.DataSource = this.dataSet1;
            // 
            // dt_date
            // 
            this.dt_date.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.venda_clienteBindingSource, "data", true));
            this.dt_date.Enabled = false;
            this.dt_date.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_date.Location = new System.Drawing.Point(498, 142);
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
            this.label2.Location = new System.Drawing.Point(418, 107);
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
            this.label9.Location = new System.Drawing.Point(130, 107);
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
            this.panel5.Size = new System.Drawing.Size(1185, 34);
            this.panel5.TabIndex = 186;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::VidracariaNovo.Properties.Resources._134226_20;
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
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 95;
            this.label7.Text = "Venda";
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.condpgTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.itensTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VidracariaNovo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = this.vendasTableAdapter;
            // 
            // venda_clienteTableAdapter
            // 
            this.venda_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // item_produtoTableAdapter
            // 
            this.item_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // frmVendaDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 685);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVendaDetalhes";
            this.Text = "frmVendaDetalhes";
            this.Load += new System.EventHandler(this.frmVendaDetalhes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venda_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_subtDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_produtoBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCodV;
        public System.Windows.Forms.TextBox txtNomeC;
        public System.Windows.Forms.TextBox txtCodCli;
        public System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DataGridView itens_subtDataGridView;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private DataSet1TableAdapters.vendasTableAdapter vendasTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource venda_clienteBindingSource;
        private DataSet1TableAdapters.venda_clienteTableAdapter venda_clienteTableAdapter;
        private System.Windows.Forms.BindingSource item_produtoBindingSource;
        private DataSet1TableAdapters.item_produtoTableAdapter item_produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn larguraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
    }
}