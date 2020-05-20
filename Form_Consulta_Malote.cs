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
    public partial class Form_Consulta_Malote : Form
    {
        public Form_Consulta_Malote()
        {
            InitializeComponent();
        }

        private void Form_Consulta_Malote_Load(object sender, EventArgs e)
        {
            dgmalote.Rows.Clear();

            dgmalote.Columns.Add("Descr", "Descriçao do Documento");
            dgmalote.Columns.Add("Org", "Orgão Destinatário");
            dgmalote.Columns.Add("Dt_Saida", "Data de Saída");
            dgmalote.Columns.Add("Obs", "Observação");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnumdoc.Text == "")
            {
                MessageBox.Show("INSIRA O NÚMERO DO DOCUMENTO DO MALOTE PARA A CONSULTA POR FAVOR", "CONSULTA AO MALOTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    string Consulta_Malote = " select Descr_Doc, Orgao_Des, Dt_Saida, Observacao from Tb_Malote where Num_Doc = '" + txtnumdoc.Text + "'";

                    cl_conexao.Abre_Conexao();

                    SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_Malote);




                    while (reader.Read())
                    {
                        int indicelinha = dgmalote.Rows.Add();

                        dgmalote["Descr", indicelinha].Value = reader[0].ToString();
                        dgmalote["Org", indicelinha].Value = reader[1].ToString();
                        dgmalote["Dt_Saida", indicelinha].Value = reader[2].ToString();
                        dgmalote["Obs", indicelinha].Value = reader[3].ToString();


                    }

                    reader.Close();

                    cl_conexao.Fecha_Conexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Malote não Cadastrado!", "Consulta de Malote", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Close();

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
    }
}
