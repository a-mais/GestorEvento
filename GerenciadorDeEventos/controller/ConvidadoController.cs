using System;
using System.Collections.Generic;
using GerenciadorDeEventos.model.dao;
using GerenciadorDeEventos.model.dto;

namespace GerenciadorDeEventos.controller
{
    public class ConvidadoController
    {
        private ConvidadoDAO convidadoDAO = new ConvidadoDAO();

        // Cadastra um novo convidado vinculado a um evento
        public void CadastrarConvidado(ConvidadoDTO convidado, int idEvento)
        {
            convidadoDAO.CadastrarConvidadoComEvento(convidado, idEvento);
        }

        // Lista os convidados associados a um determinado evento
        public List<ConvidadoDTO> ListarConvidadosPorEvento(int idEvento)
        {
            return convidadoDAO.ListarConvidadosPorEvento(idEvento);
        }

        // Deleta um convidado e remove suas associações
        public void DeletarConvidado(int idConvidado)
        {
            convidadoDAO.DeletarConvidado(idConvidado);
        }
    }
}
