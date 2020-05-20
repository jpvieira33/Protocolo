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
    public partial class Form_Consulta_Cobrança : Form
    {
        public Form_Consulta_Cobrança()
        {
            InitializeComponent();
        }

        private void Form_Consulta_Cobrança_Load(object sender, EventArgs e)
        {
            dgcobrança.Rows.Clear();
            dgcobrança.Columns.Add("NumProcesso", "Nº do Processo");
            dgcobrança.Columns.Add("NumProSaoLuis", "Nº do Processo São Luis");
            dgcobrança.Columns.Add("NumAuto", "Nº do Auto");
            dgcobrança.Columns.Add("NumNotificacao", "Nº da Notificação");
            dgcobrança.Columns.Add("ValorDebi", "Valor de Debito");
            dgcobrança.Columns.Add("Nome_Razao", "Nome_RazaoSocial");
            dgcobrança.Columns.Add("Situacao", "Situação");
            dgcobrança.Columns.Add("Destino", "Destino");
            dgcobrança.Columns.Add("DtEntr", "Data de Entrada");
            dgcobrança.Columns.Add("Assunto", "Assunto");
        }

        private void btn_CosnultarCPF_Click(object sender, EventArgs e)
        {
            if (txtcpf.Text == "")
            {
                MessageBox.Show("INSIRA UM CPF PARA CONSULTAR A COBRANÇA POR FAVOR", "CONSULTA DE COBRANÇA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string Consulta_CobrancaCPF = " select Num_Processo, Num_Processo_SaoLuis , Num_Auto, Num_Notificacao, Valor_Debito, Nome_RazaoSocial, Situacao, Destino, Dt_Entrada, Assunto from Tb_Cadastro_Cobrança where CPF = '" + txtcpf.Text + "'";

                    cl_conexao.Abre_Conexao();

                    SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_CobrancaCPF);

                    while (reader.Read())
                    {
                        int indicelinha = dgcobrança.Rows.Add();

                        dgcobrança["NumProcesso", indicelinha].Value = reader[0].ToString();
                        dgcobrança["NumProSaoLuis", indicelinha].Value = reader[1].ToString();
                        dgcobrança["NumAuto", indicelinha].Value = reader[2].ToString();
                        dgcobrança["NumNotificacao", indicelinha].Value = reader[3].ToString();
                        dgcobrança["ValorDebi", indicelinha].Value = reader[4].ToString();
                        dgcobrança["Nome_Razao", indicelinha].Value = reader[5].ToString();
                        dgcobrança["Situacao", indicelinha].Value = reader[6].ToString();
                        dgcobrança["Destino", indicelinha].Value = reader[7].ToString();
                        dgcobrança["DtEntr", indicelinha].Value = reader[8].ToString();
                        dgcobrança["Assunto", indicelinha].Value = reader[9].ToString();

                    }
                    reader.Close();

                    cl_conexao.Fecha_Conexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Cobrança não Cadastrada!", "Consulta de Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_CosnultarIE_Click(object sender, EventArgs e)
        {
            if (txtIE.Text == "")
            {
                MessageBox.Show("INSIRA UMA IE PARA CONSULTAR A COBRANÇA POR FAVOR", "CONSULTA DE COBRANÇA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string Consulta_ProcessoCPF = " select Num_Processo, Num_Processo_SaoLuis , Num_Auto, Num_Notificacao , Valor_Debito, Nome_RazaoSocial ,Situacao,Destino,Dt_Entrada,Assunto from Tb_Cadastro_Cobrança where IE = '" + txtIE.Text + "'";

                    cl_conexao.Abre_Conexao();

                    SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_ProcessoCPF);

                    while (reader.Read())
                    {
                        int indicelinha = dgcobrança.Rows.Add();

                        dgcobrança["NumProcesso", indicelinha].Value = reader[0].ToString();
                        dgcobrança["NumProSaoLuis", indicelinha].Value = reader[1].ToString();
                        dgcobrança["NumAuto", indicelinha].Value = reader[2].ToString();
                        dgcobrança["NumNotificacao", indicelinha].Value = reader[3].ToString();
                        dgcobrança["ValorDebi", indicelinha].Value = reader[4].ToString();
                        dgcobrança["Nome_Razao", indicelinha].Value = reader[5].ToString();
                        dgcobrança["Situacao", indicelinha].Value = reader[6].ToString();
                        dgcobrança["Destino", indicelinha].Value = reader[7].ToString();
                        dgcobrança["DtEntr", indicelinha].Value = reader[8].ToString();
                        dgcobrança["Assunto", indicelinha].Value = reader[9].ToString();

                    }
                    reader.Close();

                    cl_conexao.Fecha_Conexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Cobrança não Cadastrada!", "Consulta de Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcnpj.Text == "")
            {
                MessageBox.Show("INSIRA UM CNPJ PARA CONSULTAR A COBRANÇA", "CONSULTA DE COBRANÇA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string Consulta_ProcessoCPF = " select Num_Processo, Num_Processo_SaoLuis , Num_Auto, Num_Notificacao , Valor_Debito, Nome_RazaoSocial ,Situacao,Destino,Dt_Entrada,Assunto from Tb_Cadastro_Cobrança where CNPJ = '" + txtcnpj.Text + "'";

                    cl_conexao.Abre_Conexao();

                    SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_ProcessoCPF);

                    while (reader.Read())
                    {
                        int indicelinha = dgcobrança.Rows.Add();

                        dgcobrança["NumProcesso", indicelinha].Value = reader[0].ToString();
                        dgcobrança["NumProSaoLuis", indicelinha].Value = reader[1].ToString();
                        dgcobrança["NumAuto", indicelinha].Value = reader[2].ToString();
                        dgcobrança["NumNotificacao", indicelinha].Value = reader[3].ToString();
                        dgcobrança["ValorDebi", indicelinha].Value = reader[4].ToString();
                        dgcobrança["Nome_Razao", indicelinha].Value = reader[5].ToString();
                        dgcobrança["Situacao", indicelinha].Value = reader[6].ToString();
                        dgcobrança["Destino", indicelinha].Value = reader[7].ToString();
                        dgcobrança["DtEntr", indicelinha].Value = reader[8].ToString();
                        dgcobrança["Assunto", indicelinha].Value = reader[9].ToString();

                    }
                    reader.Close();

                    cl_conexao.Fecha_Conexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Cobrança não Cadastrada!", "Consulta de Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
