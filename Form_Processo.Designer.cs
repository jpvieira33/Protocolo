namespace Projeto_Protocolo
{
    partial class Form_Processo
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
        	this.txtmail = new System.Windows.Forms.TextBox();
        	this.label16 = new System.Windows.Forms.Label();
        	this.cbtipocliente = new System.Windows.Forms.ComboBox();
        	this.label15 = new System.Windows.Forms.Label();
        	this.btnconsultar = new System.Windows.Forms.Button();
        	this.btnsair = new System.Windows.Forms.Button();
        	this.btnalterar = new System.Windows.Forms.Button();
        	this.btnenviar = new System.Windows.Forms.Button();
        	this.txtprocesso = new System.Windows.Forms.TextBox();
        	this.dtentrada = new System.Windows.Forms.DateTimePicker();
        	this.txtassunto = new System.Windows.Forms.RichTextBox();
        	this.txtIE = new System.Windows.Forms.TextBox();
        	this.txtnome_razao = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtcpf = new System.Windows.Forms.MaskedTextBox();
        	this.printDocument1 = new System.Drawing.Printing.PrintDocument();
        	this.btnconsultaIE = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.txtdestino = new System.Windows.Forms.TextBox();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
        	this.LabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.btnLimpar = new System.Windows.Forms.Button();
        	this.label8 = new System.Windows.Forms.Label();
        	this.txtcnpj = new System.Windows.Forms.TextBox();
        	this.button2 = new System.Windows.Forms.Button();
        	this.label9 = new System.Windows.Forms.Label();
        	this.txtusuario = new System.Windows.Forms.TextBox();
        	this.statusStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// txtmail
        	// 
        	this.txtmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtmail.Location = new System.Drawing.Point(12, 297);
        	this.txtmail.Name = "txtmail";
        	this.txtmail.Size = new System.Drawing.Size(419, 21);
        	this.txtmail.TabIndex = 9;
        	// 
        	// label16
        	// 
        	this.label16.AutoSize = true;
        	this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label16.ForeColor = System.Drawing.Color.Blue;
        	this.label16.Location = new System.Drawing.Point(12, 276);
        	this.label16.Name = "label16";
        	this.label16.Size = new System.Drawing.Size(57, 18);
        	this.label16.TabIndex = 43;
        	this.label16.Text = "E-mail:";
        	// 
        	// cbtipocliente
        	// 
        	this.cbtipocliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbtipocliente.FormattingEnabled = true;
        	this.cbtipocliente.Items.AddRange(new object[] {
        	        	        	"P. FÍSICA",
        	        	        	"P. JURIDICA"});
        	this.cbtipocliente.Location = new System.Drawing.Point(179, 78);
        	this.cbtipocliente.Name = "cbtipocliente";
        	this.cbtipocliente.Size = new System.Drawing.Size(145, 23);
        	this.cbtipocliente.TabIndex = 1;
        	// 
        	// label15
        	// 
        	this.label15.AutoSize = true;
        	this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label15.ForeColor = System.Drawing.Color.Blue;
        	this.label15.Location = new System.Drawing.Point(176, 57);
        	this.label15.Name = "label15";
        	this.label15.Size = new System.Drawing.Size(118, 18);
        	this.label15.TabIndex = 41;
        	this.label15.Text = "Tipo de Cliente:";
        	// 
        	// btnconsultar
        	// 
        	this.btnconsultar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnconsultar.ForeColor = System.Drawing.Color.Red;
        	this.btnconsultar.Location = new System.Drawing.Point(403, 129);
        	this.btnconsultar.Name = "btnconsultar";
        	this.btnconsultar.Size = new System.Drawing.Size(92, 23);
        	this.btnconsultar.TabIndex = 5;
        	this.btnconsultar.Text = "Consultar";
        	this.btnconsultar.UseVisualStyleBackColor = true;
        	this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
        	// 
        	// btnsair
        	// 
        	this.btnsair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnsair.ForeColor = System.Drawing.Color.Red;
        	this.btnsair.Location = new System.Drawing.Point(595, 483);
        	this.btnsair.Name = "btnsair";
        	this.btnsair.Size = new System.Drawing.Size(75, 23);
        	this.btnsair.TabIndex = 14;
        	this.btnsair.Text = "Sair";
        	this.btnsair.UseVisualStyleBackColor = true;
        	this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
        	// 
        	// btnalterar
        	// 
        	this.btnalterar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnalterar.ForeColor = System.Drawing.Color.Red;
        	this.btnalterar.Location = new System.Drawing.Point(398, 483);
        	this.btnalterar.Name = "btnalterar";
        	this.btnalterar.Size = new System.Drawing.Size(75, 23);
        	this.btnalterar.TabIndex = 13;
        	this.btnalterar.Text = "Alterar";
        	this.btnalterar.UseVisualStyleBackColor = true;
        	this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
        	// 
        	// btnenviar
        	// 
        	this.btnenviar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnenviar.ForeColor = System.Drawing.Color.Red;
        	this.btnenviar.Location = new System.Drawing.Point(300, 483);
        	this.btnenviar.Name = "btnenviar";
        	this.btnenviar.Size = new System.Drawing.Size(75, 23);
        	this.btnenviar.TabIndex = 12;
        	this.btnenviar.Text = "Salvar";
        	this.btnenviar.UseVisualStyleBackColor = true;
        	this.btnenviar.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// txtprocesso
        	// 
        	this.txtprocesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtprocesso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtprocesso.Location = new System.Drawing.Point(15, 78);
        	this.txtprocesso.Name = "txtprocesso";
        	this.txtprocesso.Size = new System.Drawing.Size(143, 21);
        	this.txtprocesso.TabIndex = 0;
        	this.txtprocesso.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
        	// 
        	// dtentrada
        	// 
        	this.dtentrada.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.dtentrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.dtentrada.Location = new System.Drawing.Point(15, 241);
        	this.dtentrada.Name = "dtentrada";
        	this.dtentrada.Size = new System.Drawing.Size(116, 21);
        	this.dtentrada.TabIndex = 7;
        	// 
        	// txtassunto
        	// 
        	this.txtassunto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtassunto.Location = new System.Drawing.Point(12, 353);
        	this.txtassunto.Name = "txtassunto";
        	this.txtassunto.Size = new System.Drawing.Size(419, 96);
        	this.txtassunto.TabIndex = 10;
        	this.txtassunto.Text = "";
        	// 
        	// txtIE
        	// 
        	this.txtIE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtIE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtIE.Location = new System.Drawing.Point(15, 129);
        	this.txtIE.Name = "txtIE";
        	this.txtIE.Size = new System.Drawing.Size(134, 21);
        	this.txtIE.TabIndex = 2;
        	// 
        	// txtnome_razao
        	// 
        	this.txtnome_razao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtnome_razao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtnome_razao.Location = new System.Drawing.Point(15, 183);
        	this.txtnome_razao.Name = "txtnome_razao";
        	this.txtnome_razao.Size = new System.Drawing.Size(419, 21);
        	this.txtnome_razao.TabIndex = 6;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.ForeColor = System.Drawing.Color.Blue;
        	this.label7.Location = new System.Drawing.Point(12, 332);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(68, 18);
        	this.label7.TabIndex = 30;
        	this.label7.Text = "Assunto:";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.ForeColor = System.Drawing.Color.Blue;
        	this.label6.Location = new System.Drawing.Point(189, 220);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(66, 18);
        	this.label6.TabIndex = 29;
        	this.label6.Text = "Destino:";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.ForeColor = System.Drawing.Color.Blue;
        	this.label5.Location = new System.Drawing.Point(12, 220);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(127, 18);
        	this.label5.TabIndex = 28;
        	this.label5.Text = "Data de Entrada:";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.Color.Blue;
        	this.label4.Location = new System.Drawing.Point(259, 108);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(45, 18);
        	this.label4.TabIndex = 27;
        	this.label4.Text = "CPF:";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.Blue;
        	this.label3.Location = new System.Drawing.Point(12, 162);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(151, 18);
        	this.label3.TabIndex = 26;
        	this.label3.Text = "Nome/Razão Social:";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.Blue;
        	this.label2.Location = new System.Drawing.Point(12, 108);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(30, 18);
        	this.label2.TabIndex = 25;
        	this.label2.Text = "I.E:";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.Blue;
        	this.label1.Location = new System.Drawing.Point(12, 57);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(121, 18);
        	this.label1.TabIndex = 24;
        	this.label1.Text = "Nº do Processo:";
        	// 
        	// txtcpf
        	// 
        	this.txtcpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtcpf.Location = new System.Drawing.Point(262, 129);
        	this.txtcpf.Mask = "00000000000";
        	this.txtcpf.Name = "txtcpf";
        	this.txtcpf.Size = new System.Drawing.Size(135, 21);
        	this.txtcpf.TabIndex = 4;
        	// 
        	// btnconsultaIE
        	// 
        	this.btnconsultaIE.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnconsultaIE.ForeColor = System.Drawing.Color.Red;
        	this.btnconsultaIE.Location = new System.Drawing.Point(155, 129);
        	this.btnconsultaIE.Name = "btnconsultaIE";
        	this.btnconsultaIE.Size = new System.Drawing.Size(99, 23);
        	this.btnconsultaIE.TabIndex = 3;
        	this.btnconsultaIE.Text = "Consultar";
        	this.btnconsultaIE.UseVisualStyleBackColor = true;
        	this.btnconsultaIE.Click += new System.EventHandler(this.btnconsultaIE_Click);
        	// 
        	// button1
        	// 
        	this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button1.ForeColor = System.Drawing.Color.Red;
        	this.button1.Location = new System.Drawing.Point(120, 483);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(156, 23);
        	this.button1.TabIndex = 11;
        	this.button1.Text = "Gerar Protocolo";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click_1);
        	// 
        	// txtdestino
        	// 
        	this.txtdestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtdestino.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtdestino.Location = new System.Drawing.Point(192, 241);
        	this.txtdestino.Name = "txtdestino";
        	this.txtdestino.Size = new System.Drawing.Size(242, 21);
        	this.txtdestino.TabIndex = 8;
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.BackColor = System.Drawing.Color.Silver;
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.ProgressBar1,
        	        	        	this.LabelProgress});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 546);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(791, 22);
        	this.statusStrip1.TabIndex = 50;
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
        	this.toolStrip1.Size = new System.Drawing.Size(791, 25);
        	this.toolStrip1.TabIndex = 51;
        	this.toolStrip1.Text = "toolStrip1";
        	// 
        	// timer1
        	// 
        	this.timer1.Enabled = true;
        	this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        	// 
        	// btnLimpar
        	// 
        	this.btnLimpar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnLimpar.ForeColor = System.Drawing.Color.Red;
        	this.btnLimpar.Location = new System.Drawing.Point(499, 483);
        	this.btnLimpar.Name = "btnLimpar";
        	this.btnLimpar.Size = new System.Drawing.Size(75, 23);
        	this.btnLimpar.TabIndex = 52;
        	this.btnLimpar.Text = "Limpar";
        	this.btnLimpar.UseVisualStyleBackColor = true;
        	this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label8.ForeColor = System.Drawing.Color.Blue;
        	this.label8.Location = new System.Drawing.Point(515, 109);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(50, 17);
        	this.label8.TabIndex = 53;
        	this.label8.Text = "CNPJ:";
        	// 
        	// txtcnpj
        	// 
        	this.txtcnpj.Location = new System.Drawing.Point(518, 131);
        	this.txtcnpj.Name = "txtcnpj";
        	this.txtcnpj.Size = new System.Drawing.Size(161, 20);
        	this.txtcnpj.TabIndex = 54;
        	// 
        	// button2
        	// 
        	this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button2.ForeColor = System.Drawing.Color.Red;
        	this.button2.Location = new System.Drawing.Point(685, 129);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(98, 23);
        	this.button2.TabIndex = 55;
        	this.button2.Text = "Consultar";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// label9
        	// 
        	this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label9.ForeColor = System.Drawing.Color.Blue;
        	this.label9.Location = new System.Drawing.Point(373, 57);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(100, 23);
        	this.label9.TabIndex = 56;
        	this.label9.Text = "Usuário:";
        	// 
        	// txtusuario
        	// 
        	this.txtusuario.Location = new System.Drawing.Point(373, 78);
        	this.txtusuario.Name = "txtusuario";
        	this.txtusuario.Size = new System.Drawing.Size(201, 20);
        	this.txtusuario.TabIndex = 57;
        	// 
        	// Form_Processo
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(791, 568);
        	this.Controls.Add(this.txtusuario);
        	this.Controls.Add(this.label9);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.txtcnpj);
        	this.Controls.Add(this.label8);
        	this.Controls.Add(this.btnLimpar);
        	this.Controls.Add(this.toolStrip1);
        	this.Controls.Add(this.statusStrip1);
        	this.Controls.Add(this.txtdestino);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.btnconsultaIE);
        	this.Controls.Add(this.txtcpf);
        	this.Controls.Add(this.txtmail);
        	this.Controls.Add(this.label16);
        	this.Controls.Add(this.cbtipocliente);
        	this.Controls.Add(this.label15);
        	this.Controls.Add(this.btnconsultar);
        	this.Controls.Add(this.btnsair);
        	this.Controls.Add(this.btnalterar);
        	this.Controls.Add(this.btnenviar);
        	this.Controls.Add(this.txtprocesso);
        	this.Controls.Add(this.dtentrada);
        	this.Controls.Add(this.txtassunto);
        	this.Controls.Add(this.txtIE);
        	this.Controls.Add(this.txtnome_razao);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.MaximizeBox = false;
        	this.Name = "Form_Processo";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Sistema de Cadastro de Processos";
        	this.Load += new System.EventHandler(this.Form_Processo_Load);
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label9;

        #endregion

        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbtipocliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.TextBox txtprocesso;
        private System.Windows.Forms.DateTimePicker dtentrada;
        private System.Windows.Forms.RichTextBox txtassunto;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.TextBox txtnome_razao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnconsultaIE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel LabelProgress;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcnpj;
        private System.Windows.Forms.Button button2;

    }
}