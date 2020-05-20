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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Consulta_Usuario = " select * from Tb_Usuario where Login = '" + txtlogin.Text + "' and  Senha = '" + txtsenha.Text + "'";

            cl_conexao.Abre_Conexao();

            SqlDataReader readerUsuario = cl_conexao.ComandoConsulta(Consulta_Usuario);


            


            if (readerUsuario.Read())
            {
   
                Form_Principal fp = new Form_Principal();
                fp.Show();
                this.Hide();

              
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha Incorreto", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtlogin.Focus();

            }

            readerUsuario.Close();

           

            cl_conexao.Fecha_Conexao();

            



        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair do Sistema?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
