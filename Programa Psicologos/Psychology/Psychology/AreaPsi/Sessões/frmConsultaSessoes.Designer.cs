namespace Psychology
{
    partial class frmConsultaSessoes
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label prontLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sesso_CliDataGridView = new System.Windows.Forms.DataGridView();
            this.codP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessoes_cliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.btnAddSes = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPront = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Psychology.PsiEasyTableAdapters.clienteTableAdapter();
            this.sessoesTableAdapter = new Psychology.PsiEasyTableAdapters.sessoesTableAdapter();
            this.sessoes_cliTableAdapter = new Psychology.PsiEasyTableAdapters.sessoes_cliTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefre = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            prontLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sesso_CliDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoes_cliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(19, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 24);
            label2.TabIndex = 89;
            label2.Text = "Busca:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.Color.White;
            nomeLabel.Location = new System.Drawing.Point(246, 30);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(70, 24);
            nomeLabel.TabIndex = 86;
            nomeLabel.Text = "Nome:";
            // 
            // prontLabel
            // 
            prontLabel.AutoSize = true;
            prontLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prontLabel.ForeColor = System.Drawing.Color.White;
            prontLabel.Location = new System.Drawing.Point(19, 32);
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
            this.panel2.Controls.Add(this.btnRefre);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.sesso_CliDataGridView);
            this.panel2.Controls.Add(this.btnAddSes);
            this.panel2.Controls.Add(nomeLabel);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(prontLabel);
            this.panel2.Controls.Add(this.txtPront);
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 424);
            this.panel2.TabIndex = 132;
            // 
            // sesso_CliDataGridView
            // 
            this.sesso_CliDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sesso_CliDataGridView.AutoGenerateColumns = false;
            this.sesso_CliDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.sesso_CliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sesso_CliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codP,
            this.numSDataGridViewTextBoxColumn,
            this.prontDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.datDataGridViewTextBoxColumn,
            this.resumoDataGridViewTextBoxColumn,
            this.pgDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.sesso_CliDataGridView.DataSource = this.sessoes_cliBindingSource;
            this.sesso_CliDataGridView.Location = new System.Drawing.Point(22, 75);
            this.sesso_CliDataGridView.MultiSelect = false;
            this.sesso_CliDataGridView.Name = "sesso_CliDataGridView";
            this.sesso_CliDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.sesso_CliDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sesso_CliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sesso_CliDataGridView.Size = new System.Drawing.Size(851, 285);
            this.sesso_CliDataGridView.TabIndex = 88;
            this.sesso_CliDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sesso_CliDataGridView_CellClick);
            this.sesso_CliDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.psicologosDataGridView_CellDoubleClick);
            // 
            // codP
            // 
            this.codP.DataPropertyName = "codP";
            this.codP.HeaderText = "codP";
            this.codP.Name = "codP";
            this.codP.ReadOnly = true;
            this.codP.Visible = false;
            // 
            // numSDataGridViewTextBoxColumn
            // 
            this.numSDataGridViewTextBoxColumn.DataPropertyName = "numS";
            this.numSDataGridViewTextBoxColumn.HeaderText = "Nº da Sessão";
            this.numSDataGridViewTextBoxColumn.Name = "numSDataGridViewTextBoxColumn";
            this.numSDataGridViewTextBoxColumn.ReadOnly = true;
            this.numSDataGridViewTextBoxColumn.Width = 50;
            // 
            // prontDataGridViewTextBoxColumn
            // 
            this.prontDataGridViewTextBoxColumn.DataPropertyName = "pront";
            this.prontDataGridViewTextBoxColumn.HeaderText = "Pront";
            this.prontDataGridViewTextBoxColumn.Name = "prontDataGridViewTextBoxColumn";
            this.prontDataGridViewTextBoxColumn.ReadOnly = true;
            this.prontDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 400;
            // 
            // datDataGridViewTextBoxColumn
            // 
            this.datDataGridViewTextBoxColumn.DataPropertyName = "dat";
            this.datDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datDataGridViewTextBoxColumn.Name = "datDataGridViewTextBoxColumn";
            this.datDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resumoDataGridViewTextBoxColumn
            // 
            this.resumoDataGridViewTextBoxColumn.DataPropertyName = "resumo";
            this.resumoDataGridViewTextBoxColumn.HeaderText = "Resumo";
            this.resumoDataGridViewTextBoxColumn.Name = "resumoDataGridViewTextBoxColumn";
            this.resumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.resumoDataGridViewTextBoxColumn.Width = 650;
            // 
            // pgDataGridViewTextBoxColumn
            // 
            this.pgDataGridViewTextBoxColumn.DataPropertyName = "pg";
            this.pgDataGridViewTextBoxColumn.HeaderText = "PG";
            this.pgDataGridViewTextBoxColumn.Name = "pgDataGridViewTextBoxColumn";
            this.pgDataGridViewTextBoxColumn.ReadOnly = true;
            this.pgDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Visible = false;
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
            // btnAddSes
            // 
            this.btnAddSes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSes.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSes.ForeColor = System.Drawing.Color.White;
            this.btnAddSes.Location = new System.Drawing.Point(660, 377);
            this.btnAddSes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSes.Name = "btnAddSes";
            this.btnAddSes.Size = new System.Drawing.Size(213, 32);
            this.btnAddSes.TabIndex = 88;
            this.btnAddSes.Text = "Add Sessão";
            this.btnAddSes.UseVisualStyleBackColor = false;
            this.btnAddSes.Click += new System.EventHandler(this.btnAddSes_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(319, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(443, 30);
            this.txtNome.TabIndex = 87;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtPront
            // 
            this.txtPront.BackColor = System.Drawing.SystemColors.Window;
            this.txtPront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPront.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPront.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPront.Location = new System.Drawing.Point(135, 28);
            this.txtPront.Margin = new System.Windows.Forms.Padding(0);
            this.txtPront.Name = "txtPront";
            this.txtPront.Size = new System.Drawing.Size(100, 30);
            this.txtPront.TabIndex = 85;
            this.txtPront.TextChanged += new System.EventHandler(this.txtPront_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 26);
            this.panel1.TabIndex = 133;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Psychology.Properties.Resources.Left_Filled_24;
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 26);
            this.button1.TabIndex = 130;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(51, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 95;
            this.label1.Text = "Prontuário";
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
            // sessoesTableAdapter
            // 
            this.sessoesTableAdapter.ClearBeforeFill = true;
            // 
            // sessoes_cliTableAdapter
            // 
            this.sessoes_cliTableAdapter.ClearBeforeFill = true;
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
            // btnRefre
            // 
            this.btnRefre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefre.BackColor = System.Drawing.Color.Transparent;
            this.btnRefre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefre.ForeColor = System.Drawing.Color.White;
            this.btnRefre.Location = new System.Drawing.Point(782, 26);
            this.btnRefre.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefre.Name = "btnRefre";
            this.btnRefre.Size = new System.Drawing.Size(98, 32);
            this.btnRefre.TabIndex = 90;
            this.btnRefre.Text = "Refresh";
            this.btnRefre.UseVisualStyleBackColor = false;
            this.btnRefre.Click += new System.EventHandler(this.btnRefre_Click);
            // 
            // frmConsultaSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaSessoes";
            this.Text = "frmSessoes";
            this.Load += new System.EventHandler(this.frmSessoes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sesso_CliDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoes_cliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView sesso_CliDataGridView;
        private System.Windows.Forms.Button btnAddSes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPront;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public PsiEasy psiEasy;
        public PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sessoes_cliBindingSource;
        private PsiEasyTableAdapters.sessoes_cliTableAdapter sessoes_cliTableAdapter;
        public PsiEasyTableAdapters.clienteTableAdapter clienteTableAdapter;
        public PsiEasyTableAdapters.sessoesTableAdapter sessoesTableAdapter;
        public System.Windows.Forms.BindingSource clienteBindingSource;
        public System.Windows.Forms.BindingSource sessoesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codP;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefre;
    }
}