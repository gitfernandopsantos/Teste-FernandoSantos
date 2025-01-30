using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Domain.Entities
{
    public class Curso
    {
        #region Atributos
        [Key]
        public long IdCurso { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public long VagasDisponivel { get; set; }
        public ICollection<Inscricao> Inscricoes { get; set; } = new List<Inscricao>();
        #endregion

        #region Construtores
        public Curso() { }

        public Curso(string nome, string descricao, long vagasDisponivel)
        {
            Nome = nome;
            Descricao = descricao;
            VagasDisponivel = vagasDisponivel;
        }
        #endregion

        #region Metodos

        #endregion

    }
}
