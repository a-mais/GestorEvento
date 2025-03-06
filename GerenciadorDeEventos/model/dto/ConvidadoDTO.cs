using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEventos.model.dto
{
    public class ConvidadoDTO
    {
        public int IdConvidado { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public int NumConvite { get; set; }
        public string Status { get; set; } // Adicionado para armazenar o status do convidado

    }
}
