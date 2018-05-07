namespace Psychology
{
    partial class frmSaude
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
            System.Windows.Forms.Label tratPsiLabel;
            System.Windows.Forms.Label queixaALabel;
            System.Windows.Forms.Label qndoPsLabel;
            System.Windows.Forms.Label duraLabel;
            System.Windows.Forms.Label ondeLabel;
            System.Windows.Forms.Label doencaLabel;
            System.Windows.Forms.Label trtMLabel;
            System.Windows.Forms.Label medicoLabel;
            System.Windows.Forms.Label medicaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label obsTLabel;
            System.Windows.Forms.Label qndoDoLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.medicaComboBox = new System.Windows.Forms.ComboBox();
            this.triagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.obsDTextBox = new System.Windows.Forms.TextBox();
            this.qndoDoTextBox = new System.Windows.Forms.TextBox();
            this.medicoTextBox = new System.Windows.Forms.TextBox();
            this.trtMComboBox = new System.Windows.Forms.ComboBox();
            this.doencaTextBox = new System.Windows.Forms.TextBox();
            this.obsTTextBox = new System.Windows.Forms.TextBox();
            this.ondeTextBox = new System.Windows.Forms.TextBox();
            this.duraTextBox = new System.Windows.Forms.TextBox();
            this.qndoPsTextBox = new System.Windows.Forms.TextBox();
            this.queixaATextBox = new System.Windows.Forms.TextBox();
            this.tratPsiComboBox = new System.Windows.Forms.ComboBox();
            this.panelMed = new System.Windows.Forms.Panel();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.txtDosa = new System.Windows.Forms.TextBox();
            this.btnInserirI = new System.Windows.Forms.Button();
            this.txtDoses = new System.Windows.Forms.TextBox();
            this.medicamentosDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnaSalvar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.triagemTableAdapter = new Psychology.PsiEasyTableAdapters.triagemTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            this.medicamentosTableAdapter = new Psychology.PsiEasyTableAdapters.medicamentosTableAdapter();
            this.medicamentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            tratPsiLabel = new System.Windows.Forms.Label();
            queixaALabel = new System.Windows.Forms.Label();
            qndoPsLabel = new System.Windows.Forms.Label();
            duraLabel = new System.Windows.Forms.Label();
            ondeLabel = new System.Windows.Forms.Label();
            doencaLabel = new System.Windows.Forms.Label();
            trtMLabel = new System.Windows.Forms.Label();
            medicoLabel = new System.Windows.Forms.Label();
            medicaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            obsTLabel = new System.Windows.Forms.Label();
            qndoDoLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triagemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            this.panelMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tratPsiLabel
            // 
            tratPsiLabel.AutoSize = true;
            tratPsiLabel.BackColor = System.Drawing.Color.Transparent;
            tratPsiLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tratPsiLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tratPsiLabel.Location = new System.Drawing.Point(255, 47);
            tratPsiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tratPsiLabel.Name = "tratPsiLabel";
            tratPsiLabel.Size = new System.Drawing.Size(405, 28);
            tratPsiLabel.TabIndex = 0;
            tratPsiLabel.Text = "Já fez tratamento Psicologico anteriormente?";
            // 
            // queixaALabel
            // 
            queixaALabel.AutoSize = true;
            queixaALabel.BackColor = System.Drawing.Color.Transparent;
            queixaALabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            queixaALabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            queixaALabel.Location = new System.Drawing.Point(255, 154);
            queixaALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            queixaALabel.Name = "queixaALabel";
            queixaALabel.Size = new System.Drawing.Size(216, 28);
            queixaALabel.TabIndex = 2;
            queixaALabel.Text = "Qual a queixa Anterior?";
            // 
            // qndoPsLabel
            // 
            qndoPsLabel.AutoSize = true;
            qndoPsLabel.BackColor = System.Drawing.Color.Transparent;
            qndoPsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qndoPsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            qndoPsLabel.Location = new System.Drawing.Point(255, 105);
            qndoPsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qndoPsLabel.Name = "qndoPsLabel";
            qndoPsLabel.Size = new System.Drawing.Size(92, 28);
            qndoPsLabel.TabIndex = 4;
            qndoPsLabel.Text = "Quando?";
            // 
            // duraLabel
            // 
            duraLabel.AutoSize = true;
            duraLabel.BackColor = System.Drawing.Color.Transparent;
            duraLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duraLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            duraLabel.Location = new System.Drawing.Point(677, 103);
            duraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            duraLabel.Name = "duraLabel";
            duraLabel.Size = new System.Drawing.Size(89, 28);
            duraLabel.TabIndex = 6;
            duraLabel.Text = "Duração:";
            // 
            // ondeLabel
            // 
            ondeLabel.AutoSize = true;
            ondeLabel.BackColor = System.Drawing.Color.Transparent;
            ondeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ondeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            ondeLabel.Location = new System.Drawing.Point(255, 293);
            ondeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ondeLabel.Name = "ondeLabel";
            ondeLabel.Size = new System.Drawing.Size(64, 28);
            ondeLabel.TabIndex = 8;
            ondeLabel.Text = "Onde:";
            // 
            // doencaLabel
            // 
            doencaLabel.AutoSize = true;
            doencaLabel.BackColor = System.Drawing.Color.Transparent;
            doencaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doencaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            doencaLabel.Location = new System.Drawing.Point(257, 501);
            doencaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            doencaLabel.Name = "doencaLabel";
            doencaLabel.Size = new System.Drawing.Size(131, 28);
            doencaLabel.TabIndex = 14;
            doencaLabel.Text = "Qual doença?";
            // 
            // trtMLabel
            // 
            trtMLabel.AutoSize = true;
            trtMLabel.BackColor = System.Drawing.Color.Transparent;
            trtMLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trtMLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            trtMLabel.Location = new System.Drawing.Point(257, 410);
            trtMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trtMLabel.Name = "trtMLabel";
            trtMLabel.Size = new System.Drawing.Size(343, 28);
            trtMLabel.TabIndex = 15;
            trtMLabel.Text = "Já Fez/ faz algum tratamento medico?";
            // 
            // medicoLabel
            // 
            medicoLabel.AutoSize = true;
            medicoLabel.BackColor = System.Drawing.Color.Transparent;
            medicoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medicoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            medicoLabel.Location = new System.Drawing.Point(257, 455);
            medicoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            medicoLabel.Name = "medicoLabel";
            medicoLabel.Size = new System.Drawing.Size(149, 28);
            medicoLabel.TabIndex = 16;
            medicoLabel.Text = "Qual o medico?";
            // 
            // medicaLabel
            // 
            medicaLabel.AutoSize = true;
            medicaLabel.BackColor = System.Drawing.Color.Transparent;
            medicaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medicaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            medicaLabel.Location = new System.Drawing.Point(257, 601);
            medicaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            medicaLabel.Name = "medicaLabel";
            medicaLabel.Size = new System.Drawing.Size(257, 28);
            medicaLabel.TabIndex = 22;
            medicaLabel.Text = "Toma Algum Medicamento?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(7, 5);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 28);
            label1.TabIndex = 24;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(7, 50);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 28);
            label2.TabIndex = 26;
            label2.Text = "Dosagem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(329, 54);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(180, 28);
            label3.TabIndex = 28;
            label3.Text = "Nº de doses diarias";
            // 
            // obsTLabel
            // 
            obsTLabel.AutoSize = true;
            obsTLabel.BackColor = System.Drawing.Color.Transparent;
            obsTLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            obsTLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            obsTLabel.Location = new System.Drawing.Point(255, 338);
            obsTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            obsTLabel.Name = "obsTLabel";
            obsTLabel.Size = new System.Drawing.Size(119, 28);
            obsTLabel.TabIndex = 10;
            obsTLabel.Text = "Observação:";
            // 
            // qndoDoLabel
            // 
            qndoDoLabel.AutoSize = true;
            qndoDoLabel.BackColor = System.Drawing.Color.Transparent;
            qndoDoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qndoDoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            qndoDoLabel.Location = new System.Drawing.Point(813, 410);
            qndoDoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qndoDoLabel.Name = "qndoDoLabel";
            qndoDoLabel.Size = new System.Drawing.Size(92, 28);
            qndoDoLabel.TabIndex = 18;
            qndoDoLabel.Text = "Quando?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label5.Location = new System.Drawing.Point(257, 555);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(119, 28);
            label5.TabIndex = 177;
            label5.Text = "Observação:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(medicaLabel);
            this.panel1.Controls.Add(this.medicaComboBox);
            this.panel1.Controls.Add(this.obsDTextBox);
            this.panel1.Controls.Add(qndoDoLabel);
            this.panel1.Controls.Add(this.qndoDoTextBox);
            this.panel1.Controls.Add(medicoLabel);
            this.panel1.Controls.Add(this.medicoTextBox);
            this.panel1.Controls.Add(trtMLabel);
            this.panel1.Controls.Add(this.trtMComboBox);
            this.panel1.Controls.Add(doencaLabel);
            this.panel1.Controls.Add(this.doencaTextBox);
            this.panel1.Controls.Add(obsTLabel);
            this.panel1.Controls.Add(this.obsTTextBox);
            this.panel1.Controls.Add(ondeLabel);
            this.panel1.Controls.Add(this.ondeTextBox);
            this.panel1.Controls.Add(duraLabel);
            this.panel1.Controls.Add(this.duraTextBox);
            this.panel1.Controls.Add(qndoPsLabel);
            this.panel1.Controls.Add(this.qndoPsTextBox);
            this.panel1.Controls.Add(queixaALabel);
            this.panel1.Controls.Add(this.queixaATextBox);
            this.panel1.Controls.Add(tratPsiLabel);
            this.panel1.Controls.Add(this.tratPsiComboBox);
            this.panel1.Controls.Add(this.panelMed);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 926);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(979, 910);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 178;
            // 
            // medicaComboBox
            // 
            this.medicaComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.medicaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "Medica", true));
            this.medicaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicaComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicaComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.medicaComboBox.FormattingEnabled = true;
            this.medicaComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.medicaComboBox.Location = new System.Drawing.Point(564, 598);
            this.medicaComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medicaComboBox.Name = "medicaComboBox";
            this.medicaComboBox.Size = new System.Drawing.Size(160, 36);
            this.medicaComboBox.TabIndex = 23;
            this.medicaComboBox.SelectedIndexChanged += new System.EventHandler(this.medicaComboBox_SelectedIndexChanged);
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
            // obsDTextBox
            // 
            this.obsDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.obsDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obsDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "obsD", true));
            this.obsDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obsDTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.obsDTextBox.Location = new System.Drawing.Point(427, 550);
            this.obsDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.obsDTextBox.MaxLength = 100;
            this.obsDTextBox.Name = "obsDTextBox";
            this.obsDTextBox.Size = new System.Drawing.Size(639, 34);
            this.obsDTextBox.TabIndex = 21;
            // 
            // qndoDoTextBox
            // 
            this.qndoDoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.qndoDoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qndoDoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "qndoDo", true));
            this.qndoDoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qndoDoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qndoDoTextBox.Location = new System.Drawing.Point(916, 406);
            this.qndoDoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qndoDoTextBox.MaxLength = 20;
            this.qndoDoTextBox.Name = "qndoDoTextBox";
            this.qndoDoTextBox.Size = new System.Drawing.Size(150, 34);
            this.qndoDoTextBox.TabIndex = 19;
            // 
            // medicoTextBox
            // 
            this.medicoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.medicoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "medico", true));
            this.medicoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.medicoTextBox.Location = new System.Drawing.Point(427, 454);
            this.medicoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medicoTextBox.MaxLength = 30;
            this.medicoTextBox.Name = "medicoTextBox";
            this.medicoTextBox.Size = new System.Drawing.Size(639, 34);
            this.medicoTextBox.TabIndex = 17;
            // 
            // trtMComboBox
            // 
            this.trtMComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.trtMComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "trtM", true));
            this.trtMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trtMComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trtMComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trtMComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trtMComboBox.FormattingEnabled = true;
            this.trtMComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.trtMComboBox.Location = new System.Drawing.Point(636, 406);
            this.trtMComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trtMComboBox.Name = "trtMComboBox";
            this.trtMComboBox.Size = new System.Drawing.Size(160, 36);
            this.trtMComboBox.TabIndex = 16;
            // 
            // doencaTextBox
            // 
            this.doencaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.doencaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doencaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "doenca", true));
            this.doencaTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doencaTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doencaTextBox.Location = new System.Drawing.Point(427, 502);
            this.doencaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doencaTextBox.MaxLength = 50;
            this.doencaTextBox.Name = "doencaTextBox";
            this.doencaTextBox.Size = new System.Drawing.Size(639, 34);
            this.doencaTextBox.TabIndex = 15;
            // 
            // obsTTextBox
            // 
            this.obsTTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.obsTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obsTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "obsT", true));
            this.obsTTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obsTTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.obsTTextBox.Location = new System.Drawing.Point(424, 335);
            this.obsTTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.obsTTextBox.MaxLength = 100;
            this.obsTTextBox.Name = "obsTTextBox";
            this.obsTTextBox.Size = new System.Drawing.Size(645, 34);
            this.obsTTextBox.TabIndex = 11;
            // 
            // ondeTextBox
            // 
            this.ondeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ondeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ondeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "Onde", true));
            this.ondeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ondeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ondeTextBox.Location = new System.Drawing.Point(424, 286);
            this.ondeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ondeTextBox.MaxLength = 30;
            this.ondeTextBox.Name = "ondeTextBox";
            this.ondeTextBox.Size = new System.Drawing.Size(645, 34);
            this.ondeTextBox.TabIndex = 9;
            // 
            // duraTextBox
            // 
            this.duraTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.duraTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "dura", true));
            this.duraTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duraTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.duraTextBox.Location = new System.Drawing.Point(792, 101);
            this.duraTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.duraTextBox.MaxLength = 20;
            this.duraTextBox.Name = "duraTextBox";
            this.duraTextBox.Size = new System.Drawing.Size(277, 34);
            this.duraTextBox.TabIndex = 7;
            // 
            // qndoPsTextBox
            // 
            this.qndoPsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.qndoPsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qndoPsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "qndoPs", true));
            this.qndoPsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qndoPsTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.qndoPsTextBox.Location = new System.Drawing.Point(424, 101);
            this.qndoPsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qndoPsTextBox.MaxLength = 20;
            this.qndoPsTextBox.Name = "qndoPsTextBox";
            this.qndoPsTextBox.Size = new System.Drawing.Size(231, 34);
            this.qndoPsTextBox.TabIndex = 5;
            // 
            // queixaATextBox
            // 
            this.queixaATextBox.BackColor = System.Drawing.SystemColors.Window;
            this.queixaATextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queixaATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "queixaA", true));
            this.queixaATextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queixaATextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.queixaATextBox.Location = new System.Drawing.Point(260, 183);
            this.queixaATextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.queixaATextBox.MaxLength = 100;
            this.queixaATextBox.Multiline = true;
            this.queixaATextBox.Name = "queixaATextBox";
            this.queixaATextBox.Size = new System.Drawing.Size(809, 88);
            this.queixaATextBox.TabIndex = 3;
            // 
            // tratPsiComboBox
            // 
            this.tratPsiComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.tratPsiComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "tratPsi", true));
            this.tratPsiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tratPsiComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tratPsiComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tratPsiComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tratPsiComboBox.FormattingEnabled = true;
            this.tratPsiComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.tratPsiComboBox.Location = new System.Drawing.Point(797, 43);
            this.tratPsiComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tratPsiComboBox.Name = "tratPsiComboBox";
            this.tratPsiComboBox.Size = new System.Drawing.Size(271, 36);
            this.tratPsiComboBox.TabIndex = 1;
            // 
            // panelMed
            // 
            this.panelMed.Controls.Add(label1);
            this.panelMed.Controls.Add(this.txtNomeM);
            this.panelMed.Controls.Add(this.txtDosa);
            this.panelMed.Controls.Add(label2);
            this.panelMed.Controls.Add(this.btnInserirI);
            this.panelMed.Controls.Add(this.txtDoses);
            this.panelMed.Controls.Add(this.medicamentosDataGridView);
            this.panelMed.Controls.Add(label3);
            this.panelMed.Location = new System.Drawing.Point(244, 641);
            this.panelMed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMed.Name = "panelMed";
            this.panelMed.Size = new System.Drawing.Size(835, 230);
            this.panelMed.TabIndex = 180;
            this.panelMed.Visible = false;
            // 
            // txtNomeM
            // 
            this.txtNomeM.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNomeM.Location = new System.Drawing.Point(176, 5);
            this.txtNomeM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(639, 34);
            this.txtNomeM.TabIndex = 25;
            // 
            // txtDosa
            // 
            this.txtDosa.BackColor = System.Drawing.SystemColors.Window;
            this.txtDosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDosa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDosa.Location = new System.Drawing.Point(176, 50);
            this.txtDosa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDosa.Name = "txtDosa";
            this.txtDosa.Size = new System.Drawing.Size(137, 34);
            this.txtDosa.TabIndex = 27;
            // 
            // btnInserirI
            // 
            this.btnInserirI.BackColor = System.Drawing.Color.Transparent;
            this.btnInserirI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnInserirI.Location = new System.Drawing.Point(657, 50);
            this.btnInserirI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserirI.Name = "btnInserirI";
            this.btnInserirI.Size = new System.Drawing.Size(125, 36);
            this.btnInserirI.TabIndex = 175;
            this.btnInserirI.Text = "Inserir";
            this.btnInserirI.UseVisualStyleBackColor = false;
            this.btnInserirI.Click += new System.EventHandler(this.btnInserirI_Click);
            // 
            // txtDoses
            // 
            this.txtDoses.BackColor = System.Drawing.SystemColors.Window;
            this.txtDoses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDoses.Location = new System.Drawing.Point(536, 50);
            this.txtDoses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoses.Name = "txtDoses";
            this.txtDoses.Size = new System.Drawing.Size(99, 34);
            this.txtDoses.TabIndex = 29;
            // 
            // medicamentosDataGridView
            // 
            this.medicamentosDataGridView.AllowUserToAddRows = false;
            this.medicamentosDataGridView.AutoGenerateColumns = false;
            this.medicamentosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicamentosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.medicamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.dosagemDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.medicamentosDataGridView.DataSource = this.medicamentosBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicamentosDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.medicamentosDataGridView.GridColor = System.Drawing.Color.MediumBlue;
            this.medicamentosDataGridView.Location = new System.Drawing.Point(12, 102);
            this.medicamentosDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medicamentosDataGridView.Name = "medicamentosDataGridView";
            this.medicamentosDataGridView.RowHeadersVisible = false;
            this.medicamentosDataGridView.Size = new System.Drawing.Size(809, 116);
            this.medicamentosDataGridView.TabIndex = 30;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dosagemDataGridViewTextBoxColumn
            // 
            this.dosagemDataGridViewTextBoxColumn.DataPropertyName = "Dosagem";
            this.dosagemDataGridViewTextBoxColumn.HeaderText = "Dosagem";
            this.dosagemDataGridViewTextBoxColumn.Name = "dosagemDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dose";
            this.dataGridViewTextBoxColumn1.HeaderText = "dose";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataMember = "medicamentos";
            this.medicamentosBindingSource.DataSource = this.psiEasy;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnaSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 927);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 43);
            this.panel2.TabIndex = 181;
            // 
            // btnaSalvar
            // 
            this.btnaSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnaSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnaSalvar.Location = new System.Drawing.Point(601, 0);
            this.btnaSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaSalvar.Name = "btnaSalvar";
            this.btnaSalvar.Size = new System.Drawing.Size(125, 36);
            this.btnaSalvar.TabIndex = 176;
            this.btnaSalvar.Text = "Salvar";
            this.btnaSalvar.UseVisualStyleBackColor = false;
            this.btnaSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.panel3.Size = new System.Drawing.Size(1347, 34);
            this.panel3.TabIndex = 99;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(64, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 95;
            this.label4.Text = "Saúde:";
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
            this.tableAdapterManager.medicamentosTableAdapter = this.medicamentosTableAdapter;
            this.tableAdapterManager.psicologosTableAdapter = null;
            this.tableAdapterManager.sessoesTableAdapter = null;
            this.tableAdapterManager.triagemTableAdapter = this.triagemTableAdapter;
            this.tableAdapterManager.UpdateOrder = Psychology.PsiEasyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // medicamentosTableAdapter
            // 
            this.medicamentosTableAdapter.ClearBeforeFill = true;
            // 
            // medicamentosBindingSource1
            // 
            this.medicamentosBindingSource1.DataMember = "Medicamentos";
            // 
            // frmSaude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 960);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSaude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaude";
            this.Load += new System.EventHandler(this.frmSaude_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triagemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            this.panelMed.ResumeLayout(false);
            this.panelMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox medicaComboBox;
        private System.Windows.Forms.TextBox obsDTextBox;
        private System.Windows.Forms.TextBox medicoTextBox;
        private System.Windows.Forms.ComboBox trtMComboBox;
        private System.Windows.Forms.TextBox doencaTextBox;
        private System.Windows.Forms.TextBox ondeTextBox;
        private System.Windows.Forms.TextBox duraTextBox;
        private System.Windows.Forms.TextBox qndoPsTextBox;
        private System.Windows.Forms.TextBox queixaATextBox;
        private System.Windows.Forms.ComboBox tratPsiComboBox;
        private System.Windows.Forms.TextBox txtDoses;
        private System.Windows.Forms.TextBox txtDosa;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.DataGridView medicamentosDataGridView;
        private System.Windows.Forms.Button btnInserirI;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qndoDoTextBox;
        private System.Windows.Forms.TextBox obsTTextBox;
  
        public PsiEasy psiEasy;
        public System.Windows.Forms.BindingSource triagemBindingSource;
        public PsiEasyTableAdapters.triagemTableAdapter triagemTableAdapter;
        public PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        public PsiEasyTableAdapters.medicamentosTableAdapter medicamentosTableAdapter;
        public System.Windows.Forms.BindingSource medicamentosBindingSource;
       
        private System.Windows.Forms.BindingSource medicamentosBindingSource1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelMed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnaSalvar;
    }
}