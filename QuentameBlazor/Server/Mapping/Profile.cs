using AutoMapper;
using QuentameBlazor.Models.Entities;
using QuentameBlazor.Dto;

namespace QuentameBlazor.Server.Mapping
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            CreateMap<InventariosPrecios, ListaInvPreciosDto>();
            CreateMap<InventariosAgrup1, InvAgrupDto>();
            CreateMap<Clientes, ClientesDto>();
        }
    }
}