namespace Psychology
{
    partial class frmConPsi
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label qndoPsLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.psicologosDataGridView = new System.Windows.Forms.DataGridView();
            this.codPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abordagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psicologosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.psicologosTableAdapter = new Psychology.PsiEasyTableAdapters.psicologosTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            qndoPsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psicologosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psicologosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.Control;
            label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            label2.Location = new System.Drawing.Point(230, 375);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(322, 18);
            label2.TabIndex = 19;
            label2.Text = "* Para selecionar de dois cliques ou aperte enter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(19, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 21);
            label1.TabIndex = 18;
            label1.Text = "Busque por:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(qndoPsLabel);
            this.panel1.Controls.Add(this.psicologosDataGridView);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.cbBusca);
            this.panel1.Controls.Add(this.txtBusca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 421);
            this.panel1.TabIndex = 103;
            // 
            // psicologosDataGridView
            // 
            this.psicologosDataGridView.AllowUserToAddRows = false;
            this.psicologosDataGridView.AllowUserToDeleteRows = false;
            this.psicologosDataGridView.AutoGenerateColumns = false;
            this.psicologosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.psicologosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.psicologosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.psicologosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.psicologosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.celDataGridViewTextBoxColumn,
            this.cRPDataGridViewTextBoxColumn,
            this.abordagemDataGridViewTextBoxColumn});
            this.psicologosDataGridView.DataSource = this.psicologosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.psicologosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.psicologosDataGridView.Location = new System.Drawing.Point(22, 107);
            this.psicologosDataGridView.MultiSelect = false;
            this.psicologosDataGridView.Name = "psicologosDataGridView";
            this.psicologosDataGridView.ReadOnly = true;
            this.psicologosDataGridView.RowHeadersVisible = false;
            this.psicologosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.psicologosDataGridView.Size = new System.Drawing.Size(735, 258);
            this.psicologosDataGridView.TabIndex = 19;
            this.psicologosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.psicologosDataGridView_CellDoubleClick);
            this.psicologosDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.psicologosDataGridView_KeyDown);
            // 
            // codPDataGridViewTextBoxColumn
            // 
            this.codPDataGridViewTextBoxColumn.DataPropertyName = "CodP";
            this.codPDataGridViewTextBoxColumn.HeaderText = "CodP";
            this.codPDataGridViewTextBoxColumn.Name = "codPDataGridViewTextBoxColumn";
            this.codPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "End";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celDataGridViewTextBoxColumn
            // 
            this.celDataGridViewTextBoxColumn.DataPropertyName = "cel";
            this.celDataGridViewTextBoxColumn.HeaderText = "Cel";
            this.celDataGridViewTextBoxColumn.Name = "celDataGridViewTextBoxColumn";
            this.celDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRPDataGridViewTextBoxColumn
            // 
            this.cRPDataGridViewTextBoxColumn.DataPropertyName = "CRP";
            this.cRPDataGridViewTextBoxColumn.HeaderText = "CRP";
            this.cRPDataGridViewTextBoxColumn.Name = "cRPDataGridViewTextBoxColumn";
            this.cRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abordagemDataGridViewTextBoxColumn
            // 
            this.abordagemDataGridViewTextBoxColumn.DataPropertyName = "abordagem";
            this.abordagemDataGridViewTextBoxColumn.HeaderText = "Abordagem";
            this.abordagemDataGridViewTextBoxColumn.Name = "abordagemDataGridViewTextBoxColumn";
            this.abordagemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psicologosBindingSource
            // 
            this.psicologosBindingSource.DataMember = "psicologos";
            this.psicologosBindingSource.DataSource = this.psiEasy;
            // 
            // psiEasy
            // 
            this.psiEasy.DataSetName = "PsiEasy";
            this.psiEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbBusca
            // 
            this.cbBusca.BackColor = System.Drawing.SystemColors.Control;
            this.cbBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Prontuario",
            "Nome",
            "Endereço",
            "Numero",
            "CPR",
            "Cod Psicologo",
            "Abordagem"});
            this.cbBusca.Location = new System.Drawing.Point(121, 64);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(121, 29);
            this.cbBusca.TabIndex = 17;
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.SystemColors.Control;
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBusca.Location = new System.Drawing.Point(269, 65);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(488, 29);
            this.txtBusca.TabIndex = 7;
            this.txtBusca.TextChanged += new System.EventHandler(this.qndoPsTextBox_TextChanged);
            // 
            // psicologosTableAdapter
            // 
            this.psicologosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acespTableAdapter = null;
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.caixaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.irmaoTableAdapter = null;
            this.tableAdapterManager.medicamentosTableAdapter = null;
            this.tableAdapterManager.psicologosTableAdapter = this.psicologosTableAdapter;
            this.tableAdapterManager.sessoesTableAdapter = null;
            this.tableAdapterManager.triagemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Psychology.PsiEasyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // qndoPsLabel
            // 
            qndoPsLabel.AutoSize = true;
            qndoPsLabel.BackColor = System.Drawing.Color.Transparent;
            qndoPsLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic);
            qndoPsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            qndoPsLabel.Location = new System.Drawing.Point(18, 35);
            qndoPsLabel.Name = "qndoPsLabel";
            qndoPsLabel.Size = new System.Drawing.Size(190, 23);
            qndoPsLabel.TabIndex = 105;
            qndoPsLabel.Text = "Selecione o Psicologo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 30);
            this.panel3.TabIndex = 106;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(731, 1);
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
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 95;
            this.label4.Text = "Consulta Psicologo";
            // 
            // frmConPsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 421);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConPsi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComPsi";
            this.Load += new System.EventHandler(this.frmConPsi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psicologosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psicologosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView psicologosDataGridView;
        private PsiEasy psiEasy;
        private System.Windows.Forms.BindingSource psicologosBindingSource;
        private PsiEasyTableAdapters.psicologosTableAdapter psicologosTableAdapter;
        private PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abordagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label4;

    }
}