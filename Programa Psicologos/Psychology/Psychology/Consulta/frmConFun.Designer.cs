namespace Psychology
{
    partial class frmConFun
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label qndoPsLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cbBuscTri = new System.Windows.Forms.ComboBox();
            this.funcionariosTableAdapter = new Psychology.PsiEasyTableAdapters.funcionariosTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            label1 = new System.Windows.Forms.Label();
            qndoPsLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(8, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 21);
            label1.TabIndex = 107;
            label1.Text = "Busque por:";
            // 
            // qndoPsLabel
            // 
            qndoPsLabel.AutoSize = true;
            qndoPsLabel.BackColor = System.Drawing.Color.Transparent;
            qndoPsLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic);
            qndoPsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            qndoPsLabel.Location = new System.Drawing.Point(8, 31);
            qndoPsLabel.Name = "qndoPsLabel";
            qndoPsLabel.Size = new System.Drawing.Size(214, 23);
            qndoPsLabel.TabIndex = 104;
            qndoPsLabel.Text = "Selecione o Funcionário";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 30);
            this.panel3.TabIndex = 103;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(677, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(48, 28);
            this.btnFechar.TabIndex = 131;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(290, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 23);
            this.label4.TabIndex = 95;
            this.label4.Text = "Consulta Funcionário";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AllowUserToResizeRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.celDataGridViewTextBoxColumn,
            this.funcaoDataGridViewTextBoxColumn,
            this.fGTSDataGridViewTextBoxColumn});
            this.clienteDataGridView.DataSource = this.funcionariosBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clienteDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.clienteDataGridView.Location = new System.Drawing.Point(8, 107);
            this.clienteDataGridView.MultiSelect = false;
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.RowHeadersVisible = false;
            this.clienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDataGridView.Size = new System.Drawing.Size(704, 345);
            this.clienteDataGridView.TabIndex = 108;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celDataGridViewTextBoxColumn
            // 
            this.celDataGridViewTextBoxColumn.DataPropertyName = "cel";
            this.celDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celDataGridViewTextBoxColumn.Name = "celDataGridViewTextBoxColumn";
            this.celDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcaoDataGridViewTextBoxColumn
            // 
            this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "funcao";
            this.funcaoDataGridViewTextBoxColumn.HeaderText = "Função";
            this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
            this.funcaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fGTSDataGridViewTextBoxColumn
            // 
            this.fGTSDataGridViewTextBoxColumn.DataPropertyName = "FGTS";
            this.fGTSDataGridViewTextBoxColumn.HeaderText = "FGTS";
            this.fGTSDataGridViewTextBoxColumn.Name = "fGTSDataGridViewTextBoxColumn";
            this.fGTSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.psiEasy;
            // 
            // psiEasy
            // 
            this.psiEasy.DataSetName = "PsiEasy";
            this.psiEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbBusca
            // 
            this.cbBusca.BackColor = System.Drawing.SystemColors.Window;
            this.cbBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusca.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Prontuario",
            "Nome",
            "Endereço",
            "Numero",
            "CPF",
            "Cod Psicologo"});
            this.cbBusca.Location = new System.Drawing.Point(114, 69);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(121, 26);
            this.cbBusca.TabIndex = 106;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBusca.Location = new System.Drawing.Point(250, 69);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(462, 29);
            this.txtBusca.TabIndex = 105;
            // 
            // cbBuscTri
            // 
            this.cbBuscTri.BackColor = System.Drawing.SystemColors.Window;
            this.cbBuscTri.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscTri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbBuscTri.FormattingEnabled = true;
            this.cbBuscTri.Items.AddRange(new object[] {
            "Prontuario",
            "Nome",
            "CPF"});
            this.cbBuscTri.Location = new System.Drawing.Point(114, 69);
            this.cbBuscTri.Name = "cbBuscTri";
            this.cbBuscTri.Size = new System.Drawing.Size(121, 26);
            this.cbBuscTri.TabIndex = 109;
            this.cbBuscTri.Visible = false;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acespTableAdapter = null;
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.caixaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.irmaoTableAdapter = null;
            this.tableAdapterManager.medicamentosTableAdapter = null;
            this.tableAdapterManager.psicologosTableAdapter = null;
            this.tableAdapterManager.sessoesTableAdapter = null;
            this.tableAdapterManager.triagemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Psychology.PsiEasyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // frmConFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 464);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(qndoPsLabel);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.cbBuscTri);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConFun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConFun";
            this.Load += new System.EventHandler(this.frmConFun_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.ComboBox cbBusca;
        public System.Windows.Forms.TextBox txtBusca;
        public System.Windows.Forms.ComboBox cbBuscTri;
        private PsiEasy psiEasy;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private PsiEasyTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGTSDataGridViewTextBoxColumn;
    }
}