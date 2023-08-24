using ApiIncidencias.Dtos;
using AutoMapper;
using Dominio;

namespace ApiIncidencias.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles(){
        CreateMap<Pais,PaisDto>().ReverseMap();
        CreateMap<Departamento,DepartamentoDto>().ReverseMap();
    }
}