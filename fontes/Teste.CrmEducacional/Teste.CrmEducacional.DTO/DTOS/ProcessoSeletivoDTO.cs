using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.DTO.DTOS
{
    public class InscricaoDTO
    {
        public long NumeroIncricao { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public long CandidatoId { get; set; }
        public long ProcessoSeletivoId { get; set; }
        public long CursoId { get; set; }
    }
}
