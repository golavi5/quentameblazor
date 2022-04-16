using AutoMapper;
using QuentameBlazor.Models.Entities;
using QuentameBlazor.Server.Dto;

namespace QuentameBlazor.Server.Mapping
{
    public class InventarioProfile : Profile
    {
        public InventarioProfile()
        {
            CreateMap<Inventarios, InventarioDto>();
        }
    }
}