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
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Cursos", "public");
            builder.HasKey(x => x.IdCurso);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Descricao).IsRequired();
            builder.Property(x => x.VagasDisponivel).IsRequired();
        }
    }
}
