namespace VidracariaNovo
{
    partial class frmCadCliente
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
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label numLabel;
            System.Windows.Forms.Label endLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label dtNacLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label prontLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtNacTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VidracariaNovo.DataSet1();
            this.cepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rgTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.prontTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new VidracariaNovo.DataSet1TableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new VidracariaNovo.DataSet1TableAdapters.TableAdapterManager();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            numLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            dtNacLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            prontLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(645, 469);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 24);
            label2.TabIndex = 221;
            label2.Text = "Cel:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(128, 466);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 26);
            label3.TabIndex = 220;
            label3.Text = "Tel:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rgLabel
            // 
            rgLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            rgLabel.AutoSize = true;
            rgLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rgLabel.ForeColor = System.Drawing.SystemColors.Control;
            rgLabel.Location = new System.Drawing.Point(644, 286);
            rgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(45, 24);
            rgLabel.TabIndex = 217;
            rgLabel.Text = "RG:";
            // 
            // cpfLabel
            // 
            cpfLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cpfLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpfLabel.ForeColor = System.Drawing.SystemColors.Control;
            cpfLabel.Location = new System.Drawing.Point(128, 282);
            cpfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(133, 26);
            cpfLabel.TabIndex = 216;
            cpfLabel.Text = "CPF:";
            cpfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.SystemColors.Control;
            emailLabel.Location = new System.Drawing.Point(128, 524);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(133, 26);
            emailLabel.TabIndex = 215;
            emailLabel.Text = "E-mail:";
            emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cepLabel
            // 
            cepLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cepLabel.AutoSize = true;
            cepLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cepLabel.ForeColor = System.Drawing.SystemColors.Control;
            cepLabel.Location = new System.Drawing.Point(802, 404);
            cepLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(54, 24);
            cepLabel.TabIndex = 214;
            cepLabel.Text = "CEP:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.SystemColors.Control;
            cidadeLabel.Location = new System.Drawing.Point(426, 404);
            cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(77, 24);
            cidadeLabel.TabIndex = 213;
            cidadeLabel.Text = "Cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            bairroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.ForeColor = System.Drawing.SystemColors.Control;
            bairroLabel.Location = new System.Drawing.Point(128, 403);
            bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(133, 26);
            bairroLabel.TabIndex = 212;
            bairroLabel.Text = "Bairro:";
            bairroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numLabel
            // 
            numLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            numLabel.AutoSize = true;
            numLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numLabel.ForeColor = System.Drawing.SystemColors.Control;
            numLabel.Location = new System.Drawing.Point(856, 341);
            numLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numLabel.Name = "numLabel";
            numLabel.Size = new System.Drawing.Size(41, 24);
            numLabel.TabIndex = 211;
            numLabel.Text = "Nº:";
            // 
            // endLabel
            // 
            endLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            endLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endLabel.ForeColor = System.Drawing.SystemColors.Control;
            endLabel.Location = new System.Drawing.Point(128, 340);
            endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            endLabel.Name = "endLabel";
            endLabel.Size = new System.Drawing.Size(133, 26);
            endLabel.TabIndex = 210;
            endLabel.Text = "Endereço:";
            endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sexoLabel
            // 
            sexoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.ForeColor = System.Drawing.SystemColors.Control;
            sexoLabel.Location = new System.Drawing.Point(130, 224);
            sexoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(58, 24);
            sexoLabel.TabIndex = 209;
            sexoLabel.Text = "Sexo:";
            // 
            // dtNacLabel
            // 
            dtNacLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtNacLabel.AutoSize = true;
            dtNacLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtNacLabel.ForeColor = System.Drawing.SystemColors.Control;
            dtNacLabel.Location = new System.Drawing.Point(645, 223);
            dtNacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dtNacLabel.Name = "dtNacLabel";
            dtNacLabel.Size = new System.Drawing.Size(97, 24);
            dtNacLabel.TabIndex = 207;
            dtNacLabel.Text = "Data Nac:";
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            nomeLabel.Location = new System.Drawing.Point(128, 163);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(133, 26);
            nomeLabel.TabIndex = 206;
            nomeLabel.Text = "Nome:";
            nomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prontLabel
            // 
            prontLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            prontLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prontLabel.ForeColor = System.Drawing.SystemColors.Control;
            prontLabel.Location = new System.Drawing.Point(128, 106);
            prontLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prontLabel.Name = "prontLabel";
            prontLabel.Size = new System.Drawing.Size(133, 32);
            prontLabel.TabIndex = 205;
            prontLabel.Text = "Codigo";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.dtNacTextBox);
            this.panel2.Controls.Add(this.cepTextBox);
            this.panel2.Controls.Add(this.telTextBox);
            this.panel2.Controls.Add(this.celTextBox);
            this.panel2.Controls.Add(this.rgTextBox);
            this.panel2.Controls.Add(this.cpfTextBox);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(rgLabel);
            this.panel2.Controls.Add(cpfLabel);
            this.panel2.Controls.Add(emailLabel);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(cepLabel);
            this.panel2.Controls.Add(this.estadoComboBox);
            this.panel2.Controls.Add(cidadeLabel);
            this.panel2.Controls.Add(this.cidadeTextBox);
            this.panel2.Controls.Add(bairroLabel);
            this.panel2.Controls.Add(this.bairroTextBox);
            this.panel2.Controls.Add(numLabel);
            this.panel2.Controls.Add(this.numTextBox);
            this.panel2.Controls.Add(endLabel);
            this.panel2.Controls.Add(this.endTextBox);
            this.panel2.Controls.Add(sexoLabel);
            this.panel2.Controls.Add(this.sexoComboBox);
            this.panel2.Controls.Add(dtNacLabel);
            this.panel2.Controls.Add(nomeLabel);
            this.panel2.Controls.Add(this.nomeTextBox);
            this.panel2.Controls.Add(prontLabel);
            this.panel2.Controls.Add(this.prontTextBox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panelEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 660);
            this.panel2.TabIndex = 97;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtNacTextBox
            // 
            this.dtNacTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtNacTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dtNacTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtNacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "data_nasc", true));
            this.dtNacTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNacTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtNacTextBox.Location = new System.Drawing.Point(756, 218);
            this.dtNacTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dtNacTextBox.Mask = "00/00/0000";
            this.dtNacTextBox.Name = "dtNacTextBox";
            this.dtNacTextBox.Size = new System.Drawing.Size(281, 34);
            this.dtNacTextBox.TabIndex = 193;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cepTextBox
            // 
            this.cepTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cepTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cepTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CEP", true));
            this.cepTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cepTextBox.Location = new System.Drawing.Point(868, 399);
            this.cepTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cepTextBox.Mask = "00,000-000";
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(169, 34);
            this.cepTextBox.TabIndex = 201;
            // 
            // telTextBox
            // 
            this.telTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.telTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "tel", true));
            this.telTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telTextBox.Location = new System.Drawing.Point(269, 463);
            this.telTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telTextBox.Mask = "(00)00000-0000";
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(337, 34);
            this.telTextBox.TabIndex = 202;
            // 
            // celTextBox
            // 
            this.celTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.celTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.celTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cel", true));
            this.celTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.celTextBox.Location = new System.Drawing.Point(706, 463);
            this.celTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.celTextBox.Mask = "(00)00000-0000";
            this.celTextBox.Name = "celTextBox";
            this.celTextBox.Size = new System.Drawing.Size(330, 34);
            this.celTextBox.TabIndex = 203;
            // 
            // rgTextBox
            // 
            this.rgTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rgTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.rgTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "RG", true));
            this.rgTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rgTextBox.Location = new System.Drawing.Point(700, 278);
            this.rgTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rgTextBox.Mask = "00,000,000-C";
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(337, 34);
            this.rgTextBox.TabIndex = 195;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpfTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cpfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CPF", true));
            this.cpfTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cpfTextBox.Location = new System.Drawing.Point(269, 278);
            this.cpfTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cpfTextBox.Mask = "000,000,000-00";
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(357, 34);
            this.cpfTextBox.TabIndex = 194;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(410, 104);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 36);
            this.btnBuscar.TabIndex = 222;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailTextBox.Location = new System.Drawing.Point(269, 522);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextBox.MaxLength = 30;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(767, 34);
            this.emailTextBox.TabIndex = 204;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estadoComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "UF", true));
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.estadoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "",
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
            this.estadoComboBox.Location = new System.Drawing.Point(706, 398);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(73, 36);
            this.estadoComboBox.TabIndex = 200;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cidadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cidade", true));
            this.cidadeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cidadeTextBox.Location = new System.Drawing.Point(516, 399);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cidadeTextBox.MaxLength = 20;
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(175, 34);
            this.cidadeTextBox.TabIndex = 199;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bairroTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.bairroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bairroTextBox.Location = new System.Drawing.Point(269, 399);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.bairroTextBox.MaxLength = 15;
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(133, 34);
            this.bairroTextBox.TabIndex = 198;
            // 
            // numTextBox
            // 
            this.numTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.numTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "num", true));
            this.numTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numTextBox.Location = new System.Drawing.Point(914, 337);
            this.numTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.numTextBox.MaxLength = 5;
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(122, 34);
            this.numTextBox.TabIndex = 197;
            // 
            // endTextBox
            // 
            this.endTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.endTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "end", true));
            this.endTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endTextBox.Location = new System.Drawing.Point(269, 337);
            this.endTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.endTextBox.MaxLength = 40;
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(549, 34);
            this.endTextBox.TabIndex = 196;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexoComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "sexo", true));
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sexoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexoComboBox.Location = new System.Drawing.Point(269, 217);
            this.sexoComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(356, 36);
            this.sexoComboBox.TabIndex = 192;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeTextBox.Location = new System.Drawing.Point(269, 160);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeTextBox.MaxLength = 30;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(767, 34);
            this.nomeTextBox.TabIndex = 190;
            // 
            // prontTextBox
            // 
            this.prontTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prontTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prontTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prontTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cod", true));
            this.prontTextBox.Enabled = false;
            this.prontTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prontTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prontTextBox.Location = new System.Drawing.Point(269, 105);
            this.prontTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.prontTextBox.Name = "prontTextBox";
            this.prontTextBox.ReadOnly = true;
            this.prontTextBox.Size = new System.Drawing.Size(114, 34);
            this.prontTextBox.TabIndex = 188;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 34);
            this.panel1.TabIndex = 187;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(64, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 29);
            this.label4.TabIndex = 95;
            this.label4.Text = "Cadastro de Clientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 565);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 140;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel6.Controls.Add(this.btnEdit);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.btnProximo);
            this.panel6.Controls.Add(this.btnAnterior);
            this.panel6.Controls.Add(this.btnNovo);
            this.panel6.Location = new System.Drawing.Point(0, 613);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1165, 49);
            this.panel6.TabIndex = 98;
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
            this.btnEdit.Location = new System.Drawing.Point(963, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 33);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1165, 1);
            this.panel5.TabIndex = 7;
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
            this.btnProximo.Location = new System.Drawing.Point(602, 3);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(157, 33);
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
            this.btnAnterior.Location = new System.Drawing.Point(386, 3);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(157, 33);
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
            this.btnNovo.Location = new System.Drawing.Point(59, 7);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(157, 33);
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
            this.panelEdit.Location = new System.Drawing.Point(0, 612);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(4);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1165, 53);
            this.panelEdit.TabIndex = 99;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnCancelar.Location = new System.Drawing.Point(758, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 37);
            this.btnCancelar.TabIndex = 25;
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
            this.btnSalvar.Location = new System.Drawing.Point(963, 10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(157, 37);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.itensTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VidracariaNovo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 660);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadCliente";
            this.Text = "frmCadCliente";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSet1TableAdapters.clientesTableAdapter clientesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox dtNacTextBox;
        private System.Windows.Forms.MaskedTextBox cepTextBox;
        private System.Windows.Forms.MaskedTextBox telTextBox;
        private System.Windows.Forms.MaskedTextBox celTextBox;
        private System.Windows.Forms.MaskedTextBox rgTextBox;
        private System.Windows.Forms.MaskedTextBox cpfTextBox;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox prontTextBox;
    }
}