using Teste.CrmEducacional.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Domain.Configurations.Mapeamento
{
    public class CandidatoMap : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.ToTable("Candidatos", "public");
            builder.HasKey(x => x.IdCandidato);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.CPF).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Telefone).IsRequired();
        }
    }
}
