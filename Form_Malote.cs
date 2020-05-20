using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Protocolo
{
    public partial class Form_Malote : Form
    {
        public Form_Malote()
        {
            InitializeComponent();
        }

        private void Form_Malote_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNumDoc.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O Nº DO DOCUMENTO", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txtdescricao.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA A DESCRIÇÃO", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           else if (txtorgao.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O ÓRGÃO", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {


                    string Inserir_Malote = " insert into Tb_Malote values('" + txtNumDoc.Text + "', '" + txtdescricao.Text + "', '" + txtorgao.Text + "', convert(datetime, '" + dtsaida.Value.ToShortDateString() + "',103),'" + txtobservacao.Text + "')";

                    cl_conexao.Abre_Conexao();
                    cl_conexao.ComandoInserir(Inserir_Malote);
                    cl_conexao.Fecha_Conexao();

                    txtNumDoc.Text = "";
                    txtdescricao.Text = "";
                    txtorgao.Text = "";
                    dtsaida.Text = "";
                    txtobservacao.Text = "";

                    MessageBox.Show("Malote Cadastrado com Sucesso!", "Cadastro de Malote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique se todos os campos estão preenchidos corretamente!", "Cadastro de Malote", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string Consulta_Malote = " select * from Tb_Malote where Num_Doc = " + txtNumDoc.Text + "";

                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_Malote);

                reader.Read();

                txtdescricao.Text = reader[2].ToString();
                txtorgao.Text = reader[3].ToString();
                dtsaida.Text = reader[4].ToString();
                txtobservacao.Text = reader[5].ToString();

                reader.Close();

                cl_conexao.Fecha_Conexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Malote não Cadastrado", "Cadastro de Malote", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumDoc.Text = "";
            txtdescricao.Text = "";
            txtorgao.Text = "";
            dtsaida.Text = "";
            txtobservacao.Text = "";
        }
    }
}
