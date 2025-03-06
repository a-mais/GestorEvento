using System;
using MySql.Data.MySqlClient;
using GerenciadorDeEventos.util;

namespace GerenciadorDeEventos.model.dao
{
    public class ConvidadoEventoDAO
    {
        private ConexaoBD conexao = new ConexaoBD();

        public void AtualizarStatus(int idConvidado, int idEvento, string status)
        {
            string sql = "UPDATE ConvidadoEvento SET status = @status " +
                         "WHERE idConvidado = @idConvidado AND idEvento = @idEvento";
            using (var conn = conexao.Conectar())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@idConvidado", idConvidado);
                cmd.Parameters.AddWithValue("@idEvento", idEvento);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
