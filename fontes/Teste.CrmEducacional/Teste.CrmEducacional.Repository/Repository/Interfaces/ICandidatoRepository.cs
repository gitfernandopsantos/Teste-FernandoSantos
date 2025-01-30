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
        Task<Candidato> AdicionarCandidato(Candidato candidato);
        Task<Candidato> AtualizarCandidato(Candidato newUser, long id);
        Task<bool> DeletarCandidato(long id);
    }
}
