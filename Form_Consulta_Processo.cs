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
    public partial class Form_Consulta_Processo : Form
    {
        public Form_Consulta_Processo()
        {
            InitializeComponent();
        }

        private void Form_Consulta_Processo_Load(object sender, EventArgs e)
        {
            dgprocesso.Rows.Clear();
            
            dgprocesso.Columns.Add("NumProcesso", " Nº do Processo");
            dgprocesso.Columns.Add("TipoCliente", "Tipo de Cliente");
            dgprocesso.Columns.Add("NomeRazao", "Nome/Razão Social");
            dgprocesso.Columns.Add("DtEntrada", "Data de Entrada");
            dgprocesso.Columns.Add("Destino", "Destino");
            dgprocesso.Columns.Add("Assunto", "Assunto");
            dgprocesso.Columns.Add("Usuario", "Usuario");

        }

        private void btnCosnultarCPF_Click(object sender, EventArgs e)
        {
            if (txtcpf.Text == "")
            {
                MessageBox.Show("INSIRA UM CPF PARA CONSULTAR O PROCESSO POR FAVOR", "CONSULTA DE PROCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    string Consulta_ProcessoCPF = " select Num_Processo, Tipo_Cliente , Nome_RazaoSocial , Dt_Entrada, Destino , Assunto, Usuario from Tb_Atendimento where CPF = '" + txtcpf.Text + "'";

                    cl_conexao.Abre_Conexao();

                    SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_ProcessoCPF);

                    while (reader.Read())
                    {
                        int indicelinha = dgprocesso.Rows.Add();

                        dgprocesso["NumProcesso", indicelinha].Value = reader[0].ToString();
                        dgprocesso["TipoCliente", indicelinha].Value = reader[1].ToString();
                        dgprocesso["NomeRazao", indicelinha].Value = reader[2].ToString();
                        dgprocesso["DtEntrada", indicelinha].Value = reader[3].ToString();
                        dgprocesso["Destino", indicelinha].Value = reader[4].ToString();
                        dgprocesso["Assunto", indicelinha].Value = reader[5].ToString();
                        dgprocesso["Usuario", indicelinha].Value = reader[6].ToString();
                    }
                    reader.Close();

                    cl_conexao.Fecha_Conexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Processo não Cadastrado!", "Consulta de Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnConsultarIE_Click(object sender, EventArgs e)
        {
            if (txtIE.Text == "")
            {
                MessageBox.Show("INSIRA UMA IE PARA CONSULTAR O PROCESSO POR FAVOR","CONSULTA DE PROCESSO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string Consulta_ProcessoCPF = " select Num_Processo, Tipo_Cliente , Nome_RazaoSocial , Dt_Entrada, Destino , Assunto, Usuario from Tb_Atendimento where IE = '" + txtIE.Text + "'";

                    cl_conexao.Abre_Conexao();

                    SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_ProcessoCPF);

                    while (reader.Read())
                    {
                        int indicelinha = dgprocesso.Rows.Add();

                        dgprocesso["NumProcesso", indicelinha].Value = reader[0].ToString();
                        dgprocesso["TipoCliente", indicelinha].Value = reader[1].ToString();
                        dgprocesso["NomeRazao", indicelinha].Value = reader[2].ToString();
                        dgprocesso["DtEntrada", indicelinha].Value = reader[3].ToString();
                        dgprocesso["Destino", indicelinha].Value = reader[4].ToString();
                        dgprocesso["Assunto", indicelinha].Value = reader[5].ToString();
                        dgprocesso["Usuario", indicelinha].Value = reader[6].ToString();

                    }
                    reader.Close();

                    cl_conexao.Fecha_Conexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Processo não Cadastrado!", "Consulta de Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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
                MessageBox.Show("INSIRA UM CNPJ PARA CONSULTAR O PROCESSO", "CONSULTA DE PROCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string Consulta_ProcessoCPF = " select Num_Processo, Tipo_Cliente , Nome_RazaoSocial , Dt_Entrada, Destino , Assunto , Usuario from Tb_Atendimento where CNPJ = '" + txtcnpj.Text + "'";

                    cl_conexao.Abre_Conexao();

                    SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_ProcessoCPF);

                    while (reader.Read())
                    {
                        int indicelinha = dgprocesso.Rows.Add();

                        dgprocesso["NumProcesso", indicelinha].Value = reader[0].ToString();
                        dgprocesso["TipoCliente", indicelinha].Value = reader[1].ToString();
                        dgprocesso["NomeRazao", indicelinha].Value = reader[2].ToString();
                        dgprocesso["DtEntrada", indicelinha].Value = reader[3].ToString();
                        dgprocesso["Destino", indicelinha].Value = reader[4].ToString();
                        dgprocesso["Assunto", indicelinha].Value = reader[5].ToString();
                        dgprocesso["Usuario",indicelinha].Value = reader[6].ToString();
                    }
                    reader.Close();

                    cl_conexao.Fecha_Conexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Processo não Cadastrado!", "Consulta de Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}