using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.DTO.DTOS
{
    public class CandidatoDTO
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataUsuarioLogado { get; set; }
    }
}
