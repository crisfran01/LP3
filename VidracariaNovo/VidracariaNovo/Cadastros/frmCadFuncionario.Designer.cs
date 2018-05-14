namespace VidracariaNovo
{
    partial class frmCadFuncionario
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
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label numLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label endLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFgts = new System.Windows.Forms.MaskedTextBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VidracariaNovo.DataSet1();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rgTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.funcaoTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
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
            this.funcionariosTableAdapter = new VidracariaNovo.DataSet1TableAdapters.funcionariosTableAdapter();
            this.tableAdapterManager = new VidracariaNovo.DataSet1TableAdapters.TableAdapterManager();
            label6 = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            numLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            label6.Location = new System.Drawing.Point(595, 514);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 26);
            label6.TabIndex = 185;
            label6.Text = "FGTS:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rgLabel
            // 
            rgLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            rgLabel.AutoSize = true;
            rgLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rgLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            rgLabel.Location = new System.Drawing.Point(639, 217);
            rgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(45, 24);
            rgLabel.TabIndex = 182;
            rgLabel.Text = "RG:";
            // 
            // cpfLabel
            // 
            cpfLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cpfLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpfLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            cpfLabel.Location = new System.Drawing.Point(143, 213);
            cpfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(133, 26);
            cpfLabel.TabIndex = 181;
            cpfLabel.Text = "CPF:";
            cpfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            label4.Location = new System.Drawing.Point(144, 513);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 28);
            label4.TabIndex = 177;
            label4.Text = "Função:";
            // 
            // numLabel
            // 
            numLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            numLabel.AutoSize = true;
            numLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            numLabel.Location = new System.Drawing.Point(845, 265);
            numLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numLabel.Name = "numLabel";
            numLabel.Size = new System.Drawing.Size(40, 28);
            numLabel.TabIndex = 171;
            numLabel.Text = "Nº:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            label1.Location = new System.Drawing.Point(143, 91);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 28);
            label1.TabIndex = 168;
            label1.Text = "Cod:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            label2.Location = new System.Drawing.Point(579, 393);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 28);
            label2.TabIndex = 166;
            label2.Text = "Celular:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            label3.Location = new System.Drawing.Point(144, 393);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 28);
            label3.TabIndex = 164;
            label3.Text = "Telefone:";
            // 
            // cepLabel
            // 
            cepLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cepLabel.AutoSize = true;
            cepLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cepLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            cepLabel.Location = new System.Drawing.Point(775, 329);
            cepLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(49, 28);
            cepLabel.TabIndex = 161;
            cepLabel.Text = "CEP:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            cidadeLabel.Location = new System.Drawing.Point(408, 329);
            cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(77, 28);
            cidadeLabel.TabIndex = 158;
            cidadeLabel.Text = "Cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            bairroLabel.Location = new System.Drawing.Point(144, 329);
            bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(68, 28);
            bairroLabel.TabIndex = 156;
            bairroLabel.Text = "Bairro:";
            // 
            // endLabel
            // 
            endLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            endLabel.AutoSize = true;
            endLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            endLabel.Location = new System.Drawing.Point(144, 265);
            endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            endLabel.Name = "endLabel";
            endLabel.Size = new System.Drawing.Size(97, 28);
            endLabel.TabIndex = 154;
            endLabel.Text = "Endereço:";
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            nomeLabel.Location = new System.Drawing.Point(144, 155);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(70, 28);
            nomeLabel.TabIndex = 152;
            nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            emailLabel.Location = new System.Drawing.Point(144, 452);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(120, 26);
            emailLabel.TabIndex = 217;
            emailLabel.Text = "E-mail:";
            emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1165, 34);
            this.panel5.TabIndex = 186;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(0, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 32);
            this.btnClose.TabIndex = 130;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label7.Location = new System.Drawing.Point(64, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 29);
            this.label7.TabIndex = 95;
            this.label7.Text = "Cadastro de Funcionários";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.txtFgts);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.cepTextBox);
            this.panel1.Controls.Add(this.telTextBox);
            this.panel1.Controls.Add(this.celTextBox);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.rgTextBox);
            this.panel1.Controls.Add(this.cpfTextBox);
            this.panel1.Controls.Add(rgLabel);
            this.panel1.Controls.Add(cpfLabel);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.funcaoTextBox);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(numLabel);
            this.panel1.Controls.Add(this.numTextBox);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtCod);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 660);
            this.panel1.TabIndex = 3;
            // 
            // txtFgts
            // 
            this.txtFgts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFgts.BackColor = System.Drawing.SystemColors.Window;
            this.txtFgts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "FGTS", true));
            this.txtFgts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFgts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFgts.Location = new System.Drawing.Point(684, 510);
            this.txtFgts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFgts.Mask = "000,000,000-00";
            this.txtFgts.Name = "txtFgts";
            this.txtFgts.Size = new System.Drawing.Size(333, 34);
            this.txtFgts.TabIndex = 218;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailTextBox.Location = new System.Drawing.Point(264, 449);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextBox.MaxLength = 30;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(754, 34);
            this.emailTextBox.TabIndex = 216;
            // 
            // cepTextBox
            // 
            this.cepTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cepTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "cep", true));
            this.cepTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cepTextBox.Location = new System.Drawing.Point(851, 325);
            this.cepTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cepTextBox.Mask = "00,000-000";
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(168, 34);
            this.cepTextBox.TabIndex = 10;
            // 
            // telTextBox
            // 
            this.telTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "telefone", true));
            this.telTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telTextBox.Location = new System.Drawing.Point(264, 389);
            this.telTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telTextBox.Mask = "(00)00000-0000";
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(287, 34);
            this.telTextBox.TabIndex = 11;
            // 
            // celTextBox
            // 
            this.celTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.celTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.celTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "cel", true));
            this.celTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.celTextBox.Location = new System.Drawing.Point(688, 389);
            this.celTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.celTextBox.Mask = "(00)00000-0000";
            this.celTextBox.Name = "celTextBox";
            this.celTextBox.Size = new System.Drawing.Size(329, 34);
            this.celTextBox.TabIndex = 12;
            // 
            // rgTextBox
            // 
            this.rgTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rgTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "rg", true));
            this.rgTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rgTextBox.Location = new System.Drawing.Point(695, 209);
            this.rgTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rgTextBox.Mask = "00,000,000-C";
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(324, 34);
            this.rgTextBox.TabIndex = 4;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpfTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "cpf", true));
            this.cpfTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cpfTextBox.Location = new System.Drawing.Point(264, 209);
            this.cpfTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpfTextBox.Mask = "000,000,000-00";
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(356, 34);
            this.cpfTextBox.TabIndex = 3;
            // 
            // funcaoTextBox
            // 
            this.funcaoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.funcaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.funcaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.funcaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "funcao", true));
            this.funcaoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcaoTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.funcaoTextBox.Location = new System.Drawing.Point(264, 510);
            this.funcaoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.funcaoTextBox.Name = "funcaoTextBox";
            this.funcaoTextBox.Size = new System.Drawing.Size(289, 34);
            this.funcaoTextBox.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(400, 89);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 36);
            this.btnBuscar.TabIndex = 175;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // numTextBox
            // 
            this.numTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.numTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "num", true));
            this.numTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numTextBox.Location = new System.Drawing.Point(896, 262);
            this.numTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(125, 34);
            this.numTextBox.TabIndex = 6;
            // 
            // txtCod
            // 
            this.txtCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCod.BackColor = System.Drawing.SystemColors.Window;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "cod", true));
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCod.Location = new System.Drawing.Point(264, 89);
            this.txtCod.Margin = new System.Windows.Forms.Padding(0);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(113, 34);
            this.txtCod.TabIndex = 1;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estadoComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "uf", true));
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
            this.estadoComboBox.Location = new System.Drawing.Point(692, 325);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(73, 36);
            this.estadoComboBox.TabIndex = 9;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cidadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "cidade", true));
            this.cidadeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cidadeTextBox.Location = new System.Drawing.Point(497, 326);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(175, 34);
            this.cidadeTextBox.TabIndex = 8;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bairroTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.bairroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bairroTextBox.Location = new System.Drawing.Point(264, 326);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(133, 34);
            this.bairroTextBox.TabIndex = 7;
            // 
            // endTextBox
            // 
            this.endTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.endTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "endereco", true));
            this.endTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.endTextBox.Location = new System.Drawing.Point(264, 262);
            this.endTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(549, 34);
            this.endTextBox.TabIndex = 5;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nomeTextBox.Location = new System.Drawing.Point(264, 153);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(755, 34);
            this.nomeTextBox.TabIndex = 2;
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
            this.panel2.Location = new System.Drawing.Point(0, 607);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 53);
            this.panel2.TabIndex = 179;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(964, 9);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 33);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 1);
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
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProximo.Location = new System.Drawing.Point(603, 7);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(157, 37);
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
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnterior.Location = new System.Drawing.Point(387, 7);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(157, 37);
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
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(59, 11);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(157, 37);
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
            this.panelEdit.Location = new System.Drawing.Point(0, 607);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1165, 53);
            this.panelEdit.TabIndex = 88;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 1);
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
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(759, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 37);
            this.btnCancelar.TabIndex = 16;
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
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(964, 10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(157, 37);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.itensTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VidracariaNovo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadFuncionario";
            this.Text = "frmCadFuncionario";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox cepTextBox;
        private System.Windows.Forms.MaskedTextBox telTextBox;
        private System.Windows.Forms.MaskedTextBox celTextBox;
        private System.Windows.Forms.MaskedTextBox rgTextBox;
        private System.Windows.Forms.MaskedTextBox cpfTextBox;
        private System.Windows.Forms.TextBox funcaoTextBox;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private DataSet1TableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox txtFgts;
    }
}