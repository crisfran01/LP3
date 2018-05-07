namespace Psychology
{
    partial class frmCaixa
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label label4;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.caixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportCaixa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mktTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDetalhe = new System.Windows.Forms.TextBox();
            this.caixaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImpre1 = new System.Windows.Forms.Button();
            this.dtCaixa = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFecharImpre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.caixaTableAdapter = new Psychology.PsiEasyTableAdapters.caixaTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caixaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(40, 308);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 18);
            label3.TabIndex = 90;
            label3.Text = "Retirada:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(313, 308);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 18);
            label2.TabIndex = 103;
            label2.Text = "Detalhes:";
            // 
            // dataLabel
            // 
            dataLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(289, 16);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(98, 18);
            dataLabel.TabIndex = 100;
            dataLabel.Text = "Caixa do dia:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(45, 348);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(116, 18);
            label4.TabIndex = 105;
            label4.Text = "Total em caixa:";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // caixaBindingSource
            // 
            this.caixaBindingSource.DataMember = "caixa";
            this.caixaBindingSource.DataSource = this.psiEasy;
            // 
            // psiEasy
            // 
            this.psiEasy.DataSetName = "PsiEasy";
            this.psiEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.reportCaixa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 385);
            this.panel2.TabIndex = 136;
            // 
            // reportCaixa
            // 
            this.reportCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.caixaBindingSource;
            this.reportCaixa.LocalReport.DataSources.Add(reportDataSource2);
            this.reportCaixa.LocalReport.ReportEmbeddedResource = "Psychology.reportCaixa.rdlc";
            this.reportCaixa.Location = new System.Drawing.Point(0, 0);
            this.reportCaixa.Name = "reportCaixa";
            this.reportCaixa.ShowBackButton = false;
            this.reportCaixa.ShowFindControls = false;
            this.reportCaixa.ShowPageNavigationControls = false;
            this.reportCaixa.ShowStopButton = false;
            this.reportCaixa.Size = new System.Drawing.Size(809, 383);
            this.reportCaixa.TabIndex = 112;
            this.reportCaixa.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(label4);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.txtValor);
            this.panel3.Controls.Add(this.txtDetalhe);
            this.panel3.Controls.Add(this.caixaDataGridView);
            this.panel3.Controls.Add(this.btnImpre1);
            this.panel3.Controls.Add(this.dtCaixa);
            this.panel3.Controls.Add(dataLabel);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(this.maskedTextBox1);
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Controls.Add(this.mktTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 383);
            this.panel3.TabIndex = 113;
            // 
            // mktTotal
            // 
            this.mktTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mktTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mktTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mktTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.mktTotal.Location = new System.Drawing.Point(162, 344);
            this.mktTotal.Mask = "$";
            this.mktTotal.Name = "mktTotal";
            this.mktTotal.Size = new System.Drawing.Size(110, 26);
            this.mktTotal.TabIndex = 106;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtTotal.Location = new System.Drawing.Point(193, 348);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(73, 19);
            this.txtTotal.TabIndex = 109;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtValor.Location = new System.Drawing.Point(144, 308);
            this.txtValor.Margin = new System.Windows.Forms.Padding(0);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(57, 19);
            this.txtValor.TabIndex = 111;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtDetalhe
            // 
            this.txtDetalhe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDetalhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtDetalhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalhe.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhe.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtDetalhe.Location = new System.Drawing.Point(390, 304);
            this.txtDetalhe.Margin = new System.Windows.Forms.Padding(0);
            this.txtDetalhe.Name = "txtDetalhe";
            this.txtDetalhe.Size = new System.Drawing.Size(378, 26);
            this.txtDetalhe.TabIndex = 108;
            // 
            // caixaDataGridView
            // 
            this.caixaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caixaDataGridView.AutoGenerateColumns = false;
            this.caixaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.caixaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caixaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.caixaDataGridView.DataSource = this.caixaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.caixaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.caixaDataGridView.Location = new System.Drawing.Point(43, 53);
            this.caixaDataGridView.Name = "caixaDataGridView";
            this.caixaDataGridView.Size = new System.Drawing.Size(728, 230);
            this.caixaDataGridView.TabIndex = 95;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nregistro";
            this.dataGridViewTextBoxColumn1.HeaderText = "nregistro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data";
            this.dataGridViewTextBoxColumn2.HeaderText = "data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "responsavel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Responsavel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "detalhes";
            this.dataGridViewTextBoxColumn5.HeaderText = "Detalhes";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnImpre1
            // 
            this.btnImpre1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpre1.BackColor = System.Drawing.Color.Transparent;
            this.btnImpre1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImpre1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpre1.ForeColor = System.Drawing.Color.White;
            this.btnImpre1.Image = global::Psychology.Properties.Resources._1478041001_Print_16x16;
            this.btnImpre1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpre1.Location = new System.Drawing.Point(574, 341);
            this.btnImpre1.Margin = new System.Windows.Forms.Padding(4);
            this.btnImpre1.Name = "btnImpre1";
            this.btnImpre1.Size = new System.Drawing.Size(194, 32);
            this.btnImpre1.TabIndex = 100;
            this.btnImpre1.Text = "Imprimir Relatorio";
            this.btnImpre1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpre1.UseVisualStyleBackColor = false;
            this.btnImpre1.Click += new System.EventHandler(this.btnImpre1_Click);
            // 
            // dtCaixa
            // 
            this.dtCaixa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtCaixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCaixa.Location = new System.Drawing.Point(393, 12);
            this.dtCaixa.Name = "dtCaixa";
            this.dtCaixa.Size = new System.Drawing.Size(124, 26);
            this.dtCaixa.TabIndex = 102;
            this.dtCaixa.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox1.Location = new System.Drawing.Point(120, 304);
            this.maskedTextBox1.Mask = "$";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(83, 26);
            this.maskedTextBox1.TabIndex = 110;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(222, 304);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 26);
            this.btnSalvar.TabIndex = 98;
            this.btnSalvar.Text = "Retirar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.panel1.Size = new System.Drawing.Size(811, 26);
            this.panel1.TabIndex = 137;
            // 
            // btnFecharImpre
            // 
            this.btnFecharImpre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharImpre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharImpre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharImpre.ForeColor = System.Drawing.Color.Azure;
            this.btnFecharImpre.Image = global::Psychology.Properties.Resources.Cancel_241;
            this.btnFecharImpre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharImpre.Location = new System.Drawing.Point(656, 2);
            this.btnFecharImpre.Name = "btnFecharImpre";
            this.btnFecharImpre.Size = new System.Drawing.Size(150, 23);
            this.btnFecharImpre.TabIndex = 131;
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
            this.button1.Location = new System.Drawing.Point(0, -1);
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
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 95;
            this.label1.Text = "Caixa";
            // 
            // caixaTableAdapter
            // 
            this.caixaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acespTableAdapter = null;
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.caixaTableAdapter = this.caixaTableAdapter;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.irmaoTableAdapter = null;
            this.tableAdapterManager.medicamentosTableAdapter = null;
            this.tableAdapterManager.psicologosTableAdapter = null;
            this.tableAdapterManager.sessoesTableAdapter = null;
            this.tableAdapterManager.triagemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Psychology.PsiEasyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(811, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caixaDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private PsiEasy psiEasy;
        private System.Windows.Forms.BindingSource caixaBindingSource;
        private PsiEasyTableAdapters.caixaTableAdapter caixaTableAdapter;
        private PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportCaixa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox mktTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDetalhe;
        private System.Windows.Forms.DataGridView caixaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnImpre1;
        private System.Windows.Forms.DateTimePicker dtCaixa;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFecharImpre;

    }
}