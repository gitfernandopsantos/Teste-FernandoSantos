using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Domain.Entities
{
    public class Inscricao
    {
        public long IdInscricao { get; set; }
        public string NumeroInscricao { get; set; }
        public string Data { get; set; }
        public string Status { get; set; }
        public long CandidatoId { get; set; }
        public long ProcessoSeletivoId { get; set; }
        public long CursoId { get; set; }


    }
}
