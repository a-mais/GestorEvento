using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEventos.model.dto
{
    namespace GerenciadorDeEventos.dto
    {
        public class ConvidadoEventoDTO
        {
            public int IdConvidado { get; set; }
            public int IdEvento { get; set; }
            // Valores possíveis: "PRESENTE", "AUSENTE" ou "N/A"
            public string Status { get; set; }
        }
    }

}
