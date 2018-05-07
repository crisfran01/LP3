namespace Psychology
{
    partial class frmFamilia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label irmaosLabel;
            System.Windows.Forms.Label genetoLabel;
            System.Windows.Forms.Label telPLabel;
            System.Windows.Forms.Label celPLabel;
            System.Windows.Forms.Label idadePLabel;
            System.Windows.Forms.Label escoPLabel;
            System.Windows.Forms.Label profPLabel;
            System.Windows.Forms.Label nomePLabel;
            System.Windows.Forms.Label telMLabel;
            System.Windows.Forms.Label celMLabel;
            System.Windows.Forms.Label idadeMLabel;
            System.Windows.Forms.Label escoMLabel;
            System.Windows.Forms.Label profissaoLabel;
            System.Windows.Forms.Label nomeMLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.odfFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.psiEasy = new Psychology.PsiEasy();
            this.triagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.triagemTableAdapter = new Psychology.PsiEasyTableAdapters.triagemTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            this.telPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.irmaoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnInserirI = new System.Windows.Forms.Button();
            this.txtEscoI = new System.Windows.Forms.TextBox();
            this.txtIdadeI = new System.Windows.Forms.TextBox();
            this.txtNomeI = new System.Windows.Forms.TextBox();
            this.irmaosTextBox = new System.Windows.Forms.TextBox();
            this.genetoPictureBox = new System.Windows.Forms.PictureBox();
            this.idadePTextBox = new System.Windows.Forms.TextBox();
            this.escoPTextBox = new System.Windows.Forms.TextBox();
            this.profPTextBox = new System.Windows.Forms.TextBox();
            this.nomePTextBox = new System.Windows.Forms.TextBox();
            this.idadeMTextBox = new System.Windows.Forms.TextBox();
            this.escoMTextBox = new System.Windows.Forms.TextBox();
            this.profissaoTextBox = new System.Windows.Forms.TextBox();
            this.nomeMTextBox = new System.Windows.Forms.TextBox();
            this.irmaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.irmaoTableAdapter = new Psychology.PsiEasyTableAdapters.irmaoTableAdapter();
            this.prontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            irmaosLabel = new System.Windows.Forms.Label();
            genetoLabel = new System.Windows.Forms.Label();
            telPLabel = new System.Windows.Forms.Label();
            celPLabel = new System.Windows.Forms.Label();
            idadePLabel = new System.Windows.Forms.Label();
            escoPLabel = new System.Windows.Forms.Label();
            profPLabel = new System.Windows.Forms.Label();
            nomePLabel = new System.Windows.Forms.Label();
            telMLabel = new System.Windows.Forms.Label();
            celMLabel = new System.Windows.Forms.Label();
            idadeMLabel = new System.Windows.Forms.Label();
            escoMLabel = new System.Windows.Forms.Label();
            profissaoLabel = new System.Windows.Forms.Label();
            nomeMLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triagemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.irmaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genetoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.irmaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1394, 34);
            this.panel3.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(64, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 95;
            this.label4.Text = "Familia:";
            // 
            // odfFoto
            // 
            this.odfFoto.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSalvar.Location = new System.Drawing.Point(604, 935);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(145, 36);
            this.btnSalvar.TabIndex = 174;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.triagemBindingNavigatorSaveItem_Click);
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.Color.Transparent;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnImg.Location = new System.Drawing.Point(942, 876);
            this.btnImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(125, 36);
            this.btnImg.TabIndex = 17;
            this.btnImg.Text = "Abrir";
            this.btnImg.UseVisualStyleBackColor = false;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 947);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 180;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCancelar.Location = new System.Drawing.Point(485, 2017);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 36);
            this.btnCancelar.TabIndex = 181;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.telPTextBox);
            this.panel1.Controls.Add(this.celPTextBox);
            this.panel1.Controls.Add(this.telMTextBox);
            this.panel1.Controls.Add(this.celMTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.irmaoDataGridView);
            this.panel1.Controls.Add(this.btnInserirI);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtEscoI);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtIdadeI);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.txtNomeI);
            this.panel1.Controls.Add(irmaosLabel);
            this.panel1.Controls.Add(this.irmaosTextBox);
            this.panel1.Controls.Add(genetoLabel);
            this.panel1.Controls.Add(this.genetoPictureBox);
            this.panel1.Controls.Add(telPLabel);
            this.panel1.Controls.Add(celPLabel);
            this.panel1.Controls.Add(idadePLabel);
            this.panel1.Controls.Add(this.idadePTextBox);
            this.panel1.Controls.Add(escoPLabel);
            this.panel1.Controls.Add(this.escoPTextBox);
            this.panel1.Controls.Add(profPLabel);
            this.panel1.Controls.Add(this.profPTextBox);
            this.panel1.Controls.Add(nomePLabel);
            this.panel1.Controls.Add(this.nomePTextBox);
            this.panel1.Controls.Add(telMLabel);
            this.panel1.Controls.Add(celMLabel);
            this.panel1.Controls.Add(idadeMLabel);
            this.panel1.Controls.Add(this.idadeMTextBox);
            this.panel1.Controls.Add(escoMLabel);
            this.panel1.Controls.Add(this.escoMTextBox);
            this.panel1.Controls.Add(profissaoLabel);
            this.panel1.Controls.Add(this.profissaoTextBox);
            this.panel1.Controls.Add(nomeMLabel);
            this.panel1.Controls.Add(this.nomeMTextBox);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnImg);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 1058);
            this.panel1.TabIndex = 0;
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
            this.btnClose.Size = new System.Drawing.Size(51, 32);
            this.btnClose.TabIndex = 130;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // psiEasy
            // 
            this.psiEasy.DataSetName = "PsiEasy";
            this.psiEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // triagemBindingSource
            // 
            this.triagemBindingSource.DataMember = "triagem";
            this.triagemBindingSource.DataSource = this.psiEasy;
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
            this.tableAdapterManager.irmaoTableAdapter = this.irmaoTableAdapter;
            this.tableAdapterManager.medicamentosTableAdapter = null;
            this.tableAdapterManager.psicologosTableAdapter = null;
            this.tableAdapterManager.sessoesTableAdapter = null;
            this.tableAdapterManager.triagemTableAdapter = this.triagemTableAdapter;
            this.tableAdapterManager.UpdateOrder = Psychology.PsiEasyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // telPTextBox
            // 
            this.telPTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.telPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "TelP", true));
            this.telPTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telPTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telPTextBox.Location = new System.Drawing.Point(804, 452);
            this.telPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telPTextBox.Mask = "(00)00000-0000";
            this.telPTextBox.Name = "telPTextBox";
            this.telPTextBox.Size = new System.Drawing.Size(337, 34);
            this.telPTextBox.TabIndex = 12;
            // 
            // celPTextBox
            // 
            this.celPTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.celPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "celP", true));
            this.celPTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celPTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.celPTextBox.Location = new System.Drawing.Point(361, 452);
            this.celPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.celPTextBox.Mask = "(00)00000-0000";
            this.celPTextBox.Name = "celPTextBox";
            this.celPTextBox.Size = new System.Drawing.Size(338, 34);
            this.celPTextBox.TabIndex = 11;
            // 
            // telMTextBox
            // 
            this.telMTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.telMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "telM", true));
            this.telMTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telMTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telMTextBox.Location = new System.Drawing.Point(804, 278);
            this.telMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telMTextBox.Mask = "(00)00000-0000";
            this.telMTextBox.Name = "telMTextBox";
            this.telMTextBox.Size = new System.Drawing.Size(337, 34);
            this.telMTextBox.TabIndex = 6;
            // 
            // celMTextBox
            // 
            this.celMTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.celMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "celM", true));
            this.celMTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celMTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.celMTextBox.Location = new System.Drawing.Point(361, 278);
            this.celMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.celMTextBox.Mask = "(00)00000-0000";
            this.celMTextBox.Name = "celMTextBox";
            this.celMTextBox.Size = new System.Drawing.Size(338, 34);
            this.celMTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label7.Image = global::Psychology.Properties.Resources.View_Details_24;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(293, 517);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 28);
            this.label7.TabIndex = 219;
            this.label7.Text = "Informações dos irmãos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label6.Image = global::Psychology.Properties.Resources.View_Details_24;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(293, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 28);
            this.label6.TabIndex = 218;
            this.label6.Text = "Informações dos pais";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // irmaoDataGridView
            // 
            this.irmaoDataGridView.AllowUserToAddRows = false;
            this.irmaoDataGridView.AllowUserToDeleteRows = false;
            this.irmaoDataGridView.AutoGenerateColumns = false;
            this.irmaoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.irmaoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.irmaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.irmaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prontDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.escolariDataGridViewTextBoxColumn});
            this.irmaoDataGridView.DataSource = this.irmaoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.irmaoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.irmaoDataGridView.Location = new System.Drawing.Point(361, 731);
            this.irmaoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.irmaoDataGridView.Name = "irmaoDataGridView";
            this.irmaoDataGridView.RowHeadersVisible = false;
            this.irmaoDataGridView.Size = new System.Drawing.Size(468, 130);
            this.irmaoDataGridView.TabIndex = 217;
            // 
            // btnInserirI
            // 
            this.btnInserirI.BackColor = System.Drawing.Color.Transparent;
            this.btnInserirI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnInserirI.Location = new System.Drawing.Point(704, 626);
            this.btnInserirI.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirI.Name = "btnInserirI";
            this.btnInserirI.Size = new System.Drawing.Size(125, 36);
            this.btnInserirI.TabIndex = 216;
            this.btnInserirI.Text = "Inserir";
            this.btnInserirI.UseVisualStyleBackColor = false;
            this.btnInserirI.Click += new System.EventHandler(this.btnInserirI_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(456, 684);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 28);
            label3.TabIndex = 214;
            label3.Text = "Escolaridade:";
            // 
            // txtEscoI
            // 
            this.txtEscoI.BackColor = System.Drawing.SystemColors.Window;
            this.txtEscoI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEscoI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.irmaoBindingSource, "Escolari", true));
            this.txtEscoI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscoI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEscoI.Location = new System.Drawing.Point(591, 682);
            this.txtEscoI.Margin = new System.Windows.Forms.Padding(4);
            this.txtEscoI.Name = "txtEscoI";
            this.txtEscoI.Size = new System.Drawing.Size(238, 34);
            this.txtEscoI.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(285, 684);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 28);
            label2.TabIndex = 212;
            label2.Text = "Idade:";
            // 
            // txtIdadeI
            // 
            this.txtIdadeI.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdadeI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdadeI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.irmaoBindingSource, "Idade", true));
            this.txtIdadeI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdadeI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIdadeI.Location = new System.Drawing.Point(361, 682);
            this.txtIdadeI.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdadeI.Name = "txtIdadeI";
            this.txtIdadeI.Size = new System.Drawing.Size(83, 34);
            this.txtIdadeI.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(280, 634);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 28);
            label1.TabIndex = 210;
            label1.Text = "Nome:";
            // 
            // txtNomeI
            // 
            this.txtNomeI.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.irmaoBindingSource, "Nome", true));
            this.txtNomeI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNomeI.Location = new System.Drawing.Point(361, 626);
            this.txtNomeI.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeI.Name = "txtNomeI";
            this.txtNomeI.Size = new System.Drawing.Size(321, 34);
            this.txtNomeI.TabIndex = 14;
            // 
            // irmaosLabel
            // 
            irmaosLabel.AutoSize = true;
            irmaosLabel.BackColor = System.Drawing.Color.Transparent;
            irmaosLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            irmaosLabel.ForeColor = System.Drawing.SystemColors.Control;
            irmaosLabel.Location = new System.Drawing.Point(221, 578);
            irmaosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            irmaosLabel.Name = "irmaosLabel";
            irmaosLabel.Size = new System.Drawing.Size(124, 28);
            irmaosLabel.TabIndex = 208;
            irmaosLabel.Text = "Qtde Irmãos:";
            // 
            // irmaosTextBox
            // 
            this.irmaosTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.irmaosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.irmaosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "Irmaos", true));
            this.irmaosTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irmaosTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.irmaosTextBox.Location = new System.Drawing.Point(361, 576);
            this.irmaosTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.irmaosTextBox.Name = "irmaosTextBox";
            this.irmaosTextBox.Size = new System.Drawing.Size(133, 34);
            this.irmaosTextBox.TabIndex = 13;
            // 
            // genetoLabel
            // 
            genetoLabel.AutoSize = true;
            genetoLabel.BackColor = System.Drawing.Color.Transparent;
            genetoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genetoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            genetoLabel.Location = new System.Drawing.Point(933, 597);
            genetoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genetoLabel.Name = "genetoLabel";
            genetoLabel.Size = new System.Drawing.Size(136, 28);
            genetoLabel.TabIndex = 206;
            genetoLabel.Text = "Genetograma:";
            // 
            // genetoPictureBox
            // 
            this.genetoPictureBox.BackColor = System.Drawing.Color.White;
            this.genetoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.triagemBindingSource, "Geneto", true));
            this.genetoPictureBox.Location = new System.Drawing.Point(889, 626);
            this.genetoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.genetoPictureBox.Name = "genetoPictureBox";
            this.genetoPictureBox.Size = new System.Drawing.Size(249, 235);
            this.genetoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.genetoPictureBox.TabIndex = 207;
            this.genetoPictureBox.TabStop = false;
            // 
            // telPLabel
            // 
            telPLabel.AutoSize = true;
            telPLabel.BackColor = System.Drawing.Color.Transparent;
            telPLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telPLabel.ForeColor = System.Drawing.SystemColors.Control;
            telPLabel.Location = new System.Drawing.Point(751, 454);
            telPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telPLabel.Name = "telPLabel";
            telPLabel.Size = new System.Drawing.Size(39, 28);
            telPLabel.TabIndex = 205;
            telPLabel.Text = "Tel:";
            // 
            // celPLabel
            // 
            celPLabel.AutoSize = true;
            celPLabel.BackColor = System.Drawing.Color.Transparent;
            celPLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celPLabel.ForeColor = System.Drawing.SystemColors.Control;
            celPLabel.Location = new System.Drawing.Point(307, 454);
            celPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            celPLabel.Name = "celPLabel";
            celPLabel.Size = new System.Drawing.Size(43, 28);
            celPLabel.TabIndex = 204;
            celPLabel.Text = "Cel:";
            // 
            // idadePLabel
            // 
            idadePLabel.AutoSize = true;
            idadePLabel.BackColor = System.Drawing.Color.Transparent;
            idadePLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idadePLabel.ForeColor = System.Drawing.SystemColors.Control;
            idadePLabel.Location = new System.Drawing.Point(929, 336);
            idadePLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idadePLabel.Name = "idadePLabel";
            idadePLabel.Size = new System.Drawing.Size(65, 28);
            idadePLabel.TabIndex = 202;
            idadePLabel.Text = "Idade:";
            // 
            // idadePTextBox
            // 
            this.idadePTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idadePTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idadePTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "idadeP", true));
            this.idadePTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadePTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idadePTextBox.Location = new System.Drawing.Point(1005, 333);
            this.idadePTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idadePTextBox.MaxLength = 3;
            this.idadePTextBox.Name = "idadePTextBox";
            this.idadePTextBox.Size = new System.Drawing.Size(133, 34);
            this.idadePTextBox.TabIndex = 8;
            // 
            // escoPLabel
            // 
            escoPLabel.AutoSize = true;
            escoPLabel.BackColor = System.Drawing.Color.Transparent;
            escoPLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            escoPLabel.ForeColor = System.Drawing.SystemColors.Control;
            escoPLabel.Location = new System.Drawing.Point(773, 394);
            escoPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            escoPLabel.Name = "escoPLabel";
            escoPLabel.Size = new System.Drawing.Size(126, 28);
            escoPLabel.TabIndex = 200;
            escoPLabel.Text = "Escolaridade:";
            // 
            // escoPTextBox
            // 
            this.escoPTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.escoPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escoPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "escoP", true));
            this.escoPTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escoPTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.escoPTextBox.Location = new System.Drawing.Point(915, 391);
            this.escoPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.escoPTextBox.MaxLength = 15;
            this.escoPTextBox.Name = "escoPTextBox";
            this.escoPTextBox.Size = new System.Drawing.Size(223, 34);
            this.escoPTextBox.TabIndex = 10;
            // 
            // profPLabel
            // 
            profPLabel.AutoSize = true;
            profPLabel.BackColor = System.Drawing.Color.Transparent;
            profPLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            profPLabel.ForeColor = System.Drawing.SystemColors.Control;
            profPLabel.Location = new System.Drawing.Point(255, 394);
            profPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            profPLabel.Name = "profPLabel";
            profPLabel.Size = new System.Drawing.Size(91, 28);
            profPLabel.TabIndex = 198;
            profPLabel.Text = "Profissão";
            // 
            // profPTextBox
            // 
            this.profPTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.profPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "ProfP", true));
            this.profPTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profPTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profPTextBox.Location = new System.Drawing.Point(361, 391);
            this.profPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.profPTextBox.MaxLength = 20;
            this.profPTextBox.Name = "profPTextBox";
            this.profPTextBox.Size = new System.Drawing.Size(379, 34);
            this.profPTextBox.TabIndex = 9;
            // 
            // nomePLabel
            // 
            nomePLabel.AutoSize = true;
            nomePLabel.BackColor = System.Drawing.Color.Transparent;
            nomePLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomePLabel.ForeColor = System.Drawing.SystemColors.Control;
            nomePLabel.Location = new System.Drawing.Point(217, 336);
            nomePLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomePLabel.Name = "nomePLabel";
            nomePLabel.Size = new System.Drawing.Size(129, 28);
            nomePLabel.TabIndex = 196;
            nomePLabel.Text = "Nome do Pai:";
            // 
            // nomePTextBox
            // 
            this.nomePTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nomePTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "NomeP", true));
            this.nomePTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomePTextBox.Location = new System.Drawing.Point(361, 333);
            this.nomePTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomePTextBox.MaxLength = 30;
            this.nomePTextBox.Name = "nomePTextBox";
            this.nomePTextBox.Size = new System.Drawing.Size(530, 34);
            this.nomePTextBox.TabIndex = 7;
            // 
            // telMLabel
            // 
            telMLabel.AutoSize = true;
            telMLabel.BackColor = System.Drawing.Color.Transparent;
            telMLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telMLabel.ForeColor = System.Drawing.SystemColors.Control;
            telMLabel.Location = new System.Drawing.Point(751, 280);
            telMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telMLabel.Name = "telMLabel";
            telMLabel.Size = new System.Drawing.Size(39, 28);
            telMLabel.TabIndex = 195;
            telMLabel.Text = "Tel:";
            // 
            // celMLabel
            // 
            celMLabel.AutoSize = true;
            celMLabel.BackColor = System.Drawing.Color.Transparent;
            celMLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celMLabel.ForeColor = System.Drawing.SystemColors.Control;
            celMLabel.Location = new System.Drawing.Point(307, 280);
            celMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            celMLabel.Name = "celMLabel";
            celMLabel.Size = new System.Drawing.Size(43, 28);
            celMLabel.TabIndex = 194;
            celMLabel.Text = "Cel:";
            // 
            // idadeMLabel
            // 
            idadeMLabel.AutoSize = true;
            idadeMLabel.BackColor = System.Drawing.Color.Transparent;
            idadeMLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idadeMLabel.ForeColor = System.Drawing.SystemColors.Control;
            idadeMLabel.Location = new System.Drawing.Point(929, 164);
            idadeMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idadeMLabel.Name = "idadeMLabel";
            idadeMLabel.Size = new System.Drawing.Size(65, 28);
            idadeMLabel.TabIndex = 192;
            idadeMLabel.Text = "Idade:";
            // 
            // idadeMTextBox
            // 
            this.idadeMTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idadeMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idadeMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "idadeM", true));
            this.idadeMTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeMTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idadeMTextBox.Location = new System.Drawing.Point(1005, 161);
            this.idadeMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idadeMTextBox.MaxLength = 3;
            this.idadeMTextBox.Name = "idadeMTextBox";
            this.idadeMTextBox.Size = new System.Drawing.Size(133, 34);
            this.idadeMTextBox.TabIndex = 2;
            // 
            // escoMLabel
            // 
            escoMLabel.AutoSize = true;
            escoMLabel.BackColor = System.Drawing.Color.Transparent;
            escoMLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            escoMLabel.ForeColor = System.Drawing.SystemColors.Control;
            escoMLabel.Location = new System.Drawing.Point(776, 221);
            escoMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            escoMLabel.Name = "escoMLabel";
            escoMLabel.Size = new System.Drawing.Size(126, 28);
            escoMLabel.TabIndex = 190;
            escoMLabel.Text = "Escolaridade:";
            // 
            // escoMTextBox
            // 
            this.escoMTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.escoMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escoMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "escoM", true));
            this.escoMTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escoMTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.escoMTextBox.Location = new System.Drawing.Point(917, 219);
            this.escoMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.escoMTextBox.Name = "escoMTextBox";
            this.escoMTextBox.Size = new System.Drawing.Size(223, 34);
            this.escoMTextBox.TabIndex = 4;
            // 
            // profissaoLabel
            // 
            profissaoLabel.AutoSize = true;
            profissaoLabel.BackColor = System.Drawing.Color.Transparent;
            profissaoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            profissaoLabel.ForeColor = System.Drawing.SystemColors.Control;
            profissaoLabel.Location = new System.Drawing.Point(251, 221);
            profissaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            profissaoLabel.Name = "profissaoLabel";
            profissaoLabel.Size = new System.Drawing.Size(95, 28);
            profissaoLabel.TabIndex = 188;
            profissaoLabel.Text = "Profissão:";
            // 
            // profissaoTextBox
            // 
            this.profissaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.profissaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profissaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "Profissao", true));
            this.profissaoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profissaoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profissaoTextBox.Location = new System.Drawing.Point(361, 219);
            this.profissaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.profissaoTextBox.MaxLength = 20;
            this.profissaoTextBox.Name = "profissaoTextBox";
            this.profissaoTextBox.Size = new System.Drawing.Size(338, 34);
            this.profissaoTextBox.TabIndex = 3;
            // 
            // nomeMLabel
            // 
            nomeMLabel.AutoSize = true;
            nomeMLabel.BackColor = System.Drawing.Color.Transparent;
            nomeMLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeMLabel.ForeColor = System.Drawing.SystemColors.Control;
            nomeMLabel.Location = new System.Drawing.Point(200, 164);
            nomeMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeMLabel.Name = "nomeMLabel";
            nomeMLabel.Size = new System.Drawing.Size(145, 28);
            nomeMLabel.TabIndex = 186;
            nomeMLabel.Text = "Nome da  Mãe:";
            // 
            // nomeMTextBox
            // 
            this.nomeMTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nomeMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "NomeM", true));
            this.nomeMTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeMTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeMTextBox.Location = new System.Drawing.Point(361, 161);
            this.nomeMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeMTextBox.MaxLength = 30;
            this.nomeMTextBox.Name = "nomeMTextBox";
            this.nomeMTextBox.Size = new System.Drawing.Size(530, 34);
            this.nomeMTextBox.TabIndex = 1;
            // 
            // irmaoBindingSource
            // 
            this.irmaoBindingSource.DataMember = "irmao";
            this.irmaoBindingSource.DataSource = this.psiEasy;
            // 
            // irmaoTableAdapter
            // 
            this.irmaoTableAdapter.ClearBeforeFill = true;
            // 
            // prontDataGridViewTextBoxColumn
            // 
            this.prontDataGridViewTextBoxColumn.DataPropertyName = "Pront";
            this.prontDataGridViewTextBoxColumn.HeaderText = "Pront";
            this.prontDataGridViewTextBoxColumn.Name = "prontDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            // 
            // escolariDataGridViewTextBoxColumn
            // 
            this.escolariDataGridViewTextBoxColumn.DataPropertyName = "Escolari";
            this.escolariDataGridViewTextBoxColumn.HeaderText = "Escolari";
            this.escolariDataGridViewTextBoxColumn.Name = "escolariDataGridViewTextBoxColumn";
            // 
            // frmFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1394, 1092);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFamilia";
            this.Load += new System.EventHandler(this.frmFamilia_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triagemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.irmaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genetoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.irmaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.OpenFileDialog odfFoto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox telPTextBox;
        private System.Windows.Forms.MaskedTextBox celPTextBox;
        private System.Windows.Forms.MaskedTextBox telMTextBox;
        private System.Windows.Forms.MaskedTextBox celMTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView irmaoDataGridView;
        private System.Windows.Forms.Button btnInserirI;
        private System.Windows.Forms.TextBox txtEscoI;
        private System.Windows.Forms.TextBox txtIdadeI;
        private System.Windows.Forms.TextBox txtNomeI;
        private System.Windows.Forms.TextBox irmaosTextBox;
        private System.Windows.Forms.PictureBox genetoPictureBox;
        private System.Windows.Forms.TextBox idadePTextBox;
        private System.Windows.Forms.TextBox escoPTextBox;
        private System.Windows.Forms.TextBox profPTextBox;
        private System.Windows.Forms.TextBox nomePTextBox;
        private System.Windows.Forms.TextBox idadeMTextBox;
        private System.Windows.Forms.TextBox escoMTextBox;
        private System.Windows.Forms.TextBox profissaoTextBox;
        private System.Windows.Forms.TextBox nomeMTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn prontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escolariDataGridViewTextBoxColumn;
        public PsiEasy psiEasy;
        public System.Windows.Forms.BindingSource triagemBindingSource;
        public PsiEasyTableAdapters.triagemTableAdapter triagemTableAdapter;
        public PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        public PsiEasyTableAdapters.irmaoTableAdapter irmaoTableAdapter;
        public System.Windows.Forms.BindingSource irmaoBindingSource;
    }
}