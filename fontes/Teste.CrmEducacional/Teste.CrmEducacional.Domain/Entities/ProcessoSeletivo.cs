using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Domain.Entities
{
    public class ProcessoSeletivo
    {
        #region Atributos
        [Key]
        public long IdProcessoSeletivo { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ICollection<Inscricao> Inscricoes { get; set; } = new List<Inscricao>();
        #endregion
        #region Construtores
        public ProcessoSeletivo() { }

        public ProcessoSeletivo(string nome, DateTime dataInicio, DateTime dataFim)
        {
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
        #endregion

        #region Metodos

        #endregion
    }
}
