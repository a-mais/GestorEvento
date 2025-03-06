using System;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEventos.util
{
    internal class ConexaoBD
    {
        // String de conexão com o banco de dados.
        // Altere os parâmetros conforme sua configuração: servidor, banco de dados, usuário e senha.
        private readonly string connectionString = "server=localhost;database=GestorEvento;uid=root;password=;";
        private MySqlConnection connection;

        // Método para abrir a conexão com o banco de dados.
        public MySqlConnection Conectar()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                // Trata exceções específicas do MySQL
                throw new Exception("Erro ao conectar com o banco de dados MySQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Trata outras exceções
                throw new Exception("Ocorreu um erro: " + ex.Message);
            }
        }

        // Método para fechar a conexão, caso esteja aberta.
        public void Desconectar()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
