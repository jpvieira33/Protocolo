using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Projeto_Protocolo
{
 
    class cl_conexao
    {
        private static SqlConnection objConn;
    
       public cl_conexao()
       {
       }

     /// <summary>
        /// Abre a Conexão com o Banco
        /// </summary>
        public static void Abre_Conexao()
        {
            string connection;
            connection = "Data Source= SZ-S967NLM\\SQLEXPRESS;Initial Catalog=db_protocolo;Integrated Security=True";

            objConn = new SqlConnection(connection);
            objConn.Open();
        }
        
        /// <summary>
        /// Fecha a Conexão com o Banco
        /// </summary>
        public static void Fecha_Conexao()
        {
            if (objConn != null)
                objConn.Close();
        }

        /// <summary>
        /// Executa um comando no banco de dados
        /// </summary>
        /// <param name="inserir">Comando SQL a ser executado</param>
        /// <returns>Número de linhas afetadas pela execução do comando</returns>
        public static void ComandoInserir(string inserir)
        {
            SqlCommand cmd = new SqlCommand(inserir, objConn);
            cmd.ExecuteNonQuery();
            
        }

        /// <summary>
        /// Executa uma consulta no banco de dados
        /// </summary>
        /// <param name="consulta">Consulta a ser executada<</param>
        /// <returns>DataReader com o resultado da consulta</returns>
        public static SqlDataReader ComandoConsulta(string consulta)
        {
            SqlCommand cmd = new SqlCommand(consulta, objConn);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        /// <summary>
        /// Executa uma consulta escalar no banco de dados
        /// </summary>
        /// <param name="consulta">Consulta a ser executada<</param>
        /// <returns>Objeto com o resultado da consulta</returns>
        public static object ComandoConsultaEscalar(string consulta)
        {
            SqlCommand cmd = new SqlCommand(consulta, objConn);

            object resultado = cmd.ExecuteScalar();

            return resultado;
        }

    }
}


