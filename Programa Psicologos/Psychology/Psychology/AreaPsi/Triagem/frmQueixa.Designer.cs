namespace Psychology
{
    partial class frmQueixa
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
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label queixaLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.queixaTextBox = new System.Windows.Forms.TextBox();
            this.triagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.triagemTableAdapter = new Psychology.PsiEasyTableAdapters.triagemTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            obsLabel = new System.Windows.Forms.Label();
            queixaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triagemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            this.SuspendLayout();
            // 
            // obsLabel
            // 
            obsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            obsLabel.AutoSize = true;
            obsLabel.BackColor = System.Drawing.Color.Transparent;
            obsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            obsLabel.ForeColor = System.Drawing.SystemColors.Control;
            obsLabel.Location = new System.Drawing.Point(249, 240);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(41, 21);
            obsLabel.TabIndex = 0;
            obsLabel.Text = "Obs:";
            // 
            // queixaLabel
            // 
            queixaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            queixaLabel.AutoSize = true;
            queixaLabel.BackColor = System.Drawing.Color.Transparent;
            queixaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            queixaLabel.ForeColor = System.Drawing.SystemColors.Control;
            queixaLabel.Location = new System.Drawing.Point(229, 36);
            queixaLabel.Name = "queixaLabel";
            queixaLabel.Size = new System.Drawing.Size(61, 21);
            queixaLabel.TabIndex = 2;
            queixaLabel.Text = "Queixa:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(queixaLabel);
            this.panel1.Controls.Add(this.queixaTextBox);
            this.panel1.Controls.Add(obsLabel);
            this.panel1.Controls.Add(this.obsTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 649);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 28);
            this.panel3.TabIndex = 176;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Psychology.Properties.Resources.Left_Filled_24;
            this.btnClose.Location = new System.Drawing.Point(0, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 26);
            this.btnClose.TabIndex = 130;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(48, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 95;
            this.label4.Text = "Queixa";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSalvar.Location = new System.Drawing.Point(468, 384);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 29);
            this.btnSalvar.TabIndex = 175;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // queixaTextBox
            // 
            this.queixaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queixaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.queixaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queixaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "queixa", true));
            this.queixaTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.queixaTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.queixaTextBox.Location = new System.Drawing.Point(296, 34);
            this.queixaTextBox.MaxLength = 300;
            this.queixaTextBox.Multiline = true;
            this.queixaTextBox.Name = "queixaTextBox";
            this.queixaTextBox.Size = new System.Drawing.Size(485, 178);
            this.queixaTextBox.TabIndex = 3;
            // 
            // triagemBindingSource
            // 
            this.triagemBindingSource.DataMember = "triagem";
            this.triagemBindingSource.DataSource = this.psiEasy;
            // 
            // psiEasy
            // 
            this.psiEasy.DataSetName = "PsiEasy";
            this.psiEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obsTextBox
            // 
            this.obsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.obsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "Obs", true));
            this.obsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.obsTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.obsTextBox.Location = new System.Drawing.Point(296, 238);
            this.obsTextBox.MaxLength = 150;
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(485, 100);
            this.obsTextBox.TabIndex = 1;
            // 
            // triagemTableAdapter
            // 
            this.triagemTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.psicologosTableAdapter = null;
            this.tableAdapterManager.sessoesTableAdapter = null;
            this.tableAdapterManager.triagemTableAdapter = this.triagemTableAdapter;
            this.tableAdapterManager.UpdateOrder = Psychology.PsiEasyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // frmQueixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 649);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQueixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQueixa";
            this.Load += new System.EventHandler(this.frmQueixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triagemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox queixaTextBox;
        private System.Windows.Forms.TextBox obsTextBox;
        public PsiEasy psiEasy;
        public System.Windows.Forms.BindingSource triagemBindingSource;
        public PsiEasyTableAdapters.triagemTableAdapter triagemTableAdapter;
        public PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
    }
}