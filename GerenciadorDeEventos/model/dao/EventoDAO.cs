using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using GerenciadorDeEventos.model.dto;
using GerenciadorDeEventos.util;

namespace GerenciadorDeEventos.model.dao
{
    public class EventoDAO
    {
        private ConexaoBD conexao = new ConexaoBD();

        public void CadastrarEvento(EventoDTO evento)
        {
            string sql = "INSERT INTO Evento (idEvento, nome, dt_hora, local, descricao, categoria, duracao) " +
                         "VALUES (@idEvento, @nome, @dt_hora, @local, @descricao, @categoria, @duracao)";
            using (var conn = conexao.Conectar())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idEvento", evento.IdEvento);
                cmd.Parameters.AddWithValue("@nome", evento.Nome);
                cmd.Parameters.AddWithValue("@dt_hora", evento.DtHora);
                cmd.Parameters.AddWithValue("@local", evento.Local);
                cmd.Parameters.AddWithValue("@descricao", evento.Descricao);
                cmd.Parameters.AddWithValue("@categoria", evento.Categoria);
                cmd.Parameters.AddWithValue("@duracao", evento.Duracao);
                cmd.ExecuteNonQuery();
            }
        }

        public List<EventoDTO> ListarEventos()
        {
            List<EventoDTO> eventos = new List<EventoDTO>();
            string sql = "SELECT idEvento, nome, dt_hora, local, descricao, categoria, duracao FROM Evento";
            using (var conn = conexao.Conectar())
            using (var cmd = new MySqlCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    EventoDTO evento = new EventoDTO
                    {
                        IdEvento = reader.GetInt32("idEvento"),
                        Nome = reader.GetString("nome"),
                        DtHora = reader.GetDateTime("dt_hora"),
                        Local = reader.GetString("local"),
                        Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? null : reader.GetString("descricao"),
                        Categoria = reader.IsDBNull(reader.GetOrdinal("categoria")) ? null : reader.GetString("categoria"),
                        Duracao = reader.IsDBNull(reader.GetOrdinal("duracao")) ? null : reader.GetString("duracao")
                    };
                    eventos.Add(evento);
                }
            }
            return eventos;
        }

        public void DeletarEvento(int idEvento)
        {
            using (var conn = conexao.Conectar())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Primeiro, remove as associações na tabela ConvidadoEvento
                        string sqlDeleteCE = "DELETE FROM ConvidadoEvento WHERE idEvento = @idEvento";
                        using (var cmd = new MySqlCommand(sqlDeleteCE, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@idEvento", idEvento);
                            cmd.ExecuteNonQuery();
                        }

                        // Em seguida, deleta o evento da tabela Evento
                        string sqlDeleteEvento = "DELETE FROM Evento WHERE idEvento = @idEvento";
                        using (var cmd = new MySqlCommand(sqlDeleteEvento, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@idEvento", idEvento);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao deletar evento: " + ex.Message);
                    }
                }
            }
        }
    }
}
