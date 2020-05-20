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
    public partial class Form_TrocaSenha : Form
    {
        public Form_TrocaSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id;

                cl_conexao.Abre_Conexao();

                string ConsultaUsuario = " select Id_Usuario from Tb_Usuario where Senha = '" + txtsenha.Text + "'";

                object objid = cl_conexao.ComandoConsultaEscalar(ConsultaUsuario);

                if (objid == null)
                {
                    cl_conexao.Fecha_Conexao();
                    return;
                }

                id = objid.ToString();

                string Altera_Senha = " update Tb_Usuario set Senha = '" + txttrocasenha.Text + "' where Id_Usuario =" + id;

                cl_conexao.ComandoInserir(Altera_Senha);

                cl_conexao.Fecha_Conexao();

                txtusuario.Text = "";
                txtsenha.Text = "";
                txtnovasenha.Text = "";
                txttrocasenha.Text = "";

                MessageBox.Show("Senha Alterada com Sucesso!", "Troca de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show(" Confirme a Senha Corretamente!", "Troca de Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Close();

            }
        }
    }
}
