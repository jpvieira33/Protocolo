namespace Projeto_Protocolo
{
    partial class Form_Parecer_Processo
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.label8 = new System.Windows.Forms.Label();
        	this.label10 = new System.Windows.Forms.Label();
        	this.label11 = new System.Windows.Forms.Label();
        	this.label12 = new System.Windows.Forms.Label();
        	this.label13 = new System.Windows.Forms.Label();
        	this.txtnumprocesso = new System.Windows.Forms.TextBox();
        	this.txtdestino = new System.Windows.Forms.TextBox();
        	this.txtnomerazao = new System.Windows.Forms.TextBox();
        	this.txtcnpj = new System.Windows.Forms.TextBox();
        	this.txtIE = new System.Windows.Forms.TextBox();
        	this.cbtipocliente = new System.Windows.Forms.ComboBox();
        	this.txtdatasaida = new System.Windows.Forms.DateTimePicker();
        	this.txtassunto = new System.Windows.Forms.RichTextBox();
        	this.txtobservacao = new System.Windows.Forms.RichTextBox();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.txttipoparecer = new System.Windows.Forms.TextBox();
        	this.txtcpf = new System.Windows.Forms.MaskedTextBox();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.txtdataentrada = new System.Windows.Forms.DateTimePicker();
        	this.btnConsultar = new System.Windows.Forms.Button();
        	this.btnSalvar = new System.Windows.Forms.Button();
        	this.btnLimpar = new System.Windows.Forms.Button();
        	this.btnSair = new System.Windows.Forms.Button();
        	this.btnAlterar = new System.Windows.Forms.Button();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
        	this.LabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.label9 = new System.Windows.Forms.Label();
        	this.txtusuarioprocesso = new System.Windows.Forms.TextBox();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	this.statusStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.Blue;
        	this.label1.Location = new System.Drawing.Point(19, 29);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(114, 17);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Nº do Processo:";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.Blue;
        	this.label2.Location = new System.Drawing.Point(300, 29);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(109, 17);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Tipo de Cliente:";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.Blue;
        	this.label3.Location = new System.Drawing.Point(19, 81);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(33, 17);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "I.E.:";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.Color.Blue;
        	this.label4.Location = new System.Drawing.Point(180, 81);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(42, 17);
        	this.label4.TabIndex = 3;
        	this.label4.Text = "CPF:";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.ForeColor = System.Drawing.Color.Blue;
        	this.label5.Location = new System.Drawing.Point(19, 130);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(142, 17);
        	this.label5.TabIndex = 4;
        	this.label5.Text = "Nome/Razão Social:";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.ForeColor = System.Drawing.Color.Blue;
        	this.label6.Location = new System.Drawing.Point(336, 81);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(50, 17);
        	this.label6.TabIndex = 5;
        	this.label6.Text = "CNPJ:";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.ForeColor = System.Drawing.Color.Blue;
        	this.label7.Location = new System.Drawing.Point(19, 183);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(118, 17);
        	this.label7.TabIndex = 6;
        	this.label7.Text = "Data de Entrada:";
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label8.ForeColor = System.Drawing.Color.Blue;
        	this.label8.Location = new System.Drawing.Point(284, 44);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(104, 17);
        	this.label8.TabIndex = 7;
        	this.label8.Text = "Data de Saída:";
        	// 
        	// label10
        	// 
        	this.label10.AutoSize = true;
        	this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label10.ForeColor = System.Drawing.Color.Blue;
        	this.label10.Location = new System.Drawing.Point(19, 234);
        	this.label10.Name = "label10";
        	this.label10.Size = new System.Drawing.Size(62, 17);
        	this.label10.TabIndex = 9;
        	this.label10.Text = "Destino:";
        	// 
        	// label11
        	// 
        	this.label11.AutoSize = true;
        	this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label11.ForeColor = System.Drawing.Color.Blue;
        	this.label11.Location = new System.Drawing.Point(309, 183);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(65, 17);
        	this.label11.TabIndex = 10;
        	this.label11.Text = "Assunto:";
        	// 
        	// label12
        	// 
        	this.label12.AutoSize = true;
        	this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label12.ForeColor = System.Drawing.Color.Blue;
        	this.label12.Location = new System.Drawing.Point(23, 44);
        	this.label12.Name = "label12";
        	this.label12.Size = new System.Drawing.Size(116, 17);
        	this.label12.TabIndex = 11;
        	this.label12.Text = "Tipo de Parecer:";
        	// 
        	// label13
        	// 
        	this.label13.AutoSize = true;
        	this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label13.ForeColor = System.Drawing.Color.Blue;
        	this.label13.Location = new System.Drawing.Point(23, 92);
        	this.label13.Name = "label13";
        	this.label13.Size = new System.Drawing.Size(92, 17);
        	this.label13.TabIndex = 12;
        	this.label13.Text = "Observação:";
        	// 
        	// txtnumprocesso
        	// 
        	this.txtnumprocesso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtnumprocesso.Location = new System.Drawing.Point(22, 49);
        	this.txtnumprocesso.Name = "txtnumprocesso";
        	this.txtnumprocesso.Size = new System.Drawing.Size(131, 21);
        	this.txtnumprocesso.TabIndex = 0;
        	// 
        	// txtdestino
        	// 
        	this.txtdestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtdestino.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtdestino.Location = new System.Drawing.Point(22, 254);
        	this.txtdestino.Name = "txtdestino";
        	this.txtdestino.Size = new System.Drawing.Size(240, 21);
        	this.txtdestino.TabIndex = 8;
        	// 
        	// txtnomerazao
        	// 
        	this.txtnomerazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtnomerazao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtnomerazao.Location = new System.Drawing.Point(22, 150);
        	this.txtnomerazao.Name = "txtnomerazao";
        	this.txtnomerazao.Size = new System.Drawing.Size(514, 21);
        	this.txtnomerazao.TabIndex = 6;
        	this.txtnomerazao.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
        	// 
        	// txtcnpj
        	// 
        	this.txtcnpj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtcnpj.Location = new System.Drawing.Point(339, 101);
        	this.txtcnpj.Name = "txtcnpj";
        	this.txtcnpj.Size = new System.Drawing.Size(131, 21);
        	this.txtcnpj.TabIndex = 5;
        	// 
        	// txtIE
        	// 
        	this.txtIE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtIE.Location = new System.Drawing.Point(22, 101);
        	this.txtIE.Name = "txtIE";
        	this.txtIE.Size = new System.Drawing.Size(131, 21);
        	this.txtIE.TabIndex = 3;
        	// 
        	// cbtipocliente
        	// 
        	this.cbtipocliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbtipocliente.FormattingEnabled = true;
        	this.cbtipocliente.Items.AddRange(new object[] {
        	        	        	"P. FISÍCA",
        	        	        	"P. JURIDICA"});
        	this.cbtipocliente.Location = new System.Drawing.Point(303, 49);
        	this.cbtipocliente.Name = "cbtipocliente";
        	this.cbtipocliente.Size = new System.Drawing.Size(145, 23);
        	this.cbtipocliente.TabIndex = 2;
        	// 
        	// txtdatasaida
        	// 
        	this.txtdatasaida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtdatasaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.txtdatasaida.Location = new System.Drawing.Point(287, 64);
        	this.txtdatasaida.Name = "txtdatasaida";
        	this.txtdatasaida.Size = new System.Drawing.Size(140, 21);
        	this.txtdatasaida.TabIndex = 11;
        	// 
        	// txtassunto
        	// 
        	this.txtassunto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtassunto.Location = new System.Drawing.Point(312, 203);
        	this.txtassunto.Name = "txtassunto";
        	this.txtassunto.Size = new System.Drawing.Size(278, 71);
        	this.txtassunto.TabIndex = 9;
        	this.txtassunto.Text = "";
        	// 
        	// txtobservacao
        	// 
        	this.txtobservacao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtobservacao.Location = new System.Drawing.Point(26, 112);
        	this.txtobservacao.Name = "txtobservacao";
        	this.txtobservacao.Size = new System.Drawing.Size(278, 71);
        	this.txtobservacao.TabIndex = 12;
        	this.txtobservacao.Text = "";
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.button1);
        	this.groupBox1.Controls.Add(this.txttipoparecer);
        	this.groupBox1.Controls.Add(this.label13);
        	this.groupBox1.Controls.Add(this.txtobservacao);
        	this.groupBox1.Controls.Add(this.label12);
        	this.groupBox1.Controls.Add(this.txtdatasaida);
        	this.groupBox1.Controls.Add(this.label8);
        	this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.groupBox1.Location = new System.Drawing.Point(32, 360);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(719, 204);
        	this.groupBox1.TabIndex = 26;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Rotina do Processo";
        	// 
        	// button1
        	// 
        	this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button1.ForeColor = System.Drawing.Color.Red;
        	this.button1.Location = new System.Drawing.Point(471, 62);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(184, 23);
        	this.button1.TabIndex = 13;
        	this.button1.Text = "Consultar Parecer";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// txttipoparecer
        	// 
        	this.txttipoparecer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txttipoparecer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txttipoparecer.Location = new System.Drawing.Point(26, 64);
        	this.txttipoparecer.Name = "txttipoparecer";
        	this.txttipoparecer.Size = new System.Drawing.Size(200, 21);
        	this.txttipoparecer.TabIndex = 10;
        	// 
        	// txtcpf
        	// 
        	this.txtcpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtcpf.Location = new System.Drawing.Point(183, 101);
        	this.txtcpf.Mask = "00000000000";
        	this.txtcpf.Name = "txtcpf";
        	this.txtcpf.Size = new System.Drawing.Size(121, 21);
        	this.txtcpf.TabIndex = 4;
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.txtusuarioprocesso);
        	this.groupBox2.Controls.Add(this.label9);
        	this.groupBox2.Controls.Add(this.txtdataentrada);
        	this.groupBox2.Controls.Add(this.btnConsultar);
        	this.groupBox2.Controls.Add(this.label1);
        	this.groupBox2.Controls.Add(this.txtassunto);
        	this.groupBox2.Controls.Add(this.txtnumprocesso);
        	this.groupBox2.Controls.Add(this.label11);
        	this.groupBox2.Controls.Add(this.txtdestino);
        	this.groupBox2.Controls.Add(this.txtcpf);
        	this.groupBox2.Controls.Add(this.label10);
        	this.groupBox2.Controls.Add(this.label2);
        	this.groupBox2.Controls.Add(this.txtnomerazao);
        	this.groupBox2.Controls.Add(this.txtcnpj);
        	this.groupBox2.Controls.Add(this.cbtipocliente);
        	this.groupBox2.Controls.Add(this.label7);
        	this.groupBox2.Controls.Add(this.label3);
        	this.groupBox2.Controls.Add(this.txtIE);
        	this.groupBox2.Controls.Add(this.label4);
        	this.groupBox2.Controls.Add(this.label5);
        	this.groupBox2.Controls.Add(this.label6);
        	this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.groupBox2.Location = new System.Drawing.Point(32, 12);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(719, 316);
        	this.groupBox2.TabIndex = 29;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Dados do Processo";
        	// 
        	// txtdataentrada
        	// 
        	this.txtdataentrada.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtdataentrada.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtdataentrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.txtdataentrada.Location = new System.Drawing.Point(22, 204);
        	this.txtdataentrada.Name = "txtdataentrada";
        	this.txtdataentrada.Size = new System.Drawing.Size(139, 21);
        	this.txtdataentrada.TabIndex = 11;
        	// 
        	// btnConsultar
        	// 
        	this.btnConsultar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnConsultar.ForeColor = System.Drawing.Color.Red;
        	this.btnConsultar.Location = new System.Drawing.Point(168, 46);
        	this.btnConsultar.Name = "btnConsultar";
        	this.btnConsultar.Size = new System.Drawing.Size(104, 23);
        	this.btnConsultar.TabIndex = 1;
        	this.btnConsultar.Text = "Consultar";
        	this.btnConsultar.UseVisualStyleBackColor = true;
        	this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
        	// 
        	// btnSalvar
        	// 
        	this.btnSalvar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnSalvar.ForeColor = System.Drawing.Color.Red;
        	this.btnSalvar.Location = new System.Drawing.Point(121, 585);
        	this.btnSalvar.Name = "btnSalvar";
        	this.btnSalvar.Size = new System.Drawing.Size(104, 23);
        	this.btnSalvar.TabIndex = 13;
        	this.btnSalvar.Text = "Salvar";
        	this.btnSalvar.UseVisualStyleBackColor = true;
        	this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
        	// 
        	// btnLimpar
        	// 
        	this.btnLimpar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnLimpar.ForeColor = System.Drawing.Color.Red;
        	this.btnLimpar.Location = new System.Drawing.Point(371, 585);
        	this.btnLimpar.Name = "btnLimpar";
        	this.btnLimpar.Size = new System.Drawing.Size(104, 23);
        	this.btnLimpar.TabIndex = 15;
        	this.btnLimpar.Text = "Limpar";
        	this.btnLimpar.UseVisualStyleBackColor = true;
        	this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
        	// 
        	// btnSair
        	// 
        	this.btnSair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnSair.ForeColor = System.Drawing.Color.Red;
        	this.btnSair.Location = new System.Drawing.Point(503, 585);
        	this.btnSair.Name = "btnSair";
        	this.btnSair.Size = new System.Drawing.Size(104, 23);
        	this.btnSair.TabIndex = 16;
        	this.btnSair.Text = "Sair";
        	this.btnSair.UseVisualStyleBackColor = true;
        	this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
        	// 
        	// btnAlterar
        	// 
        	this.btnAlterar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnAlterar.ForeColor = System.Drawing.Color.Red;
        	this.btnAlterar.Location = new System.Drawing.Point(245, 585);
        	this.btnAlterar.Name = "btnAlterar";
        	this.btnAlterar.Size = new System.Drawing.Size(104, 23);
        	this.btnAlterar.TabIndex = 14;
        	this.btnAlterar.Text = "Alterar";
        	this.btnAlterar.UseVisualStyleBackColor = true;
        	this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.BackColor = System.Drawing.Color.Silver;
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.ProgressBar1,
        	        	        	this.LabelProgress});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 644);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(790, 22);
        	this.statusStrip1.TabIndex = 34;
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
        	// timer1
        	// 
        	this.timer1.Enabled = true;
        	this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        	// 
        	// label9
        	// 
        	this.label9.ForeColor = System.Drawing.Color.Blue;
        	this.label9.Location = new System.Drawing.Point(508, 29);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(100, 23);
        	this.label9.TabIndex = 12;
        	this.label9.Text = "Usuário:";
        	// 
        	// txtusuarioprocesso
        	// 
        	this.txtusuarioprocesso.Location = new System.Drawing.Point(508, 49);
        	this.txtusuarioprocesso.Name = "txtusuarioprocesso";
        	this.txtusuarioprocesso.Size = new System.Drawing.Size(186, 25);
        	this.txtusuarioprocesso.TabIndex = 13;
        	// 
        	// Form_Parecer_Processo
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(790, 666);
        	this.Controls.Add(this.statusStrip1);
        	this.Controls.Add(this.btnAlterar);
        	this.Controls.Add(this.btnSalvar);
        	this.Controls.Add(this.btnLimpar);
        	this.Controls.Add(this.btnSair);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.groupBox1);
        	this.MaximizeBox = false;
        	this.Name = "Form_Parecer_Processo";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Parecer do Processo";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox2.PerformLayout();
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtusuarioprocesso;
        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtnumprocesso;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.TextBox txtnomerazao;
        private System.Windows.Forms.TextBox txtcnpj;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.ComboBox cbtipocliente;
        private System.Windows.Forms.DateTimePicker txtdatasaida;
        private System.Windows.Forms.RichTextBox txtassunto;
        private System.Windows.Forms.RichTextBox txtobservacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttipoparecer;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel LabelProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker txtdataentrada;
    }
}