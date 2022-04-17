using AutoMapper;
using QuentameBlazor.Models.Entities;
using QuentameBlazor.Dto;

namespace QuentameBlazor.Server.Mapping
{
    public class InventarioProfile : Profile
    {
        public InventarioProfile()
        {
            CreateMap<InventariosPrecios, ListaInvPreciosDto>();
        }
    }
}