using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEventos.model.dto
{
    public class EventoDTO
    {
        public int IdEvento { get; set; }
        public string Nome { get; set; }
        public DateTime DtHora { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Duracao { get; set; }
    }
}

