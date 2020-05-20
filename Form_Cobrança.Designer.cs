namespace Projeto_Protocolo
{
    partial class Form_Cobrança
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumSaoluis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnconsultaIE = new System.Windows.Forms.Button();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbdestino = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbsituacao = new System.Windows.Forms.ComboBox();
            this.txtassunto = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            this.dtentrada = new System.Windows.Forms.DateTimePicker();
            this.txtnumProcesso = new System.Windows.Forms.TextBox();
            this.txtNumAuto = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtNumNotif = new System.Windows.Forms.TextBox();
            this.txtnome_razao = new System.Windows.Forms.TextBox();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.LabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtcnpj);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNumSaoluis);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.btnconsultaIE);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbdestino);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.cbsituacao);
            this.tabPage1.Controls.Add(this.txtassunto);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.btnsair);
            this.tabPage1.Controls.Add(this.btnConsultar);
            this.tabPage1.Controls.Add(this.btnenviar);
            this.tabPage1.Controls.Add(this.dtentrada);
            this.tabPage1.Controls.Add(this.txtnumProcesso);
            this.tabPage1.Controls.Add(this.txtNumAuto);
            this.tabPage1.Controls.Add(this.txtvalor);
            this.tabPage1.Controls.Add(this.txtNumNotif);
            this.tabPage1.Controls.Add(this.txtnome_razao);
            this.tabPage1.Controls.Add(this.txtIE);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(666, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 83;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtcnpj
            // 
            this.txtcnpj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnpj.Location = new System.Drawing.Point(510, 89);
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(150, 21);
            this.txtcnpj.TabIndex = 82;
            this.txtcnpj.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(507, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "CNPJ:";
            // 
            // txtNumSaoluis
            // 
            this.txtNumSaoluis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSaoluis.Location = new System.Drawing.Point(158, 34);
            this.txtNumSaoluis.Name = "txtNumSaoluis";
            this.txtNumSaoluis.Size = new System.Drawing.Size(121, 21);
            this.txtNumSaoluis.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(155, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Nº do Processo São Luis:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpar.Location = new System.Drawing.Point(378, 420);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 78;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnconsultaIE
            // 
            this.btnconsultaIE.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultaIE.ForeColor = System.Drawing.Color.Red;
            this.btnconsultaIE.Location = new System.Drawing.Point(158, 89);
            this.btnconsultaIE.Name = "btnconsultaIE";
            this.btnconsultaIE.Size = new System.Drawing.Size(95, 23);
            this.btnconsultaIE.TabIndex = 4;
            this.btnconsultaIE.Text = "Consultar";
            this.btnconsultaIE.UseVisualStyleBackColor = true;
            this.btnconsultaIE.Click += new System.EventHandler(this.btnconsultaIE_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(272, 89);
            this.txtcpf.Mask = "00000000000";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(111, 21);
            this.txtcpf.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(269, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "CPF:";
            // 
            // cbdestino
            // 
            this.cbdestino.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdestino.FormattingEnabled = true;
            this.cbdestino.Items.AddRange(new object[] {
            "Agesp de Imperatriz",
            "Tarf de 1ª Instância",
            "Tarf de 2 ª Instância",
            "Arquivo/Sefaz",
            "Corregedoria",
            "Assjur",
            "Cegaf/Agência",
            "Cotea/Dívida Ativa",
            "Ufre/Imperatriz",
            "Pge"});
            this.cbdestino.Location = new System.Drawing.Point(197, 209);
            this.cbdestino.Name = "cbdestino";
            this.cbdestino.Size = new System.Drawing.Size(167, 23);
            this.cbdestino.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(194, 189);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 17);
            this.label20.TabIndex = 76;
            this.label20.Text = "Destino:";
            // 
            // cbsituacao
            // 
            this.cbsituacao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsituacao.FormattingEnabled = true;
            this.cbsituacao.Items.AddRange(new object[] {
            "Julgado",
            "Autoinfração",
            "Notificação",
            "Prazo de Ciência ",
            "Cientificação de Defesa",
            "Cientificação de Acordão",
            "Pedido de Parcelamento",
            "Parcelamento",
            "Impugnação",
            "Recurso Voluntário",
            "Recurso de Oficío",
            "Remisso",
            "Quitado",
            "Despacho",
            "Pedido/outros",
            "Revisão de Oficío"});
            this.cbsituacao.Location = new System.Drawing.Point(10, 209);
            this.cbsituacao.Name = "cbsituacao";
            this.cbsituacao.Size = new System.Drawing.Size(167, 23);
            this.cbsituacao.TabIndex = 8;
            // 
            // txtassunto
            // 
            this.txtassunto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtassunto.Location = new System.Drawing.Point(10, 320);
            this.txtassunto.Name = "txtassunto";
            this.txtassunto.Size = new System.Drawing.Size(432, 82);
            this.txtassunto.TabIndex = 12;
            this.txtassunto.Text = "";
            this.txtassunto.TextChanged += new System.EventHandler(this.txtassunto_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(7, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 17);
            this.label19.TabIndex = 72;
            this.label19.Text = "Assunto:";
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.Red;
            this.btnsair.Location = new System.Drawing.Point(482, 420);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 14;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Red;
            this.btnConsultar.Location = new System.Drawing.Point(389, 87);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.Color.Red;
            this.btnenviar.Location = new System.Drawing.Point(272, 420);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 13;
            this.btnenviar.Text = "Salvar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtentrada
            // 
            this.dtentrada.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtentrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtentrada.Location = new System.Drawing.Point(10, 264);
            this.dtentrada.Name = "dtentrada";
            this.dtentrada.Size = new System.Drawing.Size(142, 21);
            this.dtentrada.TabIndex = 11;
            // 
            // txtnumProcesso
            // 
            this.txtnumProcesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnumProcesso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumProcesso.Location = new System.Drawing.Point(10, 34);
            this.txtnumProcesso.Name = "txtnumProcesso";
            this.txtnumProcesso.Size = new System.Drawing.Size(123, 21);
            this.txtnumProcesso.TabIndex = 0;
            // 
            // txtNumAuto
            // 
            this.txtNumAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumAuto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAuto.Location = new System.Drawing.Point(343, 34);
            this.txtNumAuto.Name = "txtNumAuto";
            this.txtNumAuto.Size = new System.Drawing.Size(123, 21);
            this.txtNumAuto.TabIndex = 1;
            // 
            // txtvalor
            // 
            this.txtvalor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvalor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(396, 211);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(87, 21);
            this.txtvalor.TabIndex = 10;
            // 
            // txtNumNotif
            // 
            this.txtNumNotif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumNotif.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumNotif.Location = new System.Drawing.Point(487, 34);
            this.txtNumNotif.Name = "txtNumNotif";
            this.txtNumNotif.Size = new System.Drawing.Size(161, 21);
            this.txtNumNotif.TabIndex = 2;
            this.txtNumNotif.TextChanged += new System.EventHandler(this.txtNumNotif_TextChanged);
            // 
            // txtnome_razao
            // 
            this.txtnome_razao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome_razao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome_razao.Location = new System.Drawing.Point(10, 152);
            this.txtnome_razao.Name = "txtnome_razao";
            this.txtnome_razao.Size = new System.Drawing.Size(473, 21);
            this.txtnome_razao.TabIndex = 7;
            // 
            // txtIE
            // 
            this.txtIE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIE.Location = new System.Drawing.Point(10, 89);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(142, 21);
            this.txtIE.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(7, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 17);
            this.label17.TabIndex = 60;
            this.label17.Text = "Data de Entrada:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(393, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Valor Debito:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(7, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 58;
            this.label13.Text = "Situação:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(484, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "Nº Notificação:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(340, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "Nº do Auto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(7, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Nome/Razão Social:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(7, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Nº do Processo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(7, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "I.E:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.LabelProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // LabelProgress
            // 
            this.LabelProgress.Name = "LabelProgress";
            this.LabelProgress.Size = new System.Drawing.Size(109, 17);
            this.LabelProgress.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(866, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Cobrança
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(866, 559);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form_Cobrança";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro de Processos ";
            this.Activated += new System.EventHandler(this.Form_Cobrança_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbdestino;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbsituacao;
        private System.Windows.Forms.RichTextBox txtassunto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.DateTimePicker dtentrada;
        private System.Windows.Forms.TextBox txtnumProcesso;
        private System.Windows.Forms.TextBox txtNumAuto;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtNumNotif;
        private System.Windows.Forms.TextBox txtnome_razao;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnconsultaIE;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel LabelProgress;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNumSaoluis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcnpj;
        private System.Windows.Forms.Label label2;

    }
}