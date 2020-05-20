using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Protocolo
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void processosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair do Sistema ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Application.Exit();
                
            }
        }

        private void tramitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            
        }

        private void cadastroAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Processo fp = new Form_Processo();
            fp.ShowDialog();
        }

        private void cadastroCobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cobrança fc = new Form_Cobrança();
            fc.ShowDialog();
        }

        private void maloteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Malote fm = new Form_Malote();
            fm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cadastroDeUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Usuario fu = new Form_Usuario();
            fu.ShowDialog();
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TrocaSenha fts = new Form_TrocaSenha();
            fts.ShowDialog();
        }

        private void processoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Consulta_Processo fcp = new Form_Consulta_Processo();
            fcp.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatorioDoProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void processoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        
        }

        private void parecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Consulta_Cobrança fcc = new Form_Consulta_Cobrança();
            fcc.ShowDialog();
        }

        private void maloteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Consulta_Malote fcm = new Form_Consulta_Malote();
            fcm.ShowDialog();
        }

        private void parecerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Consulta_Parecer fcp = new Form_Consulta_Parecer();
            fcp.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Começa a contar o valor da progress bar de 2 em 2 Segundos     

            ProgressBar1.Value += 2;

            /* Como definimos nas propriedades do timer sendo contado 

             * em um intervalo de até 100 segundos, então se o valor 

             * da barra de progresso menor igual a 30, é exibida a 

             * mensagem "Iniciando..." e assim continuara 

             * sucessivamente até 100 */

            if (ProgressBar1.Value <= 30)
            {

                LabelProgress.Text = "Iniciando...";

            }

            else

                if (ProgressBar1.Value <= 50)
                {

                    LabelProgress.Text = "Carregando Componentes";

                }

                else

                    if (ProgressBar1.Value <= 70)
                    {

                        LabelProgress.Text = "Verificando Banco de Dados";

                    }

                    else

                        if (ProgressBar1.Value <= 100)
                        {

                            LabelProgress.Text = "Aguarde";

                        }

            /* Timer fica igual a 100, atinge o intervalo maximo 

             * estipulado anteriormente na propriedade do timer */

            if (ProgressBar1.Value == 100)
            {

                // Encerra o timer

                timer1.Dispose();

                //Deixa a label invisivel, visibilidade da label = False 

                LabelProgress.Visible = false;
                ProgressBar1.Visible = false;


            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void cobrançaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_Parecer fp = new Form_Parecer();
            fp.ShowDialog();
        }

        private void processoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_Parecer_Processo fpp = new Form_Parecer_Processo();
            fpp.ShowDialog();
        }

        private void parecerDoProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Consulta_Parecer_Processo fcpp = new Form_Consulta_Parecer_Processo();
            fcpp.ShowDialog();
        }
    }
}
