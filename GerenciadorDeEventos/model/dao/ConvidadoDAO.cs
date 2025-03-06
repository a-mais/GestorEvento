using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using GerenciadorDeEventos.model.dto;
using GerenciadorDeEventos.util;

namespace GerenciadorDeEventos.model.dao
{
    public class ConvidadoDAO
    {
        private ConexaoBD conexao = new ConexaoBD();

        public void CadastrarConvidadoComEvento(ConvidadoDTO convidado, int idEvento)
        {
            // Observação: NÃO vamos inserir idConvidado manualmente.
            // Deixaremos o banco (com AUTO_INCREMENT) gerar esse valor.
            string sqlConvidado = @"
                INSERT INTO Convidado (nome, idade, sexo, numConvite)
                VALUES (@nome, @idade, @sexo, @numConvite);
            ";

            string sqlConvidadoEvento = @"
                INSERT INTO ConvidadoEvento (idConvidado, idEvento, status)
                VALUES (@idConvidado, @idEvento, 'N/A');
            ";

            using (var conn = conexao.Conectar())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1) Insere o convidado, deixando o banco gerar o idConvidado (AUTO_INCREMENT)
                        long idGerado;
                        using (var cmd = new MySqlCommand(sqlConvidado, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@nome", convidado.Nome);
                            cmd.Parameters.AddWithValue("@idade", convidado.Idade);
                            cmd.Parameters.AddWithValue("@sexo", convidado.Sexo);
                            cmd.Parameters.AddWithValue("@numConvite", convidado.NumConvite);

                            cmd.ExecuteNonQuery();
                            // Recupera o ID gerado pelo AUTO_INCREMENT
                            idGerado = cmd.LastInsertedId;
                        }

                        // 2) Insere na tabela ConvidadoEvento para vincular o convidado ao evento
                        using (var cmd = new MySqlCommand(sqlConvidadoEvento, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@idConvidado", idGerado);
                            cmd.Parameters.AddWithValue("@idEvento", idEvento);
                            cmd.ExecuteNonQuery();
                        }

                        // Confirma a transação
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao cadastrar convidado vinculado a evento: " + ex.Message);
                    }
                }
            }
        }

        public List<ConvidadoDTO> ListarConvidadosPorEvento(int idEvento)
        {
            List<ConvidadoDTO> convidados = new List<ConvidadoDTO>();
            string sql = @"
                SELECT c.idConvidado, c.nome, c.idade, c.sexo, c.numConvite, ce.status 
                FROM Convidado c 
                INNER JOIN ConvidadoEvento ce ON c.idConvidado = ce.idConvidado 
                WHERE ce.idEvento = @idEvento
            ";
            using (var conn = conexao.Conectar())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idEvento", idEvento);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ConvidadoDTO convidado = new ConvidadoDTO
                        {
                            IdConvidado = reader.GetInt32("idConvidado"),
                            Nome = reader.GetString("nome"),
                            Idade = reader.GetInt32("idade"),
                            Sexo = reader.GetString("sexo"),
                            NumConvite = reader.GetInt32("numConvite"),
                            Status = reader.GetString("status")
                        };
                        convidados.Add(convidado);
                    }
                }
            }
            return convidados;
        }

        public void DeletarConvidado(int idConvidado)
        {
            using (var conn = conexao.Conectar())
            {
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Primeiro, remove as associações na tabela ConvidadoEvento
                        string sqlDeleteConvidadoEvento = "DELETE FROM ConvidadoEvento WHERE idConvidado = @idConvidado";
                        using (var cmd = new MySqlCommand(sqlDeleteConvidadoEvento, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@idConvidado", idConvidado);
                            cmd.ExecuteNonQuery();
                        }

                        // Em seguida, deleta o convidado da tabela Convidado
                        string sqlDeleteConvidado = "DELETE FROM Convidado WHERE idConvidado = @idConvidado";
                        using (var cmd = new MySqlCommand(sqlDeleteConvidado, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@idConvidado", idConvidado);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao deletar convidado: " + ex.Message);
                    }
                }
            }
        }
    }
}
