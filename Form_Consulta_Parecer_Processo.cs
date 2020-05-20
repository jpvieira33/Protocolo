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
    public partial class Form_Consulta_Parecer_Processo : Form
    {
        public Form_Consulta_Parecer_Processo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Close();

            }
        }

        private void Form_Consulta_Parecer_Processo_Load(object sender, EventArgs e)
        {
            dgprocesso.Rows.Clear();

            dgprocesso.Columns.Add("TipoCliente", "Tipo de Cliente");
            dgprocesso.Columns.Add("IE", "IE");
            dgprocesso.Columns.Add("CNPJ", "CNPJ");
            dgprocesso.Columns.Add("CPF", "CPF");
            dgprocesso.Columns.Add("NomeRazao", "Nome/Razao Social");
            dgprocesso.Columns.Add("Data_Entrada", "Data de Entrada");
            dgprocesso.Columns.Add("Destino", "Destino");
            dgprocesso.Columns.Add("Assunto", "Assunto");
            dgprocesso.Columns.Add("TipoParecer", "Tipo de Parecer");
            dgprocesso.Columns.Add("Data_Saida", "Data de Saida");
            dgprocesso.Columns.Add("Obs", "Observação");
            dgprocesso.Columns.Add("Usuario", "Usuario");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnumprocesso.Text == "")
            {
                MessageBox.Show("INSIRA O NÚMERO DO PROCESSO PARA A CONSULTA POR FAVOR", "CONSULTA AO PARACER DO PROCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string Consulta_Parecer_Processo = " select Tipo_Cliente, IE, CNPJ, CPF, Nome_RazaoSocial, Data_Entrada, Destino, Assunto, Tipo_Parecer, Data_Saida, Observacao, Usuario from Tb_Parecer_Processo where Num_Processo = '" + txtnumprocesso.Text + "'";

                    cl_conexao.Abre_Conexao();

                    SqlDataReader reader = cl_conexao.ComandoConsulta(Consulta_Parecer_Processo);

                    while (reader.Read())
                    {
                        int indicelinha = dgprocesso.Rows.Add();

                        dgprocesso["TipoCliente", indicelinha].Value = reader[0].ToString();
                        dgprocesso["IE", indicelinha].Value = reader[1].ToString();
                        dgprocesso["CNPJ", indicelinha].Value = reader[2].ToString();
                        dgprocesso["CPF", indicelinha].Value = reader[3].ToString();
                        dgprocesso["NomeRazao", indicelinha].Value = reader[4].ToString();
                        dgprocesso["Data_Entrada", indicelinha].Value = reader[5].ToString();
                        dgprocesso["Destino", indicelinha].Value = reader[6].ToString();
                        dgprocesso["Assunto", indicelinha].Value = reader[7].ToString();
                        dgprocesso["TipoParecer", indicelinha].Value = reader[8].ToString();
                        dgprocesso["Data_Saida", indicelinha].Value = reader[9].ToString();
                        dgprocesso["Obs", indicelinha].Value = reader[10].ToString();
                        dgprocesso["Usuario",indicelinha].Value = reader[11].ToString();
                    }

                    reader.Close();

                    cl_conexao.Fecha_Conexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Parecer não Cadastrado!", "Consulta de Parecer do Processo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
    }
}
