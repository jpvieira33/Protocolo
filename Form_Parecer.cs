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
    public partial class Form_Parecer : Form
    {
        public Form_Parecer()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Inserir_Parecer = " insert into Tb_Parecer_Cobrança values('" + txtprocesso.Text + "', '" + txtIE_parecer.Text + "','" + txtcnpj.Text +"', '" + txtcpf_parecer.Text + "', '" + txtnomerazao_parecer.Text + "', convert(datetime, '" + dtsaida.Value.ToShortDateString() + "',103),'" + cbtipoparecer.Text + "','" + txtobservacao.Text + "')";

                cl_conexao.Abre_Conexao();

                cl_conexao.ComandoInserir(Inserir_Parecer);

                cl_conexao.Fecha_Conexao();

                txtprocesso.Text = "";
                txtIE_parecer.Text = "";
                txtcnpj.Text = "";
                txtcpf_parecer.Text = "";
                txtnomerazao_parecer.Text = "";
                dtsaida.Text = "";
                cbtipoparecer.Text = "";
                txtobservacao.Text = "";
                

                MessageBox.Show("Parecer Salvo com Sucesso !", "Parecer da Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Ao Cadastrar. Verifique se Todos os Campos estão Preechidos Corretamente!", "Parecer da Cobrança", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnconsultar_processo_Click(object sender, EventArgs e)
        {
            try
            {
                string Consulta_Parecer_Processo = " select * from Tb_Cadastro_Cobrança where Num_Processo = '" + txtprocesso.Text + "'";

                cl_conexao.Abre_Conexao();

                SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_Parecer_Processo);

                reader.Read();

                txtIE_parecer.Text = reader[5].ToString();
                txtcpf_parecer.Text = reader[7].ToString();
                txtcnpj.Text = reader[6].ToString();
                txtnomerazao_parecer.Text= reader[9].ToString();
               
             


                reader.Close();

                cl_conexao.Fecha_Conexao();
            }

            catch (Exception)
            {
                MessageBox.Show("Parecer não Cadastrado", "Parecer do Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                string id;
                cl_conexao.Abre_Conexao();

                string ConsultaID = "select Num_Processo from Tb_Parecer_Cobrança where Num_Processo= " + txtprocesso.Text + "";

                object objId = cl_conexao.ComandoConsultaEscalar(ConsultaID);

                if (objId == null)
                {
                    cl_conexao.Fecha_Conexao();
                    return;
                }

                id = objId.ToString();

                string Altera_Produto = "update Tb_Parecer_Cobrança  set Num_Processo = '" + txtprocesso.Text + "',IE =  '" + txtIE_parecer.Text + "',CNPJ = '" +txtcnpj.Text +"', CPF='" + txtcpf_parecer.Text + "', Nome_RazaoSocial ='" + txtnomerazao_parecer.Text + "', Dt_Saida = convert(datetime,'" + dtsaida.Value.ToShortDateString() + "',103)   , Tipo_Parecer = '" + cbtipoparecer.Text + "', Observacao= '" + txtobservacao.Text + "' where Num_Processo = " + id;
                cl_conexao.ComandoInserir(Altera_Produto);

                cl_conexao.Fecha_Conexao();

                txtprocesso.Text = "";
                txtIE_parecer.Text = "";
                txtcnpj.Text = "";
                txtcpf_parecer.Text = "";
                txtnomerazao_parecer.Text = "";
                dtsaida.Text = "";
                cbtipoparecer.Text = "";
                txtobservacao.Text = "";
               


                MessageBox.Show("Parecer Alterado com Sucesso!", "Parecer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Durante a Alteração!", "Parecer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form_Parecer_Load(object sender, EventArgs e)
        {

        }

        private void btnsairparecer_Click(object sender, EventArgs e)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtprocesso.Text = "";
            txtIE_parecer.Text = "";
            txtcnpj.Text = "";
            txtcpf_parecer.Text = "";
            txtnomerazao_parecer.Text = "";
            dtsaida.Text = "";
            cbtipoparecer.Text = "";
            txtobservacao.Text = "";
           
        }
    }
}
