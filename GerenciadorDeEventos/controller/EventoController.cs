using System;
using System.Collections.Generic;
using GerenciadorDeEventos.model.dao;
using GerenciadorDeEventos.model.dto;

namespace GerenciadorDeEventos.controller
{
    public class EventoController
    {
        private EventoDAO eventoDAO = new EventoDAO();
        private ConvidadoEventoDAO ceDAO = new ConvidadoEventoDAO();

        // Cadastra um novo evento
        public void CadastrarEvento(EventoDTO evento)
        {
            eventoDAO.CadastrarEvento(evento);
        }

        // Retorna a lista de eventos cadastrados
        public List<EventoDTO> ListarEventos()
        {
            return eventoDAO.ListarEventos();
        }

        // Atualiza o status de um convidado em um evento (ex.: "PRESENTE" ou "AUSENTE")
        public void AtualizarStatusConvidado(int idConvidado, int idEvento, string status)
        {
            // Validação simples do status
            if (status != "PRESENTE" && status != "AUSENTE" && status != "N/A")
                throw new Exception("Status inválido. Utilize 'PRESENTE', 'AUSENTE' ou 'N/A'.");

            ceDAO.AtualizarStatus(idConvidado, idEvento, status);
        }

        // Deleta um evento e remove suas associações
        public void DeletarEvento(int idEvento)
        {
            eventoDAO.DeletarEvento(idEvento);
        }
    }
}
