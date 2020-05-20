namespace Projeto_Protocolo
{
    partial class Form_Consulta_Processo
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
            this.dgprocesso = new System.Windows.Forms.DataGridView();
            this.dsprotocoloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_protocolo = new Projeto_Protocolo.ds_protocolo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarIE = new System.Windows.Forms.Button();
            this.btnCosnultarCPF = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.LabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtcnpj = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgprocesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsprotocoloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_protocolo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgprocesso
            // 
            this.dgprocesso.BackgroundColor = System.Drawing.Color.Gray;
            this.dgprocesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprocesso.GridColor = System.Drawing.Color.Blue;
            this.dgprocesso.Location = new System.Drawing.Point(0, 163);
            this.dgprocesso.Name = "dgprocesso";
            this.dgprocesso.Size = new System.Drawing.Size(854, 272);
            this.dgprocesso.TabIndex = 0;
            // 
            // dsprotocoloBindingSource
            // 
            this.dsprotocoloBindingSource.DataSource = this.ds_protocolo;
            this.dsprotocoloBindingSource.Position = 0;
            // 
            // ds_protocolo
            // 
            this.ds_protocolo.DataSetName = "ds_protocolo";
            this.ds_protocolo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "I.E:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(362, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // txtIE
            // 
            this.txtIE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIE.Location = new System.Drawing.Point(61, 64);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(167, 21);
            this.txtIE.TabIndex = 0;
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(410, 64);
            this.txtcpf.Mask = "00000000000";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(107, 21);
            this.txtcpf.TabIndex = 2;
            this.txtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtcpf_MaskInputRejected);
            // 
            // btnConsultarIE
            // 
            this.btnConsultarIE.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarIE.ForeColor = System.Drawing.Color.Red;
            this.btnConsultarIE.Location = new System.Drawing.Point(234, 62);
            this.btnConsultarIE.Name = "btnConsultarIE";
            this.btnConsultarIE.Size = new System.Drawing.Size(111, 25);
            this.btnConsultarIE.TabIndex = 1;
            this.btnConsultarIE.Text = "Consultar";
            this.btnConsultarIE.UseVisualStyleBackColor = true;
            this.btnConsultarIE.Click += new System.EventHandler(this.btnConsultarIE_Click);
            // 
            // btnCosnultarCPF
            // 
            this.btnCosnultarCPF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosnultarCPF.ForeColor = System.Drawing.Color.Red;
            this.btnCosnultarCPF.Location = new System.Drawing.Point(523, 62);
            this.btnCosnultarCPF.Name = "btnCosnultarCPF";
            this.btnCosnultarCPF.Size = new System.Drawing.Size(112, 25);
            this.btnCosnultarCPF.TabIndex = 3;
            this.btnCosnultarCPF.Text = "Consultar";
            this.btnCosnultarCPF.UseVisualStyleBackColor = true;
            this.btnCosnultarCPF.Click += new System.EventHandler(this.btnCosnultarCPF_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ProgressBar1,
            this.LabelProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(226, 17);
            this.toolStripStatusLabel1.Text = "Sistema de Cadastro de Processos";
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
            this.LabelProgress.Text = "toolStripStatusLabel2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(704, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "CNPJ:";
            // 
            // txtcnpj
            // 
            this.txtcnpj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnpj.Location = new System.Drawing.Point(82, 109);
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(169, 21);
            this.txtcnpj.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(257, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Consulta_Processo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtcnpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCosnultarCPF);
            this.Controls.Add(this.btnConsultarIE);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtIE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgprocesso);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form_Consulta_Processo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Processo";
            this.Load += new System.EventHandler(this.Form_Consulta_Processo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgprocesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsprotocoloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_protocolo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgprocesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Button btnConsultarIE;
        private System.Windows.Forms.Button btnCosnultarCPF;
        private System.Windows.Forms.BindingSource dsprotocoloBindingSource;
        private ds_protocolo ds_protocolo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel LabelProgress;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcnpj;
        private System.Windows.Forms.Button button2;
    }
}