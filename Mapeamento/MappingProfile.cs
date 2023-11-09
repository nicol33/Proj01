using AutoMapper;
using Proj01.DTOs;
using Proj01.Models;


namespace Proj01.Mapeamento
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<Todo, TodoDto>()
            .ForMember(dest => dest.Title, map => map.MapFrom(src => $"{src.Title} "))
            .ForMember(dest => dest.IsDeleted, src => src.MapFrom(src => src.Id > 0 ? true : false))
            .ReverseMap();

        
        }
    }
}
