using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace ClinicConsultas
{
    class Conexao
    {

        //NpgsqlConnection strConexao = new NpgsqlConnection();
        public static string strConexao = "Server=localhost;Database=clinica;User Id=postgres;Password=sqladmin";
        //private static string strConexao = "Server=localhost;Database=ae;User Id=postgres;Password=euadm";
        //public static NpgsqlConnection Conn { get; set; }

        //NpgsqlDataReader leitor = new NpgsqlDataReader();
        

        public static NpgsqlConnection conexao = new NpgsqlConnection();

        public static bool confirmarusuario (string comandosql)
        {
            NpgsqlDataReader leitor;
            NpgsqlCommand comando = new NpgsqlCommand(comandosql, conexao);
            leitor = comando.ExecuteReader();

            bool teste = true;

            if(leitor.Read())
            {
                teste = true;
            }
            else
            {
                teste = false;
            }
            return teste;
        }


  

        public static void Conecta()
        {
            try
            {
                conexao.ConnectionString = strConexao;
                conexao.Open();
            }
            catch (NpgsqlException ex)
            {
                string error = ex.Message;
            }
        }

        public static void Desconecta()
        {
            if(conexao.State==ConnectionState.Open)
            {
                conexao.Close();
            }
        }

       /* public static bool gravar(string comandosql)
        {
            NpgsqlDataReader leitor;
            NpgsqlCommand comando = new NpgsqlCommand(comandosql, conexao);
            leitor = comando.ExecuteReader();

            bool teste = true;

            if (leitor.Read())
            {
                teste = true;
            }
            else
            {
                teste = false;
            }
            return teste;
        } */    
    }
}
