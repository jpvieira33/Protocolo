namespace Projeto_Protocolo
{
    partial class Form_Parecer
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
        	this.label15 = new System.Windows.Forms.Label();
        	this.btnconsultar_processo = new System.Windows.Forms.Button();
        	this.btnsairparecer = new System.Windows.Forms.Button();
        	this.btnalterar = new System.Windows.Forms.Button();
        	this.btnsalvar = new System.Windows.Forms.Button();
        	this.txtobservacao = new System.Windows.Forms.RichTextBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.txtcpf_parecer = new System.Windows.Forms.MaskedTextBox();
        	this.dtsaida = new System.Windows.Forms.DateTimePicker();
        	this.txtIE_parecer = new System.Windows.Forms.TextBox();
        	this.txtnomerazao_parecer = new System.Windows.Forms.TextBox();
        	this.txtprocesso = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
        	this.LabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.btnLimpar = new System.Windows.Forms.Button();
        	this.cbtipoparecer = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.txtcnpj = new System.Windows.Forms.TextBox();
        	this.statusStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label15
        	// 
        	this.label15.AutoSize = true;
        	this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label15.ForeColor = System.Drawing.Color.Blue;
        	this.label15.Location = new System.Drawing.Point(12, 248);
        	this.label15.Name = "label15";
        	this.label15.Size = new System.Drawing.Size(116, 17);
        	this.label15.TabIndex = 39;
        	this.label15.Text = "Tipo de Paracer:";
        	// 
        	// btnconsultar_processo
        	// 
        	this.btnconsultar_processo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnconsultar_processo.ForeColor = System.Drawing.Color.Red;
        	this.btnconsultar_processo.Location = new System.Drawing.Point(145, 55);
        	this.btnconsultar_processo.Name = "btnconsultar_processo";
        	this.btnconsultar_processo.Size = new System.Drawing.Size(92, 23);
        	this.btnconsultar_processo.TabIndex = 1;
        	this.btnconsultar_processo.Text = "Consultar";
        	this.btnconsultar_processo.UseVisualStyleBackColor = true;
        	this.btnconsultar_processo.Click += new System.EventHandler(this.btnconsultar_processo_Click);
        	// 
        	// btnsairparecer
        	// 
        	this.btnsairparecer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnsairparecer.ForeColor = System.Drawing.Color.Red;
        	this.btnsairparecer.Location = new System.Drawing.Point(360, 420);
        	this.btnsairparecer.Name = "btnsairparecer";
        	this.btnsairparecer.Size = new System.Drawing.Size(75, 23);
        	this.btnsairparecer.TabIndex = 10;
        	this.btnsairparecer.Text = "Sair";
        	this.btnsairparecer.UseVisualStyleBackColor = true;
        	this.btnsairparecer.Click += new System.EventHandler(this.btnsairparecer_Click);
        	// 
        	// btnalterar
        	// 
        	this.btnalterar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnalterar.ForeColor = System.Drawing.Color.Red;
        	this.btnalterar.Location = new System.Drawing.Point(172, 420);
        	this.btnalterar.Name = "btnalterar";
        	this.btnalterar.Size = new System.Drawing.Size(75, 23);
        	this.btnalterar.TabIndex = 9;
        	this.btnalterar.Text = "Alterar";
        	this.btnalterar.UseVisualStyleBackColor = true;
        	this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
        	// 
        	// btnsalvar
        	// 
        	this.btnsalvar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnsalvar.ForeColor = System.Drawing.Color.Red;
        	this.btnsalvar.Location = new System.Drawing.Point(79, 420);
        	this.btnsalvar.Name = "btnsalvar";
        	this.btnsalvar.Size = new System.Drawing.Size(75, 23);
        	this.btnsalvar.TabIndex = 8;
        	this.btnsalvar.Text = "Salvar";
        	this.btnsalvar.UseVisualStyleBackColor = true;
        	this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
        	// 
        	// txtobservacao
        	// 
        	this.txtobservacao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtobservacao.Location = new System.Drawing.Point(217, 267);
        	this.txtobservacao.Name = "txtobservacao";
        	this.txtobservacao.Size = new System.Drawing.Size(225, 119);
        	this.txtobservacao.TabIndex = 7;
        	this.txtobservacao.Text = "";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.ForeColor = System.Drawing.Color.Blue;
        	this.label6.Location = new System.Drawing.Point(214, 248);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(92, 17);
        	this.label6.TabIndex = 33;
        	this.label6.Text = "Observação:";
        	// 
        	// txtcpf_parecer
        	// 
        	this.txtcpf_parecer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtcpf_parecer.Location = new System.Drawing.Point(183, 103);
        	this.txtcpf_parecer.Mask = "00000000000";
        	this.txtcpf_parecer.Name = "txtcpf_parecer";
        	this.txtcpf_parecer.Size = new System.Drawing.Size(100, 21);
        	this.txtcpf_parecer.TabIndex = 3;
        	// 
        	// dtsaida
        	// 
        	this.dtsaida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.dtsaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.dtsaida.Location = new System.Drawing.Point(13, 206);
        	this.dtsaida.Name = "dtsaida";
        	this.dtsaida.Size = new System.Drawing.Size(103, 21);
        	this.dtsaida.TabIndex = 5;
        	// 
        	// txtIE_parecer
        	// 
        	this.txtIE_parecer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtIE_parecer.Location = new System.Drawing.Point(15, 103);
        	this.txtIE_parecer.Name = "txtIE_parecer";
        	this.txtIE_parecer.Size = new System.Drawing.Size(124, 21);
        	this.txtIE_parecer.TabIndex = 2;
        	// 
        	// txtnomerazao_parecer
        	// 
        	this.txtnomerazao_parecer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtnomerazao_parecer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtnomerazao_parecer.Location = new System.Drawing.Point(15, 157);
        	this.txtnomerazao_parecer.Name = "txtnomerazao_parecer";
        	this.txtnomerazao_parecer.Size = new System.Drawing.Size(339, 21);
        	this.txtnomerazao_parecer.TabIndex = 4;
        	// 
        	// txtprocesso
        	// 
        	this.txtprocesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtprocesso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtprocesso.Location = new System.Drawing.Point(15, 57);
        	this.txtprocesso.Name = "txtprocesso";
        	this.txtprocesso.Size = new System.Drawing.Size(124, 21);
        	this.txtprocesso.TabIndex = 0;
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.ForeColor = System.Drawing.Color.Blue;
        	this.label5.Location = new System.Drawing.Point(12, 186);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(104, 17);
        	this.label5.TabIndex = 27;
        	this.label5.Text = "Data de Saída:";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.Color.Blue;
        	this.label4.Location = new System.Drawing.Point(12, 137);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(142, 17);
        	this.label4.TabIndex = 26;
        	this.label4.Text = "Nome/Razão Social:";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.Blue;
        	this.label3.Location = new System.Drawing.Point(182, 83);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(42, 17);
        	this.label3.TabIndex = 25;
        	this.label3.Text = "CPF:";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.Blue;
        	this.label2.Location = new System.Drawing.Point(12, 83);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(29, 17);
        	this.label2.TabIndex = 24;
        	this.label2.Text = "I.E:";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.Blue;
        	this.label1.Location = new System.Drawing.Point(12, 37);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(114, 17);
        	this.label1.TabIndex = 23;
        	this.label1.Text = "Nº do Processo:";
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.BackColor = System.Drawing.Color.Silver;
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.ProgressBar1,
        	        	        	this.LabelProgress});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 467);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(536, 22);
        	this.statusStrip1.TabIndex = 41;
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
        	this.toolStrip1.Size = new System.Drawing.Size(536, 25);
        	this.toolStrip1.TabIndex = 42;
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
        	this.btnLimpar.Location = new System.Drawing.Point(263, 420);
        	this.btnLimpar.Name = "btnLimpar";
        	this.btnLimpar.Size = new System.Drawing.Size(75, 23);
        	this.btnLimpar.TabIndex = 43;
        	this.btnLimpar.Text = "Limpar";
        	this.btnLimpar.UseVisualStyleBackColor = true;
        	this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
        	// 
        	// cbtipoparecer
        	// 
        	this.cbtipoparecer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.cbtipoparecer.Location = new System.Drawing.Point(15, 268);
        	this.cbtipoparecer.Name = "cbtipoparecer";
        	this.cbtipoparecer.Size = new System.Drawing.Size(178, 20);
        	this.cbtipoparecer.TabIndex = 44;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.ForeColor = System.Drawing.Color.Blue;
        	this.label7.Location = new System.Drawing.Point(319, 83);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(50, 17);
        	this.label7.TabIndex = 45;
        	this.label7.Text = "CNPJ:";
        	// 
        	// txtcnpj
        	// 
        	this.txtcnpj.Location = new System.Drawing.Point(322, 103);
        	this.txtcnpj.Name = "txtcnpj";
        	this.txtcnpj.Size = new System.Drawing.Size(154, 20);
        	this.txtcnpj.TabIndex = 46;
        	// 
        	// Form_Parecer
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(536, 489);
        	this.Controls.Add(this.txtcnpj);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.cbtipoparecer);
        	this.Controls.Add(this.btnLimpar);
        	this.Controls.Add(this.toolStrip1);
        	this.Controls.Add(this.statusStrip1);
        	this.Controls.Add(this.label15);
        	this.Controls.Add(this.btnconsultar_processo);
        	this.Controls.Add(this.btnsairparecer);
        	this.Controls.Add(this.btnalterar);
        	this.Controls.Add(this.btnsalvar);
        	this.Controls.Add(this.txtobservacao);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.txtcpf_parecer);
        	this.Controls.Add(this.dtsaida);
        	this.Controls.Add(this.txtIE_parecer);
        	this.Controls.Add(this.txtnomerazao_parecer);
        	this.Controls.Add(this.txtprocesso);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.MaximizeBox = false;
        	this.Name = "Form_Parecer";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Parecer";
        	this.Load += new System.EventHandler(this.Form_Parecer_Load);
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnconsultar_processo;
        private System.Windows.Forms.Button btnsairparecer;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.RichTextBox txtobservacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtcpf_parecer;
        private System.Windows.Forms.DateTimePicker dtsaida;
        private System.Windows.Forms.TextBox txtIE_parecer;
        private System.Windows.Forms.TextBox txtnomerazao_parecer;
        private System.Windows.Forms.TextBox txtprocesso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel LabelProgress;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox cbtipoparecer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcnpj;
    }
}