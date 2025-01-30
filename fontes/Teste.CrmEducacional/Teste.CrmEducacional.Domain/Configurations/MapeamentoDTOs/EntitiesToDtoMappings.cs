using AutoMapper;
using Teste.CrmEducacional.Domain.Entities;
using Teste.CrmEducacional.DTO.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.CrmEducacional.Domain.Configurations.MapeamentoDTOs
{
    public class EntitiesToDtoMappings : Profile
    {
        public EntitiesToDtoMappings()
        {
            CreateMap<Candidato, CandidatoDTO>().ReverseMap();
            CreateMap<Curso, CursoDTO>().ReverseMap();
            CreateMap<ProcessoSeletivo, ProcessoSeletivoDTO>().ReverseMap();
            CreateMap<Inscricao, InscricaoDTO>().ReverseMap();

        }
    }
}
