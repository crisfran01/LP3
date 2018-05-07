namespace Psychology
{
    partial class frmTriagem
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
            System.Windows.Forms.Label vlseLabel;
            System.Windows.Forms.Label telEmerLabel;
            System.Windows.Forms.Label contatEmerLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label telRespLabel;
            System.Windows.Forms.Label responsavelLabel;
            System.Windows.Forms.Label estCivilLabel;
            System.Windows.Forms.Label trabalhoLabel;
            System.Windows.Forms.Label escolaridadeLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label numLabel;
            System.Windows.Forms.Label endLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label dtNacLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label prontLabel;
            this.btnFamilia = new System.Windows.Forms.Button();
            this.btnSaude = new System.Windows.Forms.Button();
            this.btnQueixa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cepTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psiEasy = new Psychology.PsiEasy();
            this.telRespTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.telEmerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.triagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rgTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vlseTextBox = new System.Windows.Forms.TextBox();
            this.contatEmerTextBox = new System.Windows.Forms.TextBox();
            this.responsavelTextBox = new System.Windows.Forms.TextBox();
            this.estCivilComboBox = new System.Windows.Forms.ComboBox();
            this.trabalhoTextBox = new System.Windows.Forms.TextBox();
            this.escolaridadeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.prontTextBox = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.triagemTableAdapter = new Psychology.PsiEasyTableAdapters.triagemTableAdapter();
            this.tableAdapterManager = new Psychology.PsiEasyTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Psychology.PsiEasyTableAdapters.clienteTableAdapter();
            this.sessoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessoesTableAdapter = new Psychology.PsiEasyTableAdapters.sessoesTableAdapter();
            vlseLabel = new System.Windows.Forms.Label();
            telEmerLabel = new System.Windows.Forms.Label();
            contatEmerLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            telRespLabel = new System.Windows.Forms.Label();
            responsavelLabel = new System.Windows.Forms.Label();
            estCivilLabel = new System.Windows.Forms.Label();
            trabalhoLabel = new System.Windows.Forms.Label();
            escolaridadeLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            numLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            dtNacLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            prontLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triagemBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vlseLabel
            // 
            vlseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            vlseLabel.AutoSize = true;
            vlseLabel.BackColor = System.Drawing.Color.Transparent;
            vlseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vlseLabel.ForeColor = System.Drawing.SystemColors.Control;
            vlseLabel.Location = new System.Drawing.Point(631, 128);
            vlseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vlseLabel.Name = "vlseLabel";
            vlseLabel.Size = new System.Drawing.Size(125, 28);
            vlseLabel.TabIndex = 222;
            vlseLabel.Text = "Valor Sessão:";
            // 
            // telEmerLabel
            // 
            telEmerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            telEmerLabel.AutoSize = true;
            telEmerLabel.BackColor = System.Drawing.Color.Transparent;
            telEmerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telEmerLabel.ForeColor = System.Drawing.SystemColors.Control;
            telEmerLabel.Location = new System.Drawing.Point(823, 643);
            telEmerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telEmerLabel.Name = "telEmerLabel";
            telEmerLabel.Size = new System.Drawing.Size(87, 28);
            telEmerLabel.TabIndex = 220;
            telEmerLabel.Text = "tel Emer:";
            // 
            // contatEmerLabel
            // 
            contatEmerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            contatEmerLabel.AutoSize = true;
            contatEmerLabel.BackColor = System.Drawing.Color.Transparent;
            contatEmerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contatEmerLabel.ForeColor = System.Drawing.SystemColors.Control;
            contatEmerLabel.Location = new System.Drawing.Point(222, 643);
            contatEmerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contatEmerLabel.Name = "contatEmerLabel";
            contatEmerLabel.Size = new System.Drawing.Size(124, 28);
            contatEmerLabel.TabIndex = 219;
            contatEmerLabel.Text = "Contat Emer:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(734, 386);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 28);
            label2.TabIndex = 218;
            label2.Text = "Cel:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(222, 385);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 28);
            label3.TabIndex = 217;
            label3.Text = "Tel:";
            // 
            // telRespLabel
            // 
            telRespLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            telRespLabel.AutoSize = true;
            telRespLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telRespLabel.ForeColor = System.Drawing.SystemColors.Control;
            telRespLabel.Location = new System.Drawing.Point(819, 595);
            telRespLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telRespLabel.Name = "telRespLabel";
            telRespLabel.Size = new System.Drawing.Size(85, 28);
            telRespLabel.TabIndex = 216;
            telRespLabel.Text = "Tel Resp:";
            // 
            // responsavelLabel
            // 
            responsavelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            responsavelLabel.AutoSize = true;
            responsavelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            responsavelLabel.ForeColor = System.Drawing.SystemColors.Control;
            responsavelLabel.Location = new System.Drawing.Point(222, 594);
            responsavelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            responsavelLabel.Name = "responsavelLabel";
            responsavelLabel.Size = new System.Drawing.Size(123, 28);
            responsavelLabel.TabIndex = 214;
            responsavelLabel.Text = "Responsavel:";
            // 
            // estCivilLabel
            // 
            estCivilLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            estCivilLabel.AutoSize = true;
            estCivilLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estCivilLabel.ForeColor = System.Drawing.SystemColors.Control;
            estCivilLabel.Location = new System.Drawing.Point(822, 541);
            estCivilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estCivilLabel.Name = "estCivilLabel";
            estCivilLabel.Size = new System.Drawing.Size(83, 28);
            estCivilLabel.TabIndex = 212;
            estCivilLabel.Text = "Est Civil:";
            // 
            // trabalhoLabel
            // 
            trabalhoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            trabalhoLabel.AutoSize = true;
            trabalhoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trabalhoLabel.ForeColor = System.Drawing.SystemColors.Control;
            trabalhoLabel.Location = new System.Drawing.Point(535, 541);
            trabalhoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trabalhoLabel.Name = "trabalhoLabel";
            trabalhoLabel.Size = new System.Drawing.Size(91, 28);
            trabalhoLabel.TabIndex = 210;
            trabalhoLabel.Text = "Trabalho:";
            // 
            // escolaridadeLabel
            // 
            escolaridadeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            escolaridadeLabel.AutoSize = true;
            escolaridadeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            escolaridadeLabel.ForeColor = System.Drawing.SystemColors.Control;
            escolaridadeLabel.Location = new System.Drawing.Point(222, 540);
            escolaridadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            escolaridadeLabel.Name = "escolaridadeLabel";
            escolaridadeLabel.Size = new System.Drawing.Size(126, 28);
            escolaridadeLabel.TabIndex = 208;
            escolaridadeLabel.Text = "Escolaridade:";
            // 
            // rgLabel
            // 
            rgLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            rgLabel.AutoSize = true;
            rgLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rgLabel.ForeColor = System.Drawing.SystemColors.Control;
            rgLabel.Location = new System.Drawing.Point(734, 488);
            rgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(42, 28);
            rgLabel.TabIndex = 207;
            rgLabel.Text = "RG:";
            // 
            // cpfLabel
            // 
            cpfLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cpfLabel.AutoSize = true;
            cpfLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpfLabel.ForeColor = System.Drawing.SystemColors.Control;
            cpfLabel.Location = new System.Drawing.Point(222, 488);
            cpfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(49, 28);
            cpfLabel.TabIndex = 206;
            cpfLabel.Text = "CPF:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.SystemColors.Control;
            emailLabel.Location = new System.Drawing.Point(222, 437);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(71, 28);
            emailLabel.TabIndex = 204;
            emailLabel.Text = "E-mail:";
            // 
            // cepLabel
            // 
            cepLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cepLabel.AutoSize = true;
            cepLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cepLabel.ForeColor = System.Drawing.SystemColors.Control;
            cepLabel.Location = new System.Drawing.Point(893, 334);
            cepLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(49, 28);
            cepLabel.TabIndex = 203;
            cepLabel.Text = "CEP:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.ForeColor = System.Drawing.SystemColors.Control;
            cidadeLabel.Location = new System.Drawing.Point(513, 334);
            cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(77, 28);
            cidadeLabel.TabIndex = 200;
            cidadeLabel.Text = "Cidade:";
            // 
            // bairroLabel
            // 
            bairroLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.ForeColor = System.Drawing.SystemColors.Control;
            bairroLabel.Location = new System.Drawing.Point(222, 333);
            bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(68, 28);
            bairroLabel.TabIndex = 198;
            bairroLabel.Text = "Bairro:";
            // 
            // numLabel
            // 
            numLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            numLabel.AutoSize = true;
            numLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numLabel.ForeColor = System.Drawing.SystemColors.Control;
            numLabel.Location = new System.Drawing.Point(947, 283);
            numLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numLabel.Name = "numLabel";
            numLabel.Size = new System.Drawing.Size(40, 28);
            numLabel.TabIndex = 196;
            numLabel.Text = "Nº:";
            // 
            // endLabel
            // 
            endLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            endLabel.AutoSize = true;
            endLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endLabel.ForeColor = System.Drawing.SystemColors.Control;
            endLabel.Location = new System.Drawing.Point(222, 282);
            endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            endLabel.Name = "endLabel";
            endLabel.Size = new System.Drawing.Size(97, 28);
            endLabel.TabIndex = 194;
            endLabel.Text = "Endereço:";
            // 
            // sexoLabel
            // 
            sexoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.ForeColor = System.Drawing.SystemColors.Control;
            sexoLabel.Location = new System.Drawing.Point(538, 231);
            sexoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(58, 28);
            sexoLabel.TabIndex = 192;
            sexoLabel.Text = "Sexo:";
            // 
            // idadeLabel
            // 
            idadeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idadeLabel.AutoSize = true;
            idadeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idadeLabel.ForeColor = System.Drawing.SystemColors.Control;
            idadeLabel.Location = new System.Drawing.Point(222, 230);
            idadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(65, 28);
            idadeLabel.TabIndex = 190;
            idadeLabel.Text = "Idade:";
            // 
            // dtNacLabel
            // 
            dtNacLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtNacLabel.AutoSize = true;
            dtNacLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtNacLabel.ForeColor = System.Drawing.SystemColors.Control;
            dtNacLabel.Location = new System.Drawing.Point(759, 231);
            dtNacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dtNacLabel.Name = "dtNacLabel";
            dtNacLabel.Size = new System.Drawing.Size(96, 28);
            dtNacLabel.TabIndex = 189;
            dtNacLabel.Text = "Data Nac:";
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            nomeLabel.Location = new System.Drawing.Point(222, 178);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(70, 28);
            nomeLabel.TabIndex = 187;
            nomeLabel.Text = "Nome:";
            // 
            // prontLabel
            // 
            prontLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            prontLabel.AutoSize = true;
            prontLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prontLabel.ForeColor = System.Drawing.SystemColors.Control;
            prontLabel.Location = new System.Drawing.Point(222, 126);
            prontLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prontLabel.Name = "prontLabel";
            prontLabel.Size = new System.Drawing.Size(109, 28);
            prontLabel.TabIndex = 185;
            prontLabel.Text = "Prontuario:";
            // 
            // btnFamilia
            // 
            this.btnFamilia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFamilia.BackColor = System.Drawing.Color.Transparent;
            this.btnFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamilia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamilia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnFamilia.Location = new System.Drawing.Point(487, 731);
            this.btnFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(143, 36);
            this.btnFamilia.TabIndex = 171;
            this.btnFamilia.Text = "Familia";
            this.btnFamilia.UseVisualStyleBackColor = false;
            this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
            // 
            // btnSaude
            // 
            this.btnSaude.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaude.BackColor = System.Drawing.Color.Transparent;
            this.btnSaude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSaude.Location = new System.Drawing.Point(659, 731);
            this.btnSaude.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaude.Name = "btnSaude";
            this.btnSaude.Size = new System.Drawing.Size(143, 36);
            this.btnSaude.TabIndex = 172;
            this.btnSaude.Text = "Saúde";
            this.btnSaude.UseVisualStyleBackColor = false;
            this.btnSaude.Click += new System.EventHandler(this.btnSaude_Click);
            // 
            // btnQueixa
            // 
            this.btnQueixa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQueixa.BackColor = System.Drawing.Color.Transparent;
            this.btnQueixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueixa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnQueixa.Location = new System.Drawing.Point(831, 731);
            this.btnQueixa.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueixa.Name = "btnQueixa";
            this.btnQueixa.Size = new System.Drawing.Size(143, 36);
            this.btnQueixa.TabIndex = 173;
            this.btnQueixa.Text = "Queixa";
            this.btnQueixa.UseVisualStyleBackColor = false;
            this.btnQueixa.Click += new System.EventHandler(this.btnQueixa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.cepTextBox);
            this.panel1.Controls.Add(this.telRespTextBox);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.telEmerTextBox);
            this.panel1.Controls.Add(this.telTextBox);
            this.panel1.Controls.Add(this.celTextBox);
            this.panel1.Controls.Add(this.rgTextBox);
            this.panel1.Controls.Add(this.cpfTextBox);
            this.panel1.Controls.Add(vlseLabel);
            this.panel1.Controls.Add(this.vlseTextBox);
            this.panel1.Controls.Add(telEmerLabel);
            this.panel1.Controls.Add(contatEmerLabel);
            this.panel1.Controls.Add(this.contatEmerTextBox);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(telRespLabel);
            this.panel1.Controls.Add(responsavelLabel);
            this.panel1.Controls.Add(this.responsavelTextBox);
            this.panel1.Controls.Add(this.estCivilComboBox);
            this.panel1.Controls.Add(estCivilLabel);
            this.panel1.Controls.Add(trabalhoLabel);
            this.panel1.Controls.Add(this.trabalhoTextBox);
            this.panel1.Controls.Add(escolaridadeLabel);
            this.panel1.Controls.Add(this.escolaridadeTextBox);
            this.panel1.Controls.Add(rgLabel);
            this.panel1.Controls.Add(cpfLabel);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(cepLabel);
            this.panel1.Controls.Add(this.estadoComboBox);
            this.panel1.Controls.Add(cidadeLabel);
            this.panel1.Controls.Add(this.cidadeTextBox);
            this.panel1.Controls.Add(bairroLabel);
            this.panel1.Controls.Add(this.bairroTextBox);
            this.panel1.Controls.Add(numLabel);
            this.panel1.Controls.Add(this.numTextBox);
            this.panel1.Controls.Add(endLabel);
            this.panel1.Controls.Add(this.endTextBox);
            this.panel1.Controls.Add(sexoLabel);
            this.panel1.Controls.Add(this.sexoComboBox);
            this.panel1.Controls.Add(idadeLabel);
            this.panel1.Controls.Add(this.idadeTextBox);
            this.panel1.Controls.Add(dtNacLabel);
            this.panel1.Controls.Add(nomeLabel);
            this.panel1.Controls.Add(this.nomeTextBox);
            this.panel1.Controls.Add(prontLabel);
            this.panel1.Controls.Add(this.prontTextBox);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnQueixa);
            this.panel1.Controls.Add(this.btnSaude);
            this.panel1.Controls.Add(this.btnFamilia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 799);
            this.panel1.TabIndex = 0;
            // 
            // cepTextBox
            // 
            this.cepTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cepTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cep", true));
            this.cepTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cepTextBox.Location = new System.Drawing.Point(958, 330);
            this.cepTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cepTextBox.Mask = "00,000-000";
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(168, 34);
            this.cepTextBox.TabIndex = 231;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.psiEasy;
            // 
            // psiEasy
            // 
            this.psiEasy.DataSetName = "PsiEasy";
            this.psiEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telRespTextBox
            // 
            this.telRespTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telRespTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.telRespTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "TelResp", true));
            this.telRespTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telRespTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telRespTextBox.Location = new System.Drawing.Point(927, 590);
            this.telRespTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telRespTextBox.Mask = "(00)00000-0000";
            this.telRespTextBox.Name = "telRespTextBox";
            this.telRespTextBox.Size = new System.Drawing.Size(203, 34);
            this.telRespTextBox.TabIndex = 230;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "dtNac", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maskedTextBox1.Location = new System.Drawing.Point(869, 226);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(257, 34);
            this.maskedTextBox1.TabIndex = 224;
            // 
            // telEmerTextBox
            // 
            this.telEmerTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telEmerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.telEmerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "telEmer", true));
            this.telEmerTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telEmerTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telEmerTextBox.Location = new System.Drawing.Point(927, 641);
            this.telEmerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telEmerTextBox.Mask = "(00)00000-0000";
            this.telEmerTextBox.Name = "telEmerTextBox";
            this.telEmerTextBox.Size = new System.Drawing.Size(203, 34);
            this.telEmerTextBox.TabIndex = 227;
            // 
            // triagemBindingSource
            // 
            this.triagemBindingSource.DataMember = "triagem";
            this.triagemBindingSource.DataSource = this.psiEasy;
            // 
            // telTextBox
            // 
            this.telTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "tel", true));
            this.telTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telTextBox.Location = new System.Drawing.Point(370, 382);
            this.telTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telTextBox.Mask = "(00)00000-0000";
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(336, 34);
            this.telTextBox.TabIndex = 228;
            // 
            // celTextBox
            // 
            this.celTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.celTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.celTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cel", true));
            this.celTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.celTextBox.Location = new System.Drawing.Point(801, 382);
            this.celTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.celTextBox.Mask = "(00)00000-0000";
            this.celTextBox.Name = "celTextBox";
            this.celTextBox.Size = new System.Drawing.Size(329, 34);
            this.celTextBox.TabIndex = 229;
            // 
            // rgTextBox
            // 
            this.rgTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rgTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "rg", true));
            this.rgTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rgTextBox.Location = new System.Drawing.Point(794, 483);
            this.rgTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rgTextBox.Mask = "00,000,000-C";
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(336, 34);
            this.rgTextBox.TabIndex = 226;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpfTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cpf", true));
            this.cpfTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cpfTextBox.Location = new System.Drawing.Point(369, 483);
            this.cpfTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cpfTextBox.Mask = "000,000,000-00";
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(356, 34);
            this.cpfTextBox.TabIndex = 225;
            // 
            // vlseTextBox
            // 
            this.vlseTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vlseTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.vlseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vlseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "Vlse", true));
            this.vlseTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlseTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vlseTextBox.Location = new System.Drawing.Point(794, 124);
            this.vlseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vlseTextBox.Name = "vlseTextBox";
            this.vlseTextBox.Size = new System.Drawing.Size(333, 34);
            this.vlseTextBox.TabIndex = 223;
            // 
            // contatEmerTextBox
            // 
            this.contatEmerTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contatEmerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.contatEmerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contatEmerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "ContatEmer", true));
            this.contatEmerTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contatEmerTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contatEmerTextBox.Location = new System.Drawing.Point(371, 641);
            this.contatEmerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contatEmerTextBox.MaxLength = 30;
            this.contatEmerTextBox.Name = "contatEmerTextBox";
            this.contatEmerTextBox.Size = new System.Drawing.Size(433, 34);
            this.contatEmerTextBox.TabIndex = 221;
            // 
            // responsavelTextBox
            // 
            this.responsavelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.responsavelTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.responsavelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.responsavelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Responsavel", true));
            this.responsavelTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsavelTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.responsavelTextBox.Location = new System.Drawing.Point(370, 592);
            this.responsavelTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.responsavelTextBox.MaxLength = 30;
            this.responsavelTextBox.Name = "responsavelTextBox";
            this.responsavelTextBox.Size = new System.Drawing.Size(433, 34);
            this.responsavelTextBox.TabIndex = 215;
            // 
            // estCivilComboBox
            // 
            this.estCivilComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estCivilComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.estCivilComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "estCivil", true));
            this.estCivilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estCivilComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.estCivilComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estCivilComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.estCivilComboBox.FormattingEnabled = true;
            this.estCivilComboBox.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Divorciado",
            "Amasiados",
            "Separados",
            "Namorando"});
            this.estCivilComboBox.Location = new System.Drawing.Point(927, 536);
            this.estCivilComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.estCivilComboBox.Name = "estCivilComboBox";
            this.estCivilComboBox.Size = new System.Drawing.Size(203, 36);
            this.estCivilComboBox.TabIndex = 213;
            // 
            // trabalhoTextBox
            // 
            this.trabalhoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trabalhoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.trabalhoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trabalhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "trabalho", true));
            this.trabalhoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabalhoTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trabalhoTextBox.Location = new System.Drawing.Point(643, 538);
            this.trabalhoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.trabalhoTextBox.MaxLength = 20;
            this.trabalhoTextBox.Name = "trabalhoTextBox";
            this.trabalhoTextBox.Size = new System.Drawing.Size(159, 34);
            this.trabalhoTextBox.TabIndex = 211;
            // 
            // escolaridadeTextBox
            // 
            this.escolaridadeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.escolaridadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.escolaridadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escolaridadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "escolaridade", true));
            this.escolaridadeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolaridadeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.escolaridadeTextBox.Location = new System.Drawing.Point(370, 538);
            this.escolaridadeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.escolaridadeTextBox.MaxLength = 15;
            this.escolaridadeTextBox.Name = "escolaridadeTextBox";
            this.escolaridadeTextBox.Size = new System.Drawing.Size(146, 34);
            this.escolaridadeTextBox.TabIndex = 209;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailTextBox.Location = new System.Drawing.Point(370, 434);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.emailTextBox.MaxLength = 30;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(761, 34);
            this.emailTextBox.TabIndex = 205;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estadoComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "estado", true));
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.estadoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.estadoComboBox.Location = new System.Drawing.Point(793, 331);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(73, 36);
            this.estadoComboBox.TabIndex = 202;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cidadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cidade", true));
            this.cidadeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cidadeTextBox.Location = new System.Drawing.Point(602, 331);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cidadeTextBox.MaxLength = 20;
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(175, 34);
            this.cidadeTextBox.TabIndex = 201;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bairroTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.bairroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bairroTextBox.Location = new System.Drawing.Point(371, 331);
            this.bairroTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.bairroTextBox.MaxLength = 15;
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(133, 34);
            this.bairroTextBox.TabIndex = 199;
            // 
            // numTextBox
            // 
            this.numTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.numTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "num", true));
            this.numTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numTextBox.Location = new System.Drawing.Point(1003, 279);
            this.numTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.numTextBox.MaxLength = 5;
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(125, 34);
            this.numTextBox.TabIndex = 197;
            // 
            // endTextBox
            // 
            this.endTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.endTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "ende", true));
            this.endTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.endTextBox.Location = new System.Drawing.Point(373, 279);
            this.endTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.endTextBox.MaxLength = 40;
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(549, 34);
            this.endTextBox.TabIndex = 195;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexoComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Sexo", true));
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sexoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexoComboBox.Location = new System.Drawing.Point(619, 227);
            this.sexoComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(105, 36);
            this.sexoComboBox.TabIndex = 193;
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Idade", true));
            this.idadeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idadeTextBox.Location = new System.Drawing.Point(373, 227);
            this.idadeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(114, 34);
            this.idadeTextBox.TabIndex = 191;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nomeTextBox.Location = new System.Drawing.Point(371, 176);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nomeTextBox.MaxLength = 30;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(755, 34);
            this.nomeTextBox.TabIndex = 188;
            // 
            // prontTextBox
            // 
            this.prontTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prontTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prontTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prontTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triagemBindingSource, "Pront", true));
            this.prontTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prontTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.prontTextBox.Location = new System.Drawing.Point(373, 124);
            this.prontTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prontTextBox.Name = "prontTextBox";
            this.prontTextBox.ReadOnly = true;
            this.prontTextBox.Size = new System.Drawing.Size(89, 34);
            this.prontTextBox.TabIndex = 186;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSalvar.Location = new System.Drawing.Point(1155, 731);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(179, 36);
            this.btnSalvar.TabIndex = 184;
            this.btnSalvar.Text = "Salvar Edições";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.triagemBindingNavigatorSaveItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1353, 34);
            this.panel3.TabIndex = 175;
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
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
            this.label4.Text = "Triagem";
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
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.irmaoTableAdapter = null;
            this.tableAdapterManager.medicamentosTableAdapter = null;
            this.tableAdapterManager.psicologosTableAdapter = null;
            this.tableAdapterManager.sessoesTableAdapter = null;
            this.tableAdapterManager.triagemTableAdapter = this.triagemTableAdapter;
            this.tableAdapterManager.UpdateOrder = Psychology.PsiEasyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // sessoesBindingSource
            // 
            this.sessoesBindingSource.DataMember = "sessoes";
            this.sessoesBindingSource.DataSource = this.psiEasy;
            // 
            // sessoesTableAdapter
            // 
            this.sessoesTableAdapter.ClearBeforeFill = true;
            // 
            // frmTriagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1353, 799);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTriagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTriagem";
            this.Load += new System.EventHandler(this.frmTriagem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psiEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triagemBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFamilia;
        private System.Windows.Forms.Button btnSaude;
        private System.Windows.Forms.Button btnQueixa;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox cepTextBox;
        private System.Windows.Forms.MaskedTextBox telRespTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox telEmerTextBox;
        private System.Windows.Forms.MaskedTextBox telTextBox;
        private System.Windows.Forms.MaskedTextBox celTextBox;
        private System.Windows.Forms.MaskedTextBox rgTextBox;
        private System.Windows.Forms.MaskedTextBox cpfTextBox;
        private System.Windows.Forms.TextBox vlseTextBox;
        private System.Windows.Forms.TextBox contatEmerTextBox;
        private System.Windows.Forms.TextBox responsavelTextBox;
        private System.Windows.Forms.ComboBox estCivilComboBox;
        private System.Windows.Forms.TextBox trabalhoTextBox;
        private System.Windows.Forms.TextBox escolaridadeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox prontTextBox;
        public PsiEasyTableAdapters.clienteTableAdapter clienteTableAdapter;
        public System.Windows.Forms.BindingSource clienteBindingSource;
        public PsiEasy psiEasy;
        public System.Windows.Forms.BindingSource triagemBindingSource;
        public PsiEasyTableAdapters.triagemTableAdapter triagemTableAdapter;
        public PsiEasyTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sessoesBindingSource;
        private PsiEasyTableAdapters.sessoesTableAdapter sessoesTableAdapter;
    }
}