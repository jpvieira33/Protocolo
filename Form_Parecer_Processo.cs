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
    public partial class Form_Parecer_Processo : Form
    {
        public Form_Parecer_Processo()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtnumprocesso.Text == "")
            {
                MessageBox.Show(" POR FAVOR PREENCHA O Nº DO PROCESSO", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbtipocliente.Text == "")
            {
                MessageBox.Show(" POR FAVOR PREENCHA O TIPO DE CLIENTE", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtIE.Text == "" && txtcpf.Text == "" && txtcnpj.Text == "")
            {
                MessageBox.Show(" POR FAVOR PREENCHA O IE OU CPF OU CNPJ", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtnomerazao.Text == "")
            {
                MessageBox.Show(" POR FAVOR PREENCHA O NOME OU RAZÃO SOCIAL", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtdestino.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O DESTINO", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtassunto.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O ASSUNTO", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txttipoparecer.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O TIPO DE PARECER", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             else if (txtusuarioprocesso.Text== "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O USUÁRIO", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    string Incluir_Parecer_Processo = " insert into Tb_Parecer_Processo values('" + txtnumprocesso.Text + "', '" + cbtipocliente.Text + "','" + txtIE.Text + "', '" + txtcnpj.Text + "', '" + txtcpf.Text + "', '" + txtnomerazao.Text + "',convert(datetime, '" + txtdataentrada.Value.ToShortDateString() + "',103) , '" + txtdestino.Text + "','" + txtassunto.Text + "','" + txttipoparecer.Text + "',convert(datetime, '" + txtdatasaida.Value.ToShortDateString() + "',103),'" + txtobservacao.Text + "', '" + txtusuarioprocesso.Text +"')";

                    cl_conexao.Abre_Conexao();

                    cl_conexao.ComandoInserir(Incluir_Parecer_Processo);

                    cl_conexao.Fecha_Conexao();

                    txtnumprocesso.Text = "";
                    cbtipocliente.Text = "";
                    txtIE.Text = "";
                    txtcnpj.Text = "";
                    txtcpf.Text = "";
                    txtnomerazao.Text = "";
                    txtdataentrada.Text = "";
                    txtdestino.Text = "";
                    txtassunto.Text = "";
                    txttipoparecer.Text = "";
                    txtdatasaida.Text = "";
                    txtobservacao.Text = "";
                    txtusuarioprocesso.Text = "";

                    MessageBox.Show("Parecer Salvo com Sucesso!", "Parecer do Processo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro Ao Cadastrar. Verifique se Todos os Campos estão Preechidos Corretamente!", "Parecer do Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
            
                string Consulta_Parecer_Processo = " select * from Tb_Atendimento where Num_Processo = '" + txtnumprocesso.Text + "'";

                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_Parecer_Processo);
                

                if (reader.Read())
                {

                    cbtipocliente.Text = reader[1].ToString();
                    txtIE.Text = reader[2].ToString();
                    txtcnpj.Text = reader[3].ToString();
                    txtcpf.Text = reader[4].ToString();
                    txtnomerazao.Text = reader[5].ToString();
                    txtdataentrada.Text = reader[6].ToString();
                    txtdestino.Text = reader[7].ToString();
                    txtassunto.Text = reader[9].ToString();
                    txtusuarioprocesso.Text = reader[13].ToString();
       
                    }
                
                    reader.Close();
                
                cl_conexao.Fecha_Conexao();
            
            }
            catch (Exception)
            {
                MessageBox.Show("Parecer não Cadastrado", "Parecer do Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
               
                cl_conexao.Abre_Conexao();

                string Altera_Produto = "update Tb_Parecer_Processo  set  Tipo_Parecer = '" + txttipoparecer.Text + "', Data_Saida = convert(datetime,'" + txtdatasaida.Value.ToShortDateString() + "',103), Observacao = '" + txtobservacao.Text + "' where Num_Processo = '" + txtnumprocesso.Text +"'";
                string Altera_Processo = "update Tb_Atendimento set Num_Processo = '" + txtnumprocesso.Text + "',Tipo_Cliente =  '" + cbtipocliente.Text + "',IE= '" + txtIE.Text + "', CNPJ ='" + txtcnpj.Text + "', CPF ='" + txtcpf.Text + "', Nome_RazaoSocial = '" + txtnomerazao.Text + "'  , Dt_Entrada = convert(datetime, '" + txtdataentrada.Value.ToShortDateString() + "',103), Destino = '" + txtdestino.Text + "', Assunto = '" + txtassunto.Text + "' where Num_Processo ='" + txtnumprocesso.Text+"'";
                cl_conexao.ComandoInserir(Altera_Produto);
                cl_conexao.ComandoInserir(Altera_Processo);

                cl_conexao.Fecha_Conexao();

                txtnumprocesso.Text = "";
                cbtipocliente.Text = "";
                txtIE.Text = "";
                txtcnpj.Text = "";
                txtcpf.Text = "";
                txtnomerazao.Text = "";
                txtdataentrada.Text = "";
                txtdestino.Text = "";
                txtassunto.Text = "";
                txttipoparecer.Text = "";
                txtdatasaida.Text = "";
                txtobservacao.Text = "";
                txtusuarioprocesso.Text = "";

              


                MessageBox.Show("Parecer Alterado com Sucesso!", "Parecer do Processo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Durante a Alteração!", "Parecer do Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnumprocesso.Text = "";
            cbtipocliente.Text = "";
            txtIE.Text = "";
            txtcnpj.Text = "";
            txtcpf.Text = "";
            txtnomerazao.Text = "";
            txtdataentrada.Text = "";
            txtdestino.Text = "";
            txtassunto.Text = "";
            txttipoparecer.Text = "";
            txtdatasaida.Text = "";
            txtobservacao.Text = "";
            txtusuarioprocesso.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Close();

            }
        }
        
        void Button1Click(object sender, EventArgs e)
        {
        	try
            {
            
                string Consulta_Parecer_Processo = " select * from Tb_Parecer_Processo where Num_Processo = '" + txtnumprocesso.Text + "'";

                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_Parecer_Processo);
                

                if (reader.Read())
                {

                	txttipoparecer.Text = reader[10].ToString();
                	txtdatasaida.Text = reader[11].ToString();
                	txtobservacao.Text = reader[12].ToString();
                	txtusuarioprocesso.Text = reader[13].ToString();
       
                    }
                
                    reader.Close();
                
                cl_conexao.Fecha_Conexao();
            
            }
            catch (Exception)
            {
                MessageBox.Show("Parecer não Cadastrado", "Parecer do Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        }
    }
}
