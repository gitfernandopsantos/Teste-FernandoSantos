using Teste.CrmEducacional.Domain.Configurations;
using Teste.CrmEducacional.Domain.Entities;
using Teste.CrmEducacional.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<Candidato> AdicionarCandidato(string nome, string email, string telefone, string cpf)
        {
            try
            {
                var candidato = new Candidato(nome, email, telefone, cpf);
                await _dbContext.Candidatos.AddAsync(candidato);
                await _dbContext.SaveChangesAsync();
                return candidato;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar candidato.", ex);
            }
        }

        public async Task<bool> DeletarCandidato(long id)
        {
            try
            {
                Candidato candidato = await BuscarCandidatoPeloId(id);
                _dbContext.Candidatos.Remove(candidato);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (KeyNotFoundException ex)
            {
                throw new KeyNotFoundException($"Candidato com ID {id} não encontrado.", ex);
            }
        }

        public async Task<List<Candidato>> BuscarTodosCandidatos()
        {
            try
            {
                var candidatos = await _dbContext.Candidatos.ToListAsync();
                if (candidatos.Any())
                {
                    return candidatos;
                }
                throw new KeyNotFoundException("Nenhum candidato encontrado.");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar candidatos.", ex);
            }
        }

        public async Task<Candidato> BuscarCandidatoPeloId(long id)
        {
            var candidato = await _dbContext.Candidatos.FirstOrDefaultAsync(x => x.IdCandidato == id);
            if (candidato == null)
            {
                throw new KeyNotFoundException("Candidato não encontrado.");
            }
            return candidato;
        }

        public async Task<Candidato> AtualizarCandidato(long id, string nome, string email, string telefone, string cpf)
        {
            try
            {
                Candidato candidato = await BuscarCandidatoPeloId(id);

                candidato.Nome = nome;
                candidato.Email = email;
                candidato.Telefone = telefone;
                candidato.CPF = cpf;

                _dbContext.Candidatos.Update(candidato);
                await _dbContext.SaveChangesAsync();
                return candidato;
            }
            catch (KeyNotFoundException ex)
            {
                throw new KeyNotFoundException($"Candidato com ID {id} não encontrado.", ex);
            }
        }
    }
}
