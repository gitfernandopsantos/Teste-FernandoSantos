using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.DTO.DTOS
{
    public class CursoDTO
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public long VagasDisponivel { get; set; }
    }
}
