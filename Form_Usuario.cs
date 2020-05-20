using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Protocolo
{
    public partial class Form_Usuario : Form
    {
        public Form_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Inserir_Usuario = " insert into Tb_Usuario values('" + txtnome.Text + "','" + txtusuario.Text + "', '" + txtsenha.Text + "', '" + cbstatus.Text+ "', convert(datetime, '" + txtdata.Value.ToShortDateString() + "', 103),null)";

                cl_conexao.Abre_Conexao();
                cl_conexao.ComandoInserir(Inserir_Usuario);
                cl_conexao.Fecha_Conexao();

                txtnome.Text = "";
                txtusuario.Text = "";
                txtsenha.Text = "";
                cbstatus.Text = "";
                txtdata.Text = "";

                MessageBox.Show("Usuário Inserido com Sucesso !", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Erro Ao Cadastrar. Verifique se Todos os Campos estão Preechidos Corretamente!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Close();

            }
        }
    }
}
