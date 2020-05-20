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
    public partial class Form_Processo : Form
    {
        public Form_Processo()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form_Processo_Load(object sender, EventArgs e)
        {
        

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtprocesso.Text == "") 
                {
                    MessageBox.Show("POR FAVOR GERE O NÚMERO DO PROTOCOLO","Nº PROTOCOLO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            else if (txtIE.Text == "" && txtcpf.Text == "" && txtcnpj.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O IE OU CPF OU CNPJ", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtnome_razao.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O NOME OU A RAZÃO SOCIAL", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtdestino.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O DESTINO", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtassunto.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O ASSUNTO", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbtipocliente.Text == "")
            {
                MessageBox.Show("POR FAVOR PREENCHA O TIPO DE CLIENTE", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtusuario.Text == "")
            {
            	MessageBox.Show("POR FAVOR PREENCHA O USUARIO", "OBRIGATÓRIO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {

                    string InserirAtendimento = "insert into Tb_Atendimento values('" + txtprocesso.Text + "','" + cbtipocliente.Text + "','" + txtIE.Text + "','" + txtcnpj.Text + "', '" + txtcpf.Text + "','" + txtnome_razao.Text + "', convert(datetime,'" + dtentrada.Value.ToShortDateString() + "', 103),'" + txtdestino.Text + "','" + txtmail.Text + "', '" + txtassunto.Text + "','" + txtusuario.Text + "')";

                    cl_conexao.Abre_Conexao();

                    cl_conexao.ComandoInserir(InserirAtendimento);

                    cl_conexao.Fecha_Conexao();

                    txtprocesso.Text = "";
                    cbtipocliente.Text = "";
                    txtIE.Text = "";
                    txtcnpj.Text = "";
                    txtcpf.Text = "";
                    txtnome_razao.Text = "";
                    dtentrada.Text = "";
                    txtdestino.Text = "";
                    txtmail.Text = "";
                    txtassunto.Text = "";
                    txtusuario.Text = "";

                    MessageBox.Show("Atendimento Salvo com Sucesso !", "Cadastro de Processo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro Ao Cadastrar. Verifique se Todos os Campos estão Preechidos Corretamente!", "Cadastro de Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string ConsultaProcessoCPF = " select * from Tb_Atendimento where CPF = '" + txtcpf.Text + "'";


                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(ConsultaProcessoCPF);
                reader.Read();


                cbtipocliente.Text = reader[1].ToString();
                txtnome_razao.Text = reader[5].ToString();
                

                txtmail.Text = reader[8].ToString();


                reader.Close();

                cl_conexao.Fecha_Conexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente não Cadastrado !", "Cadastro de Cliente/Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




            
            
        }

        private void btnconsultaIE_Click(object sender, EventArgs e)
        {
            try
            {
                string ConsultaProcessoIE = " select * from Tb_Atendimento where IE = '" + txtIE.Text + "'";

                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(ConsultaProcessoIE);
                reader.Read();


                cbtipocliente.Text = reader[1].ToString();
                txtnome_razao.Text = reader[5].ToString();
               

                txtmail.Text = reader[8].ToString();


                reader.Close();

                cl_conexao.Fecha_Conexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente não Cadastrado!", "Cadastro de Cliente/Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Close();

            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                 string id;
                cl_conexao.Abre_Conexao();

                if (cbtipocliente.Text == "P.JURIDICA")
                {

                    string ConsultaID = "select Num_Processo from Tb_Atendimento where  IE = '" + txtIE.Text + "' or  CNPJ = '" + txtcnpj.Text + "'";

                    object objId = cl_conexao.ComandoConsultaEscalar(ConsultaID);

                    if (objId == null)
                    {
                        cl_conexao.Fecha_Conexao();
                        return;
                    }

                    id = objId.ToString();

                    string Altera_Produto = "update Tb_Atendimento set Tipo_Cliente = '" + cbtipocliente.Text + "', IE =  '" + txtIE.Text + "', CNPJ = '" + txtcnpj.Text + "', CPF='" + txtcpf.Text + "', Nome_RazaoSocial ='" + txtnome_razao.Text + "', Dt_Entrada = convert(datetime,'" + dtentrada.Value.ToShortDateString() + "',103)   ,  Email= '" + txtmail.Text + "' where Num_Processo = " + id;
                    cl_conexao.ComandoInserir(Altera_Produto);
                }
                else
                {
                    string ConsultaID = "select Num_Processo from Tb_Atendimento where CPF = '" + txtcpf.Text + "'";

                    object objId = cl_conexao.ComandoConsultaEscalar(ConsultaID);

                    if (objId == null)
                    {
                        cl_conexao.Fecha_Conexao();
                        return;
                    }

                    id = objId.ToString();

                    string Altera_Atendimento = "update Tb_Atendimento set Tipo_Cliente = '" + cbtipocliente.Text + "', IE =  '" + txtIE.Text + "', CNPJ = '" + txtcnpj.Text + "', CPF='" + txtcpf.Text + "', Nome_RazaoSocial ='" + txtnome_razao.Text + "', Dt_Entrada = convert(datetime,'" + dtentrada.Value.ToShortDateString() + "',103)   ,  Email= '" + txtmail.Text + "' where Num_Processo = " + id;
                    cl_conexao.ComandoInserir(Altera_Atendimento);
                }



                cl_conexao.Fecha_Conexao();

                txtprocesso.Text = "";
                cbtipocliente.Text = "";
                txtIE.Text = "";
                txtcnpj.Text = "";
                txtcpf.Text = "";
                txtnome_razao.Text = "";
                dtentrada.Text = "";
                txtdestino.Text = "";
                txtmail.Text = "";
                txtassunto.Text = "";
                txtusuario.Text = "";

                MessageBox.Show("Processo Alteraddo com Sucesso!", "Cadastro de Processo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Durante a Alteração!", "Cadastro de Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             string Checar_Ultimo = "select max(num_processo) +1 from tb_atendimento where substring(num_processo,1,4) = '2013'";
            cl_conexao.Abre_Conexao();
            SqlDataReader reader = cl_conexao.ComandoConsulta(Checar_Ultimo);
            reader.Read();
            txtprocesso.Text = reader[0].ToString();
            reader.Close();
            cl_conexao.Fecha_Conexao();
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
            txtprocesso.Text = "";
            cbtipocliente.Text = "";
            txtIE.Text = "";
            txtcnpj.Text = "";
            txtcpf.Text = "";
            txtnome_razao.Text = "";
            dtentrada.Text = "";
            txtdestino.Text = "";
            txtmail.Text = "";
            txtassunto.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ConsultaProcessoCNPJ = " select * from Tb_Atendimento where CNPJ = '" + txtcnpj.Text + "'";

                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(ConsultaProcessoCNPJ);
                reader.Read();


                cbtipocliente.Text = reader[1].ToString();
                txtnome_razao.Text = reader[5].ToString();
              

                txtmail.Text = reader[8].ToString();


                reader.Close();

                cl_conexao.Fecha_Conexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente não Cadastrado!", "Cadastro de Cliente/Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
