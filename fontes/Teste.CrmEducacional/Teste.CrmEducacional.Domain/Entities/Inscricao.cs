using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Domain.Entities
{
    public class Inscricao
    {
        #region Atributos
        [Key]
        public long IdInscricao { get; set; }

        public string NumeroInscricao { get; set; }

        public string Data { get; set; }

        public string Status { get; set; }

        [ForeignKey("CandidatoId")]
        public Candidato Candidato { get; set; }
        public long CandidatoId { get; set; }

        [ForeignKey("ProcessoSeletivoId")]
        public ProcessoSeletivo ProcessoSeletivo { get; set; }
        public long ProcessoSeletivoId { get; set; }

        [ForeignKey("CursoId")]
        public Curso Curso { get; set; }
        public long CursoId { get; set; }
        #endregion

        #region Construtores
        public Inscricao() { }

        public Inscricao(string numeroInscricao, string data, string status, long candidatoId, long processoSeletivoId, long cursoId)
        {
            NumeroInscricao = numeroInscricao;
            Data = data;
            Status = status;
            CandidatoId = candidatoId;
            ProcessoSeletivoId = processoSeletivoId;
            CursoId = cursoId;
        }
        #endregion
        #region Metodos

        #endregion

    }
}
