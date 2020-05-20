namespace Projeto_Protocolo
{
    partial class Form_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.processosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCobrançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maloteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parecerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrançaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tramitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maloteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parecerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parecerDoProcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDoProcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.processoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrançaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maloteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.LabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processosToolStripMenuItem,
            this.parecerToolStripMenuItem,
            this.tramitToolStripMenuItem,
            this.relatorioDoProcessoToolStripMenuItem,
            this.cadastroDeUsuárioToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processosToolStripMenuItem
            // 
            this.processosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroAtendimentoToolStripMenuItem,
            this.cadastroCobrançaToolStripMenuItem,
            this.maloteToolStripMenuItem});
            this.processosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            this.processosToolStripMenuItem.Size = new System.Drawing.Size(191, 23);
            this.processosToolStripMenuItem.Text = "Cadastro de Processo";
            this.processosToolStripMenuItem.Click += new System.EventHandler(this.processosToolStripMenuItem_Click);
            // 
            // cadastroAtendimentoToolStripMenuItem
            // 
            this.cadastroAtendimentoToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.cadastroAtendimentoToolStripMenuItem.Name = "cadastroAtendimentoToolStripMenuItem";
            this.cadastroAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.cadastroAtendimentoToolStripMenuItem.Text = "Atendimento";
            this.cadastroAtendimentoToolStripMenuItem.Click += new System.EventHandler(this.cadastroAtendimentoToolStripMenuItem_Click);
            // 
            // cadastroCobrançaToolStripMenuItem
            // 
            this.cadastroCobrançaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.cadastroCobrançaToolStripMenuItem.Name = "cadastroCobrançaToolStripMenuItem";
            this.cadastroCobrançaToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.cadastroCobrançaToolStripMenuItem.Text = "Cobrança";
            this.cadastroCobrançaToolStripMenuItem.Click += new System.EventHandler(this.cadastroCobrançaToolStripMenuItem_Click);
            // 
            // maloteToolStripMenuItem
            // 
            this.maloteToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.maloteToolStripMenuItem.Name = "maloteToolStripMenuItem";
            this.maloteToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.maloteToolStripMenuItem.Text = "Malote";
            this.maloteToolStripMenuItem.Click += new System.EventHandler(this.maloteToolStripMenuItem_Click);
            // 
            // parecerToolStripMenuItem
            // 
            this.parecerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processoToolStripMenuItem2,
            this.cobrançaToolStripMenuItem2});
            this.parecerToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parecerToolStripMenuItem.Name = "parecerToolStripMenuItem";
            this.parecerToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.parecerToolStripMenuItem.Text = "Parecer";
            // 
            // processoToolStripMenuItem2
            // 
            this.processoToolStripMenuItem2.ForeColor = System.Drawing.Color.Red;
            this.processoToolStripMenuItem2.Name = "processoToolStripMenuItem2";
            this.processoToolStripMenuItem2.Size = new System.Drawing.Size(165, 24);
            this.processoToolStripMenuItem2.Text = "Processo";
            this.processoToolStripMenuItem2.Click += new System.EventHandler(this.processoToolStripMenuItem2_Click);
            // 
            // cobrançaToolStripMenuItem2
            // 
            this.cobrançaToolStripMenuItem2.ForeColor = System.Drawing.Color.Red;
            this.cobrançaToolStripMenuItem2.Name = "cobrançaToolStripMenuItem2";
            this.cobrançaToolStripMenuItem2.Size = new System.Drawing.Size(165, 24);
            this.cobrançaToolStripMenuItem2.Text = "Cobrança";
            this.cobrançaToolStripMenuItem2.Click += new System.EventHandler(this.cobrançaToolStripMenuItem2_Click);
            // 
            // tramitToolStripMenuItem
            // 
            this.tramitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processoToolStripMenuItem,
            this.cobrançaToolStripMenuItem,
            this.maloteToolStripMenuItem1,
            this.parecerToolStripMenuItem1,
            this.parecerDoProcessoToolStripMenuItem});
            this.tramitToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramitToolStripMenuItem.Name = "tramitToolStripMenuItem";
            this.tramitToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.tramitToolStripMenuItem.Text = "Consultas";
            this.tramitToolStripMenuItem.Click += new System.EventHandler(this.tramitToolStripMenuItem_Click);
            // 
            // processoToolStripMenuItem
            // 
            this.processoToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.processoToolStripMenuItem.Name = "processoToolStripMenuItem";
            this.processoToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.processoToolStripMenuItem.Text = "Processo";
            this.processoToolStripMenuItem.Click += new System.EventHandler(this.processoToolStripMenuItem_Click);
            // 
            // cobrançaToolStripMenuItem
            // 
            this.cobrançaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.cobrançaToolStripMenuItem.Name = "cobrançaToolStripMenuItem";
            this.cobrançaToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.cobrançaToolStripMenuItem.Text = "Cobrança";
            this.cobrançaToolStripMenuItem.Click += new System.EventHandler(this.cobrançaToolStripMenuItem_Click);
            // 
            // maloteToolStripMenuItem1
            // 
            this.maloteToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.maloteToolStripMenuItem1.Name = "maloteToolStripMenuItem1";
            this.maloteToolStripMenuItem1.Size = new System.Drawing.Size(251, 24);
            this.maloteToolStripMenuItem1.Text = "Malote";
            this.maloteToolStripMenuItem1.Click += new System.EventHandler(this.maloteToolStripMenuItem1_Click);
            // 
            // parecerToolStripMenuItem1
            // 
            this.parecerToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.parecerToolStripMenuItem1.Name = "parecerToolStripMenuItem1";
            this.parecerToolStripMenuItem1.Size = new System.Drawing.Size(251, 24);
            this.parecerToolStripMenuItem1.Text = "Parecer da Cobrança";
            this.parecerToolStripMenuItem1.Click += new System.EventHandler(this.parecerToolStripMenuItem1_Click);
            // 
            // parecerDoProcessoToolStripMenuItem
            // 
            this.parecerDoProcessoToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.parecerDoProcessoToolStripMenuItem.Name = "parecerDoProcessoToolStripMenuItem";
            this.parecerDoProcessoToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.parecerDoProcessoToolStripMenuItem.Text = "Parecer do Processo";
            this.parecerDoProcessoToolStripMenuItem.Click += new System.EventHandler(this.parecerDoProcessoToolStripMenuItem_Click);
            // 
            // relatorioDoProcessoToolStripMenuItem
            // 
            this.relatorioDoProcessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.processoToolStripMenuItem1,
            this.cobrançaToolStripMenuItem1,
            this.maloteToolStripMenuItem2});
            this.relatorioDoProcessoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorioDoProcessoToolStripMenuItem.Name = "relatorioDoProcessoToolStripMenuItem";
            this.relatorioDoProcessoToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.relatorioDoProcessoToolStripMenuItem.Text = "Relatórios";
            this.relatorioDoProcessoToolStripMenuItem.Click += new System.EventHandler(this.relatorioDoProcessoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            // 
            // processoToolStripMenuItem1
            // 
            this.processoToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.processoToolStripMenuItem1.Name = "processoToolStripMenuItem1";
            this.processoToolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.processoToolStripMenuItem1.Text = "Processo";
            this.processoToolStripMenuItem1.Click += new System.EventHandler(this.processoToolStripMenuItem1_Click);
            // 
            // cobrançaToolStripMenuItem1
            // 
            this.cobrançaToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.cobrançaToolStripMenuItem1.Name = "cobrançaToolStripMenuItem1";
            this.cobrançaToolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.cobrançaToolStripMenuItem1.Text = "Cobrança";
            // 
            // maloteToolStripMenuItem2
            // 
            this.maloteToolStripMenuItem2.ForeColor = System.Drawing.Color.Red;
            this.maloteToolStripMenuItem2.Name = "maloteToolStripMenuItem2";
            this.maloteToolStripMenuItem2.Size = new System.Drawing.Size(165, 24);
            this.maloteToolStripMenuItem2.Text = "Malote";
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            this.cadastroDeUsuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuárioToolStripMenuItem1,
            this.trocarSenhaToolStripMenuItem,
            this.sobreOSistemaToolStripMenuItem});
            this.cadastroDeUsuárioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            this.cadastroDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.cadastroDeUsuárioToolStripMenuItem.Text = "Sistema";
            // 
            // cadastroDeUsuárioToolStripMenuItem1
            // 
            this.cadastroDeUsuárioToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.cadastroDeUsuárioToolStripMenuItem1.Name = "cadastroDeUsuárioToolStripMenuItem1";
            this.cadastroDeUsuárioToolStripMenuItem1.Size = new System.Drawing.Size(265, 24);
            this.cadastroDeUsuárioToolStripMenuItem1.Text = "Cadastro de Usuário";
            this.cadastroDeUsuárioToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeUsuárioToolStripMenuItem1_Click);
            // 
            // trocarSenhaToolStripMenuItem
            // 
            this.trocarSenhaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.trocarSenhaToolStripMenuItem.Name = "trocarSenhaToolStripMenuItem";
            this.trocarSenhaToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.trocarSenhaToolStripMenuItem.Text = "Trocar Senha";
            this.trocarSenhaToolStripMenuItem.Click += new System.EventHandler(this.trocarSenhaToolStripMenuItem_Click);
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            this.sobreOSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            this.sobreOSistemaToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.sobreOSistemaToolStripMenuItem.Text = "Informação do Sistema";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(118, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Agência Especial de Imperatriz";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.LabelProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(845, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.ProgressBar1.Click += new System.EventHandler(this.ProgressBar1_Click_1);
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
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Protocolo.Properties.Resources.logo_foto;
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 233);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastros de Processos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tramitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDoProcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCobrançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maloteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem processoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trocarSenhaToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cobrançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maloteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parecerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cobrançaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maloteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel LabelProgress;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parecerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cobrançaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem parecerDoProcessoToolStripMenuItem;
    }
}