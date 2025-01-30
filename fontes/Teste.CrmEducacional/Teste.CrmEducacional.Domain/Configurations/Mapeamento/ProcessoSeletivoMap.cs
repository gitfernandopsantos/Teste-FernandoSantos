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
    public class ProcessoSeletivoMap : IEntityTypeConfiguration<ProcessoSeletivo>
    {
        public void Configure(EntityTypeBuilder<ProcessoSeletivo> builder)
        {
            builder.ToTable("ProcessoSeletivo", "public");
            builder.HasKey(x => x.IdProcessoSeletivo);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.DataInicio).IsRequired();
            builder.Property(x => x.DataFim).IsRequired();
        }
    }
}
