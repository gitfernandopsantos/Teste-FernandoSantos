using Teste.CrmEducacional.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.CrmEducacional.DTO.DTOS;

namespace Teste.CrmEducacional.Repository.Repository.Interfaces
{
    public interface ICandidatoRepository
    {
        Task<List<Candidato>> BuscarTodosCandidatos();
        Task <Candidato> BuscarCandidatoPeloId(long id);
        Task<Candidato> AdicionarCandidato(string nome, string email, string telefone, string cpf);
        Task<Candidato> AtualizarCandidato(long id, string nome, string email, string telefone, string cpf);
        Task<bool> DeletarCandidato(long id);
    }
}
