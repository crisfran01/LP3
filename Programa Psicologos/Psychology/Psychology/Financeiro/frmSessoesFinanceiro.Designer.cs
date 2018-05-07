namespace Psychology
{
    partial class frmSessoesFinanceiro
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label prontLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessoesFinanceiro));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewerRecibo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImpr = new System.Windows.Forms.Button();
            this.txtNSes = new System.Windows.Forms.TextBox();
            this.psicologosDataGridView = new System.Windows.Forms.DataGridView();
            this.prontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessoes_cliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPront = new System.Windows.Forms.TextBox();
            this.mktxtTotal = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFecharImpre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessoesTableAdapter = new Psychology.PsiEasyTableAdapters.sessoesTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Psychology.PsiEasyTableAdapters.clienteTableAdapter();
            this.sessoes_cliTableAdapter = new Psychology.PsiEasyTableAdapters.sessoes_cliTableAdapter();
            this.caixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caixaTableAdapter = new Psychology.PsiEasyTableAdapters.caixaTableAdapter();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            prontLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psicologosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoes_cliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(323, 384);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(127, 24);
            label5.TabIndex = 92;
            label5.Text = "Debito Total:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(19, 384);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(243, 24);
            label3.TabIndex = 90;
            label3.Text = "Nº De Sessões em Aberto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(16, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 24);
            label2.TabIndex = 89;
            label2.Text = "Busca:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nomeLabel.Location = new System.Drawing.Point(222, 32);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(70, 24);
            nomeLabel.TabIndex = 86;
            nomeLabel.Text = "Nome:";
            // 
            // prontLabel
            // 
            prontLabel.AutoSize = true;
            prontLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prontLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            prontLabel.Location = new System.Drawing.Point(16, 32);
            prontLabel.Name = "prontLabel";
            prontLabel.Size = new System.Drawing.Size(113, 24);
            prontLabel.TabIndex = 84;
            prontLabel.Text = "Prontuario:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.reportViewerRecibo);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.btnImpr);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(this.txtNSes);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.psicologosDataGridView);
            this.panel2.Controls.Add(nomeLabel);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(prontLabel);
            this.panel2.Controls.Add(this.txtPront);
            this.panel2.Controls.Add(this.mktxtTotal);
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 432);
            this.panel2.TabIndex = 134;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(600, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 197;
            this.button2.Text = "Recibo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnImpr_Click);
            // 
            // reportViewerRecibo
            // 
            this.reportViewerRecibo.LocalReport.ReportEmbeddedResource = "Psychology.ReportRecibo.rdlc";
            this.reportViewerRecibo.Location = new System.Drawing.Point(19, 21);
            this.reportViewerRecibo.Name = "reportViewerRecibo";
            this.reportViewerRecibo.ShowBackButton = false;
            this.reportViewerRecibo.ShowFindControls = false;
            this.reportViewerRecibo.ShowPageNavigationControls = false;
            this.reportViewerRecibo.ShowStopButton = false;
            this.reportViewerRecibo.Size = new System.Drawing.Size(708, 350);
            this.reportViewerRecibo.TabIndex = 196;
            this.reportViewerRecibo.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTotal.Location = new System.Drawing.Point(452, 384);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(72, 23);
            this.txtTotal.TabIndex = 129;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.BackgroundImage = global::Psychology.Properties.Resources.Search_32;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(174, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 29);
            this.btnBuscar.TabIndex = 128;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImpr
            // 
            this.btnImpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpr.BackColor = System.Drawing.Color.Transparent;
            this.btnImpr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImpr.BackgroundImage")));
            this.btnImpr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImpr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImpr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImpr.Location = new System.Drawing.Point(563, 378);
            this.btnImpr.Margin = new System.Windows.Forms.Padding(4);
            this.btnImpr.Name = "btnImpr";
            this.btnImpr.Size = new System.Drawing.Size(37, 32);
            this.btnImpr.TabIndex = 94;
            this.btnImpr.UseVisualStyleBackColor = false;
            this.btnImpr.Click += new System.EventHandler(this.btnImpr_Click);
            // 
            // txtNSes
            // 
            this.txtNSes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNSes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtNSes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNSes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSes.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNSes.Location = new System.Drawing.Point(213, 380);
            this.txtNSes.Margin = new System.Windows.Forms.Padding(0);
            this.txtNSes.Name = "txtNSes";
            this.txtNSes.Size = new System.Drawing.Size(100, 30);
            this.txtNSes.TabIndex = 91;
            // 
            // psicologosDataGridView
            // 
            this.psicologosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.psicologosDataGridView.AutoGenerateColumns = false;
            this.psicologosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.psicologosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.psicologosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prontDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.codPDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.datDataGridViewTextBoxColumn,
            this.numSDataGridViewTextBoxColumn,
            this.resumoDataGridViewTextBoxColumn,
            this.pgDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.psicologosDataGridView.DataSource = this.sessoes_cliBindingSource;
            this.psicologosDataGridView.Location = new System.Drawing.Point(19, 72);
            this.psicologosDataGridView.MultiSelect = false;
            this.psicologosDataGridView.Name = "psicologosDataGridView";
            this.psicologosDataGridView.ReadOnly = true;
            this.psicologosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.psicologosDataGridView.Size = new System.Drawing.Size(708, 285);
            this.psicologosDataGridView.TabIndex = 88;
            this.psicologosDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.psicologosDataGridView_KeyDown);
            // 
            // prontDataGridViewTextBoxColumn
            // 
            this.prontDataGridViewTextBoxColumn.DataPropertyName = "pront";
            this.prontDataGridViewTextBoxColumn.HeaderText = "Prontuario";
            this.prontDataGridViewTextBoxColumn.Name = "prontDataGridViewTextBoxColumn";
            this.prontDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codPDataGridViewTextBoxColumn
            // 
            this.codPDataGridViewTextBoxColumn.DataPropertyName = "codP";
            this.codPDataGridViewTextBoxColumn.HeaderText = "Cod Psi";
            this.codPDataGridViewTextBoxColumn.Name = "codPDataGridViewTextBoxColumn";
            this.codPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datDataGridViewTextBoxColumn
            // 
            this.datDataGridViewTextBoxColumn.DataPropertyName = "dat";
            this.datDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datDataGridViewTextBoxColumn.Name = "datDataGridViewTextBoxColumn";
            this.datDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numSDataGridViewTextBoxColumn
            // 
            this.numSDataGridViewTextBoxColumn.DataPropertyName = "numS";
            this.numSDataGridViewTextBoxColumn.HeaderText = "numS";
            this.numSDataGridViewTextBoxColumn.Name = "numSDataGridViewTextBoxColumn";
            this.numSDataGridViewTextBoxColumn.ReadOnly = true;
            this.numSDataGridViewTextBoxColumn.Visible = false;
            // 
            // resumoDataGridViewTextBoxColumn
            // 
            this.resumoDataGridViewTextBoxColumn.DataPropertyName = "resumo";
            this.resumoDataGridViewTextBoxColumn.HeaderText = "resumo";
            this.resumoDataGridViewTextBoxColumn.Name = "resumoDataGridViewTextBoxColumn";
            this.resumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.resumoDataGridViewTextBoxColumn.Visible = false;
            // 
            // pgDataGridViewTextBoxColumn
            // 
            this.pgDataGridViewTextBoxColumn.DataPropertyName = "pg";
            this.pgDataGridViewTextBoxColumn.HeaderText = "Pagamento";
            this.pgDataGridViewTextBoxColumn.Name = "pgDataGridViewTextBoxColumn";
            this.pgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessoes_cliBindingSource
            // 
            this.sessoes_cliBindingSource.DataMember = "sessoes_cli";
            this.sessoes_cliBindingSource.DataSource = this.psiEasy;
            // 
            // psiEasy
            // 
            this.psiEasy.DataSetName = "PsiEasy";
            this.psiEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessoes_cliBindingSource, "nome", true));
            this.txtNome.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtNome.Location = new System.Drawing.Point(284, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(443, 30);
            this.txtNome.TabIndex = 87;
            // 
            // txtPront
            // 
            this.txtPront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtPront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPront.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessoes_cliBindingSource, "pront", true));
            this.txtPront.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPront.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtPront.Location = new System.Drawing.Point(107, 28);
            this.txtPront.Margin = new System.Windows.Forms.Padding(0);
            this.txtPront.Name = "txtPront";
            this.txtPront.Size = new System.Drawing.Size(57, 30);
            this.txtPront.TabIndex = 85;
            this.txtPront.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPront_KeyDown);
            // 
            // mktxtTotal
            // 
            this.mktxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mktxtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mktxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mktxtTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.mktxtTotal.Location = new System.Drawing.Point(425, 380);
            this.mktxtTotal.Mask = "$";
            this.mktxtTotal.Name = "mktxtTotal";
            this.mktxtTotal.Size = new System.Drawing.Size(100, 30);
            this.mktxtTotal.TabIndex = 195;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFecharImpre);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 26);
            this.panel1.TabIndex = 135;
            // 
            // btnFecharImpre
            // 
            this.btnFecharImpre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharImpre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharImpre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharImpre.ForeColor = System.Drawing.Color.Azure;
            this.btnFecharImpre.Image = global::Psychology.Properties.Resources.Cancel_241;
            this.btnFecharImpre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharImpre.Location = new System.Drawing.Point(594, 0);
            this.btnFecharImpre.Name = "btnFecharImpre";
            this.btnFecharImpre.Size = new System.Drawing.Size(150, 23);
            this.btnFecharImpre.TabIndex = 132;
            this.btnFecharImpre.Text = "Fechar Impressão";
            this.btnFecharImpre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFecharImpre.UseVisualStyleBackColor = true;
            this.btnFecharImpre.Visible = false;
            this.btnFecharImpre.Click += new System.EventHandler(this.btnFecharImpre_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Psychology.Properties.Resources.Left_Filled_24;
            this.button1.Location = new System.Drawing.Point(5, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 26);
            this.button1.TabIndex = 130;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(44, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 95;
            this.label1.Text = "Sessões";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.psiEasy;
            // 
            // sessoesBindingSource
            // 
            this.sessoesBindingSource.DataMember = "sessoes";
            this.sessoesBindingSource.DataSource = this.psiEasy;
            // 
            // sessoesTableAdapter
            // 
            this.sessoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acespTableAdapter = null;
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.caixaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.irmaoTableAdapter = null;
            this.tableAdapterManager.medicamentosTableAdapter = null;
            this.tableAdapterManager.psicologosTableAdapter = null;
            this.tableAdapterManager.sessoesTableAdapter = this.sessoesTableAdapter;
            this.tableAdapterManager.triagemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Psychology.PsiEasyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // sessoes_cliTableAdapter
            // 
            this.sessoes_cliTableAdapter.ClearBeforeFill = true;
            // 
            // caixaBindingSource
            // 
            this.caixaBindingSource.DataMember = "caixa";
            this.caixaBindingSource.DataSource = this.psiEasy;
            // 
            // caixaTableAdapter
            // 
            this.caixaTableAdapter.ClearBeforeFill = true;
            // 
            // frmSessoesFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSessoesFinanceiro";
            this.Text = "frmConSes";
            this.Load += new System.EventHandler(this.frmConSes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psicologosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoes_cliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImpr;
        private System.Windows.Forms.TextBox txtNSes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public PsiEasy psiEasy;
        public System.Windows.Forms.BindingSource sessoesBindingSource;
        public PsiEasyTableAdapters.sessoesTableAdapter sessoesTableAdapter;
        public PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        public PsiEasyTableAdapters.clienteTableAdapter clienteTableAdapter;
        public System.Windows.Forms.BindingSource clienteBindingSource;
        public System.Windows.Forms.BindingSource sessoes_cliBindingSource;
        public PsiEasyTableAdapters.sessoes_cliTableAdapter sessoes_cliTableAdapter;
        public System.Windows.Forms.TextBox txtPront;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource caixaBindingSource;
        private PsiEasyTableAdapters.caixaTableAdapter caixaTableAdapter;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView psicologosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn prontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox mktxtTotal;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRecibo;
        private System.Windows.Forms.Button btnFecharImpre;
        private System.Windows.Forms.Button button2;
    }
}