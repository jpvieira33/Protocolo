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
    public partial class Form_Cobrança : Form
    {
        public Form_Cobrança()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
        		try
        		{
                string Inserir_Cobrança = " insert into Tb_Cadastro_Cobrança values('" + txtnumProcesso.Text + "', '" + txtNumSaoluis.Text +"', '" + txtNumAuto.Text + "', '" + txtNumNotif.Text+ "', '" + txtIE.Text + "','" + txtcnpj.Text +"', '" + txtcpf.Text + "', '" + txtvalor.Text + "','" + txtnome_razao.Text + "', '" + cbsituacao.Text + "', '" + cbdestino.Text + "', convert(datetime, '" + dtentrada.Value.ToShortDateString() + "',103), '" + txtassunto.Text + "')";

                cl_conexao.Abre_Conexao();

                cl_conexao.ComandoInserir(Inserir_Cobrança);

                cl_conexao.Fecha_Conexao();

                txtnumProcesso.Text = "";
                txtNumSaoluis.Text = "";
                txtNumAuto.Text = "";
                txtNumNotif.Text = "";
                txtIE.Text = "";
                txtcnpj.Text = "";
                txtcpf.Text = "";
                txtvalor.Text = "";
                txtnome_razao.Text = "";
                cbsituacao.Text = "";
                cbdestino.Text = "";
                txtassunto.Text = "";

                MessageBox.Show("Cobrança Cadastrada com Sucesso !", "Cadastro de Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Ao Cadastrar. Verifique se Todos os Campos estão Preechidos Corretamente!", "Cadastro de Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnsairparecer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnconsultar_processo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnconsultaIE_Click(object sender, EventArgs e)
        {
            try
            {
            	if(txtIE.Text == "")
            	{
            		MessageBox.Show("INSIRA UMA IE POR FAVOR","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            	}
            	else
            	{
                string ConsultaProcessoIE = " select * from Tb_Atendimento where IE = '" + txtIE.Text + "'";


                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(ConsultaProcessoIE);
                reader.Read();

                txtnome_razao.Text = reader[5].ToString();


                reader.Close();
            	}

                cl_conexao.Fecha_Conexao();
            }
          
            
            catch (Exception)
            {
                MessageBox.Show("Cliente não Cadastrado", "Cadastro de Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
            	if(txtcpf.Text == "")
            	{
            		MessageBox.Show("INSIRA UMA CPF POR FAVOR","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            	}
            	else
            	{

                string ConsultaProcessoCPF = " select * from Tb_Atendimento where CPF = '" + txtcpf.Text + "'";


                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(ConsultaProcessoCPF);
                reader.Read();

                txtnome_razao.Text = reader[5].ToString();


                reader.Close();
            	}
                cl_conexao.Fecha_Conexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente não Cadastrado", "Cadastro de Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {

              

               
            
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Close();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           
               
            
        }

        private void Form_Cobrança_Activated(object sender, EventArgs e)
        {
            /*
            string Checar_Ultimo = " select max(Num_processo)+1 as ultimo from tb_atendimento ";
            cl_conexao.Abre_Conexao();
            SqlDataReader reader = cl_conexao.ComandoConsulta(Checar_Ultimo);
            reader.Read();
            txtnumProcesso.Text = reader[0].ToString();
            reader.Close();
            cl_conexao.Fecha_Conexao();
            */
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumNotif_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtassunto_TextChanged(object sender, EventArgs e)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnumProcesso.Text = "";
            txtNumSaoluis.Text = "";
            txtNumAuto.Text = "";
            txtNumNotif.Text = "";
            txtIE.Text = "";
            txtcnpj.Text = "";
            txtcpf.Text = "";
            txtvalor.Text = "";
            txtnome_razao.Text = "";
            cbsituacao.Text = "";
            cbdestino.Text = "";
            txtassunto.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
            	if(txtcnpj.Text == "")
            	{
            		MessageBox.Show("INSIRA UMA CNPJ POR FAVOR","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            	}
            	else
            	{
                string ConsultaProcessoCNPJ = " select * from Tb_Atendimento where CNPJ = '" + txtcnpj.Text + "'";


                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(ConsultaProcessoCNPJ);
                reader.Read();

                txtnome_razao.Text = reader[4].ToString();


                reader.Close();
            	}
                cl_conexao.Fecha_Conexao();
            }


            catch (Exception)
            {
                MessageBox.Show("Cliente não Cadastrado", "Cadastro de Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
