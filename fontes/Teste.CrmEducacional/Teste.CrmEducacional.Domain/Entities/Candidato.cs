using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Domain.Entities
{
    public class Candidato
    {
        #region Atributos
        [Key]
        public long IdCandidato { get; set; }
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public ICollection<Inscricao> Inscricoes { get; set; } = new List<Inscricao>();
        #endregion

        #region Construtores
        public Candidato()
        {
            
        }

        public Candidato(string nome, string email, string telefone, string cpf)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
        }
        #endregion

        #region Metodos

        #endregion

    }
}
