using Teste.CrmEducacional.Domain.Configurations.Mapeamento;
using Teste.CrmEducacional.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Domain.Configurations
{
    public class TesteCrmEducacionalDbContext : DbContext
    {

        public TesteCrmEducacionalDbContext(DbContextOptions<TesteCrmEducacionalDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<ProcessoSeletivo> ProcessoSeletivos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CandidatoMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new InscricaoMap());
            modelBuilder.ApplyConfiguration(new ProcessoSeletivoMap());
        }


    }
}
