using AutoMapper;
using Tarefa.Application.Dtos;
using Tarefa.Domain.Entidades;

namespace Tarefa.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entidades.Tarefa, TarefaDto>().ReverseMap();
            CreateMap<Projeto, ProjetoDto>().ReverseMap();
        }
    }
}
