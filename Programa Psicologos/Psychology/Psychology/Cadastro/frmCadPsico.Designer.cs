namespace Psychology
{
    partial class frmCadPsico
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label endLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cRPLabel;
            System.Windows.Forms.Label numLabel;
            System.Windows.Forms.Label label6;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.MaskedTextBox();
            this.psicologosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.celTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtAbordagem = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.cRPTextBox = new System.Windows.Forms.TextBox();
            this.txtCPsi = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.psicologosTableAdapter = new Psychology.PsiEasyTableAdapters.psicologosTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cRPLabel = new System.Windows.Forms.Label();
            numLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psicologosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            label2.Location = new System.Drawing.Point(495, 311);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 21);
            label2.TabIndex = 141;
            label2.Text = "Celular:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            label3.Location = new System.Drawing.Point(169, 311);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 21);
            label3.TabIndex = 139;
            label3.Text = "Telefone:";
            // 
            // cepLabel
            // 
            cepLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cepLabel.AutoSize = true;
            cepLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cepLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            cepLabel.Location = new System.Drawing.Point(642, 259);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(40, 21);
            cepLabel.TabIndex = 136;
            cepLabel.Text = "CEP:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            cidadeLabel.Location = new System.Drawing.Point(367, 259);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(61, 21);
            cidadeLabel.TabIndex = 133;
            cidadeLabel.Text = "Cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            bairroLabel.Location = new System.Drawing.Point(169, 259);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(55, 21);
            bairroLabel.TabIndex = 131;
            bairroLabel.Text = "Bairro:";
            // 
            // endLabel
            // 
            endLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            endLabel.AutoSize = true;
            endLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            endLabel.Location = new System.Drawing.Point(169, 207);
            endLabel.Name = "endLabel";
            endLabel.Size = new System.Drawing.Size(77, 21);
            endLabel.TabIndex = 129;
            endLabel.Text = "Endereço:";
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            nomeLabel.Location = new System.Drawing.Point(169, 155);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(56, 21);
            nomeLabel.TabIndex = 127;
            nomeLabel.Text = "Nome:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            label1.Location = new System.Drawing.Point(169, 103);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 21);
            label1.TabIndex = 143;
            label1.Text = "Cod:";
            // 
            // cRPLabel
            // 
            cRPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cRPLabel.AutoSize = true;
            cRPLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cRPLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            cRPLabel.Location = new System.Drawing.Point(404, 103);
            cRPLabel.Name = "cRPLabel";
            cRPLabel.Size = new System.Drawing.Size(42, 21);
            cRPLabel.TabIndex = 143;
            cRPLabel.Text = "CRP:";
            // 
            // numLabel
            // 
            numLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            numLabel.AutoSize = true;
            numLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            numLabel.Location = new System.Drawing.Point(695, 207);
            numLabel.Name = "numLabel";
            numLabel.Size = new System.Drawing.Size(32, 21);
            numLabel.TabIndex = 145;
            numLabel.Text = "Nº:";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            label6.Location = new System.Drawing.Point(587, 103);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(95, 21);
            label6.TabIndex = 148;
            label6.Text = "Abordagem:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.telTextBox);
            this.panel1.Controls.Add(this.celTextBox);
            this.panel1.Controls.Add(this.cepTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtAbordagem);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(numLabel);
            this.panel1.Controls.Add(this.numTextBox);
            this.panel1.Controls.Add(cRPLabel);
            this.panel1.Controls.Add(this.cRPTextBox);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtCPsi);
            this.panel1.Controls.Add(cepLabel);
            this.panel1.Controls.Add(this.estadoComboBox);
            this.panel1.Controls.Add(cidadeLabel);
            this.panel1.Controls.Add(this.cidadeTextBox);
            this.panel1.Controls.Add(bairroLabel);
            this.panel1.Controls.Add(this.bairroTextBox);
            this.panel1.Controls.Add(endLabel);
            this.panel1.Controls.Add(this.endTextBox);
            this.panel1.Controls.Add(nomeLabel);
            this.panel1.Controls.Add(this.nomeTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 649);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1010, 28);
            this.panel5.TabIndex = 187;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label7.Location = new System.Drawing.Point(48, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 23);
            this.label7.TabIndex = 95;
            this.label7.Text = "Cadastro de Psicólogos";
            // 
            // telTextBox
            // 
            this.telTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "tel", true));
            this.telTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telTextBox.Location = new System.Drawing.Point(259, 308);
            this.telTextBox.Mask = "(00)00000-0000";
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(217, 29);
            this.telTextBox.TabIndex = 10;
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
            // celTextBox
            // 
            this.celTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.celTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.celTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "cel", true));
            this.celTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.celTextBox.Location = new System.Drawing.Point(577, 308);
            this.celTextBox.Mask = "(00)00000-0000";
            this.celTextBox.Name = "celTextBox";
            this.celTextBox.Size = new System.Drawing.Size(249, 29);
            this.celTextBox.TabIndex = 11;
            // 
            // cepTextBox
            // 
            this.cepTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cepTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "cep", true));
            this.cepTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cepTextBox.Location = new System.Drawing.Point(699, 256);
            this.cepTextBox.Mask = "00,000-000";
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(127, 29);
            this.cepTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label5.Image = global::Psychology.Properties.Resources.View_Details_24;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(130, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 31);
            this.label5.TabIndex = 151;
            this.label5.Text = "Dados do Psicólogo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBuscar.BackgroundImage = global::Psychology.Properties.Resources.Search_32;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(361, 101);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 29);
            this.btnBuscar.TabIndex = 150;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtAbordagem
            // 
            this.txtAbordagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAbordagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtAbordagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAbordagem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "abordagem", true));
            this.txtAbordagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbordagem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAbordagem.Location = new System.Drawing.Point(688, 101);
            this.txtAbordagem.MaxLength = 20;
            this.txtAbordagem.Name = "txtAbordagem";
            this.txtAbordagem.Size = new System.Drawing.Size(138, 29);
            this.txtAbordagem.TabIndex = 2;
            // 
            // numTextBox
            // 
            this.numTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.numTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "num", true));
            this.numTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numTextBox.Location = new System.Drawing.Point(733, 205);
            this.numTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.numTextBox.MaxLength = 5;
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(94, 29);
            this.numTextBox.TabIndex = 5;
            this.numTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTextBox_KeyPress);
            // 
            // cRPTextBox
            // 
            this.cRPTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cRPTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cRPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "CRP", true));
            this.cRPTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cRPTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cRPTextBox.Location = new System.Drawing.Point(452, 101);
            this.cRPTextBox.MaxLength = 10;
            this.cRPTextBox.Name = "cRPTextBox";
            this.cRPTextBox.Size = new System.Drawing.Size(115, 29);
            this.cRPTextBox.TabIndex = 1;
            this.cRPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cRPTextBox_KeyPress);
            // 
            // txtCPsi
            // 
            this.txtCPsi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPsi.BackColor = System.Drawing.SystemColors.Window;
            this.txtCPsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPsi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "CodP", true));
            this.txtCPsi.Enabled = false;
            this.txtCPsi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPsi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCPsi.Location = new System.Drawing.Point(259, 101);
            this.txtCPsi.Margin = new System.Windows.Forms.Padding(0);
            this.txtCPsi.Name = "txtCPsi";
            this.txtCPsi.Size = new System.Drawing.Size(85, 29);
            this.txtCPsi.TabIndex = 138;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estadoComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "estado", true));
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.estadoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "MG",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO\t\t"});
            this.estadoComboBox.Location = new System.Drawing.Point(577, 258);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(56, 29);
            this.estadoComboBox.TabIndex = 8;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cidadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "cidade", true));
            this.cidadeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cidadeTextBox.Location = new System.Drawing.Point(434, 258);
            this.cidadeTextBox.MaxLength = 30;
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(132, 29);
            this.cidadeTextBox.TabIndex = 7;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bairroTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.bairroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bairroTextBox.Location = new System.Drawing.Point(259, 257);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.bairroTextBox.MaxLength = 30;
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(100, 29);
            this.bairroTextBox.TabIndex = 6;
            // 
            // endTextBox
            // 
            this.endTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.endTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "End", true));
            this.endTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.endTextBox.Location = new System.Drawing.Point(259, 205);
            this.endTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.endTextBox.MaxLength = 150;
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(412, 29);
            this.endTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.psicologosBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nomeTextBox.Location = new System.Drawing.Point(259, 153);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeTextBox.MaxLength = 128;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(567, 29);
            this.nomeTextBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnProximo);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 606);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 43);
            this.panel2.TabIndex = 152;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Image = global::Psychology.Properties.Resources.Edit_24__2_;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(859, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 27);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 1);
            this.panel3.TabIndex = 7;
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProximo.BackColor = System.Drawing.Color.Transparent;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProximo.Image = global::Psychology.Properties.Resources.Double_Right_24;
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProximo.Location = new System.Drawing.Point(520, 6);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(118, 30);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnterior.Image = global::Psychology.Properties.Resources.Double_Left_24;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnterior.Location = new System.Drawing.Point(358, 6);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(118, 30);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Image = global::Psychology.Properties.Resources.Plus_Math_24;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(44, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(118, 30);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Adicionar";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelEdit.Controls.Add(this.panel4);
            this.panelEdit.Controls.Add(this.btnCancelar);
            this.panelEdit.Controls.Add(this.btnSalvar);
            this.panelEdit.Location = new System.Drawing.Point(0, 606);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1010, 43);
            this.panelEdit.TabIndex = 153;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 1);
            this.panel4.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Image = global::Psychology.Properties.Resources.Cancel_24;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(705, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "    Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Image = global::Psychology.Properties.Resources.Save_24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(859, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 30);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            // frmCadPsico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1010, 649);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadPsico";
            this.Text = "frmCadPsico";
            this.Load += new System.EventHandler(this.frmCadPsico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psicologosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cRPTextBox;
        private System.Windows.Forms.TextBox txtCPsi;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox txtAbordagem;
        public PsiEasy psiEasy;
        public System.Windows.Forms.BindingSource psicologosBindingSource;
        public PsiEasyTableAdapters.psicologosTableAdapter psicologosTableAdapter;
        public PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.MaskedTextBox cepTextBox;
        private System.Windows.Forms.MaskedTextBox telTextBox;
        private System.Windows.Forms.MaskedTextBox celTextBox;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
    }
}