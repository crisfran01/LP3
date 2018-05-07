namespace Psychology
{
    partial class frmSessoesInfor
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label prontLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtResu = new System.Windows.Forms.TextBox();
            this.sessoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.btnAddSes = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPront = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sessoesTableAdapter = new Psychology.PsiEasyTableAdapters.sessoesTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Psychology.PsiEasyTableAdapters.clienteTableAdapter();
            this.datDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            prontLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label6.Location = new System.Drawing.Point(22, 107);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(85, 28);
            label6.TabIndex = 95;
            label6.Text = "Resumo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label5.Location = new System.Drawing.Point(17, 249);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(100, 28);
            label5.TabIndex = 93;
            label5.Text = "Descrição:";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(223, 70);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 28);
            label3.TabIndex = 91;
            label3.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(18, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 28);
            label2.TabIndex = 89;
            label2.Text = "Nº Sessão";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nomeLabel.Location = new System.Drawing.Point(219, 27);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(70, 28);
            nomeLabel.TabIndex = 86;
            nomeLabel.Text = "Nome:";
            // 
            // prontLabel
            // 
            prontLabel.AutoSize = true;
            prontLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prontLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            prontLabel.Location = new System.Drawing.Point(13, 27);
            prontLabel.Name = "prontLabel";
            prontLabel.Size = new System.Drawing.Size(109, 28);
            prontLabel.TabIndex = 84;
            prontLabel.Text = "Prontuario:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.datDateTimePicker);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(this.txtResu);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(this.txtDescr);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.txtNS);
            this.panel2.Controls.Add(this.btnAddSes);
            this.panel2.Controls.Add(nomeLabel);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(prontLabel);
            this.panel2.Controls.Add(this.txtPront);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 547);
            this.panel2.TabIndex = 132;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSalvar.Location = new System.Drawing.Point(492, 495);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 32);
            this.btnSalvar.TabIndex = 97;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtResu
            // 
            this.txtResu.BackColor = System.Drawing.SystemColors.Window;
            this.txtResu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessoesBindingSource, "resumo", true));
            this.txtResu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtResu.Location = new System.Drawing.Point(104, 110);
            this.txtResu.Margin = new System.Windows.Forms.Padding(0);
            this.txtResu.MaxLength = 30;
            this.txtResu.Multiline = true;
            this.txtResu.Name = "txtResu";
            this.txtResu.Size = new System.Drawing.Size(620, 122);
            this.txtResu.TabIndex = 96;
            // 
            // sessoesBindingSource
            // 
            this.sessoesBindingSource.DataMember = "sessoes";
            this.sessoesBindingSource.DataSource = this.psiEasy;
            // 
            // psiEasy
            // 
            this.psiEasy.DataSetName = "PsiEasy";
            this.psiEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDescr
            // 
            this.txtDescr.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessoesBindingSource, "descr", true));
            this.txtDescr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescr.Location = new System.Drawing.Point(104, 249);
            this.txtDescr.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescr.MaxLength = 30;
            this.txtDescr.Multiline = true;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(620, 209);
            this.txtDescr.TabIndex = 94;
            this.txtDescr.TextChanged += new System.EventHandler(this.txtDescr_TextChanged);
            // 
            // txtNS
            // 
            this.txtNS.BackColor = System.Drawing.SystemColors.Window;
            this.txtNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessoesBindingSource, "numS", true));
            this.txtNS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNS.Location = new System.Drawing.Point(104, 66);
            this.txtNS.Margin = new System.Windows.Forms.Padding(0);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(100, 34);
            this.txtNS.TabIndex = 90;
            // 
            // btnAddSes
            // 
            this.btnAddSes.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddSes.Location = new System.Drawing.Point(612, 495);
            this.btnAddSes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSes.Name = "btnAddSes";
            this.btnAddSes.Size = new System.Drawing.Size(112, 32);
            this.btnAddSes.TabIndex = 88;
            this.btnAddSes.Text = "Add Sessão";
            this.btnAddSes.UseVisualStyleBackColor = false;
            this.btnAddSes.Click += new System.EventHandler(this.btnAddSes_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(281, 23);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(443, 34);
            this.txtNome.TabIndex = 87;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.psiEasy;
            // 
            // txtPront
            // 
            this.txtPront.BackColor = System.Drawing.SystemColors.Window;
            this.txtPront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPront.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessoesBindingSource, "pront", true));
            this.txtPront.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPront.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPront.Location = new System.Drawing.Point(104, 23);
            this.txtPront.Margin = new System.Windows.Forms.Padding(0);
            this.txtPront.Name = "txtPront";
            this.txtPront.Size = new System.Drawing.Size(100, 34);
            this.txtPront.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 28);
            this.panel1.TabIndex = 133;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Psychology.Properties.Resources.Left_Filled_24;
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 26);
            this.button1.TabIndex = 130;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(48, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 95;
            this.label1.Text = "Sessões";
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
            // datDateTimePicker
            // 
            this.datDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sessoesBindingSource, "dat", true));
            this.datDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDateTimePicker.Location = new System.Drawing.Point(286, 70);
            this.datDateTimePicker.Name = "datDateTimePicker";
            this.datDateTimePicker.Size = new System.Drawing.Size(438, 34);
            this.datDateTimePicker.TabIndex = 98;
            // 
            // frmSessoesInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSessoesInfor";
            this.Text = "frmSessoesInfor";
            this.Load += new System.EventHandler(this.frmSessoesInfor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtResu;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.Button btnAddSes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPront;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public PsiEasy psiEasy;
        public System.Windows.Forms.BindingSource sessoesBindingSource;
        public PsiEasyTableAdapters.sessoesTableAdapter sessoesTableAdapter;
        public PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        public PsiEasyTableAdapters.clienteTableAdapter clienteTableAdapter;
        public System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DateTimePicker datDateTimePicker;
    }
}