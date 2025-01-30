using Teste.CrmEducacional.Domain.Configurations;
using Teste.CrmEducacional.Domain.Entities;
using Teste.CrmEducacional.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Repository.Repository
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly TesteCrmEducacionalDbContext _dbContext;
        public CandidatoRepository(TesteCrmEducacionalDbContext testeCrmEducacionalDbContext)
        {
            _dbContext = testeCrmEducacionalDbContext;
        }
        public async Task<Candidato> AdicionarCandidato(Candidato candidato)
        {
            try
            {
                await _dbContext.Candidatos.AddAsync(candidato);
                await _dbContext.SaveChangesAsync();
                return candidato;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> DeletarCandidato(long id)
        {
            try
            {
                Candidato candidato = await BuscarCandidatoPeloId(id);
                if (candidato == null)
                {
                    throw new Exception($"O ID {id} deste candidato não foi encontrado no banco de dados.");
                }
                else
                {
                    _dbContext.Candidatos.Remove(candidato);
                    _dbContext.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Candidato>> BuscarTodosCandidatos()
        {
            try
            {
                var query = await _dbContext.Candidatos.ToListAsync();
                if (query != null)
                {
                    return query;
                }
                throw new Exception("Nenhum usuário encontrado no banco de dados.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Candidato> BuscarCandidatoPeloId(long id)
        {
            try
            {
                var candidato = await _dbContext.Candidatos.FirstOrDefaultAsync(x => x.IdCandidato == id);
                if (candidato != null)
                {
                    return candidato;
                }
                throw new Exception("Não foi possível localizar esse usuário. Por favor, tente novamente com outro ID");

            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Candidato> AtualizarCandidato(Candidato novoCandidato, long id)
        {
            try
            {
                Candidato candidato = await BuscarCandidatoPeloId(id);
                if (candidato == null)
                {
                    throw new Exception($"O ID {id} deste usuário não foi encontrado no banco de dados.");
                }
                else
                {
                    candidato.Email = novoCandidato.Email;
                    candidato.Nome = novoCandidato.Nome;
                    candidato.CPF = novoCandidato.CPF;
                    candidato.Telefone = novoCandidato.Telefone;

                    _dbContext.Candidatos.Update(candidato);
                    _dbContext.SaveChanges();
                    return candidato;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }
        }
    }
}
