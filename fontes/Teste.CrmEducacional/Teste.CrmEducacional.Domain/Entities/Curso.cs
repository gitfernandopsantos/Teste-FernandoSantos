using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Domain.Entities
{
    public class Curso
    {
        public long IdCurso { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string VagasDisponivel { get; set; }

    }
}
