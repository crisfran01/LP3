namespace VidracariaNovo
{
    partial class frmCadProduto
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
            System.Windows.Forms.Label lucroPorcentLabel;
            System.Windows.Forms.Label lucroReaisLabel;
            System.Windows.Forms.Label precoVendaLabel;
            System.Windows.Forms.Label precoCompraLabel;
            System.Windows.Forms.Label qtdLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label prontLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.txtUnidadeDeMedida = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtLucroP = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.txtPrVenda = new System.Windows.Forms.TextBox();
            this.txtPrCompra = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataSet1 = new VidracariaNovo.DataSet1();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new VidracariaNovo.DataSet1TableAdapters.produtosTableAdapter();
            this.tableAdapterManager = new VidracariaNovo.DataSet1TableAdapters.TableAdapterManager();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.prontTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lucroPorcentLabel = new System.Windows.Forms.Label();
            lucroReaisLabel = new System.Windows.Forms.Label();
            precoVendaLabel = new System.Windows.Forms.Label();
            precoCompraLabel = new System.Windows.Forms.Label();
            qtdLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            prontLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(247, 29);
            this.label4.TabIndex = 95;
            this.label4.Text = "Cadastro de Produtos";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(prontLabel);
            this.panel2.Controls.Add(this.prontTextBox);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.txtUnidadeDeMedida);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(lucroPorcentLabel);
            this.panel2.Controls.Add(this.txtLucroP);
            this.panel2.Controls.Add(lucroReaisLabel);
            this.panel2.Controls.Add(this.txtLucro);
            this.panel2.Controls.Add(precoVendaLabel);
            this.panel2.Controls.Add(this.txtPrVenda);
            this.panel2.Controls.Add(precoCompraLabel);
            this.panel2.Controls.Add(this.txtPrCompra);
            this.panel2.Controls.Add(qtdLabel);
            this.panel2.Controls.Add(this.txtQtde);
            this.panel2.Controls.Add(nomeLabel);
            this.panel2.Controls.Add(this.txtNome);
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
            this.panel2.TabIndex = 98;
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
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(130, 359);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 26);
            label2.TabIndex = 216;
            label2.Text = "Un Medida";
            // 
            // txtUnidadeDeMedida
            // 
            this.txtUnidadeDeMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnidadeDeMedida.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnidadeDeMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidadeDeMedida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "unid_med", true));
            this.txtUnidadeDeMedida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadeDeMedida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUnidadeDeMedida.Location = new System.Drawing.Point(270, 354);
            this.txtUnidadeDeMedida.Margin = new System.Windows.Forms.Padding(0);
            this.txtUnidadeDeMedida.MaxLength = 3;
            this.txtUnidadeDeMedida.Name = "txtUnidadeDeMedida";
            this.txtUnidadeDeMedida.Size = new System.Drawing.Size(114, 34);
            this.txtUnidadeDeMedida.TabIndex = 215;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "descricao", true));
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescricao.Location = new System.Drawing.Point(270, 428);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescricao.MaxLength = 30;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(767, 34);
            this.txtDescricao.TabIndex = 214;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(133, 430);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 26);
            label1.TabIndex = 213;
            label1.Text = "Descrição:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.UseCompatibleTextRendering = true;
            // 
            // lucroPorcentLabel
            // 
            lucroPorcentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            lucroPorcentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lucroPorcentLabel.ForeColor = System.Drawing.SystemColors.Control;
            lucroPorcentLabel.Location = new System.Drawing.Point(799, 359);
            lucroPorcentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lucroPorcentLabel.Name = "lucroPorcentLabel";
            lucroPorcentLabel.Size = new System.Drawing.Size(108, 26);
            lucroPorcentLabel.TabIndex = 212;
            lucroPorcentLabel.Text = "Lucro(%):";
            lucroPorcentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLucroP
            // 
            this.txtLucroP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLucroP.BackColor = System.Drawing.SystemColors.Window;
            this.txtLucroP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLucroP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLucroP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLucroP.Location = new System.Drawing.Point(923, 354);
            this.txtLucroP.Margin = new System.Windows.Forms.Padding(0);
            this.txtLucroP.MaxLength = 3;
            this.txtLucroP.Name = "txtLucroP";
            this.txtLucroP.Size = new System.Drawing.Size(114, 34);
            this.txtLucroP.TabIndex = 211;
            // 
            // lucroReaisLabel
            // 
            lucroReaisLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            lucroReaisLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lucroReaisLabel.ForeColor = System.Drawing.SystemColors.Control;
            lucroReaisLabel.Location = new System.Drawing.Point(501, 359);
            lucroReaisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lucroReaisLabel.Name = "lucroReaisLabel";
            lucroReaisLabel.Size = new System.Drawing.Size(109, 26);
            lucroReaisLabel.TabIndex = 210;
            lucroReaisLabel.Text = "Lucro(R$):";
            lucroReaisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLucro
            // 
            this.txtLucro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLucro.BackColor = System.Drawing.SystemColors.Window;
            this.txtLucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLucro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLucro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLucro.Location = new System.Drawing.Point(618, 354);
            this.txtLucro.Margin = new System.Windows.Forms.Padding(0);
            this.txtLucro.MaxLength = 3;
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(114, 34);
            this.txtLucro.TabIndex = 209;
            // 
            // precoVendaLabel
            // 
            precoVendaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            precoVendaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoVendaLabel.ForeColor = System.Drawing.SystemColors.Control;
            precoVendaLabel.Location = new System.Drawing.Point(755, 294);
            precoVendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precoVendaLabel.Name = "precoVendaLabel";
            precoVendaLabel.Size = new System.Drawing.Size(164, 26);
            precoVendaLabel.TabIndex = 208;
            precoVendaLabel.Text = "Preço de Venda:";
            precoVendaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrVenda
            // 
            this.txtPrVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "pr_venda", true));
            this.txtPrVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrVenda.Location = new System.Drawing.Point(923, 289);
            this.txtPrVenda.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrVenda.MaxLength = 3;
            this.txtPrVenda.Name = "txtPrVenda";
            this.txtPrVenda.Size = new System.Drawing.Size(114, 34);
            this.txtPrVenda.TabIndex = 207;
            // 
            // precoCompraLabel
            // 
            precoCompraLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            precoCompraLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoCompraLabel.ForeColor = System.Drawing.SystemColors.Control;
            precoCompraLabel.Location = new System.Drawing.Point(430, 294);
            precoCompraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precoCompraLabel.Name = "precoCompraLabel";
            precoCompraLabel.Size = new System.Drawing.Size(180, 26);
            precoCompraLabel.TabIndex = 206;
            precoCompraLabel.Text = "Preço de Compra:";
            precoCompraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrCompra
            // 
            this.txtPrCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrCompra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "pr_custo", true));
            this.txtPrCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrCompra.Location = new System.Drawing.Point(618, 289);
            this.txtPrCompra.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrCompra.MaxLength = 3;
            this.txtPrCompra.Name = "txtPrCompra";
            this.txtPrCompra.Size = new System.Drawing.Size(114, 34);
            this.txtPrCompra.TabIndex = 205;
            // 
            // qtdLabel
            // 
            qtdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            qtdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtdLabel.ForeColor = System.Drawing.SystemColors.Control;
            qtdLabel.Location = new System.Drawing.Point(130, 294);
            qtdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qtdLabel.Name = "qtdLabel";
            qtdLabel.Size = new System.Drawing.Size(133, 26);
            qtdLabel.TabIndex = 203;
            qtdLabel.Text = "Quantidade:";
            qtdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQtde
            // 
            this.txtQtde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtde.BackColor = System.Drawing.SystemColors.Window;
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "qntd", true));
            this.txtQtde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQtde.Location = new System.Drawing.Point(270, 289);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(0);
            this.txtQtde.MaxLength = 3;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(114, 34);
            this.txtQtde.TabIndex = 201;
            // 
            // nomeLabel
            // 
            nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            nomeLabel.Location = new System.Drawing.Point(130, 230);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(133, 26);
            nomeLabel.TabIndex = 202;
            nomeLabel.Text = "Nome:";
            nomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(270, 227);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(767, 34);
            this.txtNome.TabIndex = 200;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.dataSet1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.itensTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = VidracariaNovo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(405, 158);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 36);
            this.btnBuscar.TabIndex = 219;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // prontLabel
            // 
            prontLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            prontLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prontLabel.ForeColor = System.Drawing.SystemColors.Control;
            prontLabel.Location = new System.Drawing.Point(128, 160);
            prontLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prontLabel.Name = "prontLabel";
            prontLabel.Size = new System.Drawing.Size(133, 32);
            prontLabel.TabIndex = 218;
            prontLabel.Text = "Codigo";
            // 
            // prontTextBox
            // 
            this.prontTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prontTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.prontTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prontTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "cod", true));
            this.prontTextBox.Enabled = false;
            this.prontTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prontTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prontTextBox.Location = new System.Drawing.Point(271, 159);
            this.prontTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.prontTextBox.Name = "prontTextBox";
            this.prontTextBox.ReadOnly = true;
            this.prontTextBox.Size = new System.Drawing.Size(114, 34);
            this.prontTextBox.TabIndex = 217;
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 660);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadProduto";
            this.Text = "frmCadProduto";
            this.Load += new System.EventHandler(this.frmCadProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.TextBox txtUnidadeDeMedida;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtLucroP;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.TextBox txtPrVenda;
        private System.Windows.Forms.TextBox txtPrCompra;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtNome;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private DataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox prontTextBox;
    }
}