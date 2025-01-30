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
    public class InscricaoMap : IEntityTypeConfiguration<Inscricao>
    {
        public void Configure(EntityTypeBuilder<Inscricao> builder)
        {
            builder.ToTable("Inscricoes", "public");
            builder.HasKey(x => x.IdInscricao);
            builder.Property(x => x.NumeroInscricao).IsRequired();
            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CandidatoId).IsRequired();
            builder.Property(x => x.ProcessoSeletivoId).IsRequired();
            builder.Property(x => x.CursoId).IsRequired();
        }
    }
}
