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
    public partial class Form_Consulta_Parecer : Form
    {
        public Form_Consulta_Parecer()
        {
            InitializeComponent();
        }

        private void Form_Consulta_Parecer_Load(object sender, EventArgs e)
        {
            dgparecer.Rows.Clear();

            dgparecer.Columns.Add("IE", "IE");
            dgparecer.Columns.Add("CPF", "CPF");
            dgparecer.Columns.Add("Nome_Razao", "Nome_RazãoSocial");
            dgparecer.Columns.Add("Dt_Saida", "Data de Saída");
            dgparecer.Columns.Add("Tipo_Parecer", "Tipo de Parecer");
            dgparecer.Columns.Add("Obs", "Observação");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnumprocesso.Text == "")
            {
                MessageBox.Show("INSIRA O NÚMERO DO PROCESSO PARA A CONSULTA POR FAVOR", "CONSULTA PARECER DA COBRANÇA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string Consulta_Parecer = " select IE, CPF, Nome_RazaoSocial, Dt_Saida, Tipo_Parecer, Observacao from Tb_Parecer_Cobrança where Num_Processo = '" + txtnumprocesso.Text + "'";

                    cl_conexao.Abre_Conexao();

                    SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_Parecer);




                    while (reader.Read())
                    {
                        int indicelinha = dgparecer.Rows.Add();

                        dgparecer["IE", indicelinha].Value = reader[0].ToString();
                        dgparecer["CPF", indicelinha].Value = reader[1].ToString();
                        dgparecer["Nome_Razao", indicelinha].Value = reader[2].ToString();
                        dgparecer["Dt_Saida", indicelinha].Value = reader[3].ToString();
                        dgparecer["Tipo_Parecer", indicelinha].Value = reader[4].ToString();
                        dgparecer["Obs", indicelinha].Value = reader[5].ToString();


                    }

                    reader.Close();

                    cl_conexao.Fecha_Conexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Parecer não Cadastrado!", "Consulta de Parecer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
