using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Server.Dto
{
    public partial class ClientesDto
    {
        public int IdCliente { get; set; }
        public int IdTipoDoc { get; set; }
        public string NumDoc { get; set; }
        public int? Dvcliente { get; set; }
        public int IdCiudad { get; set; }
        public int IdDpto { get; set; }
        public int IdLista { get; set; }
        public int IdTipoRegimen { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public byte EsActivo { get; set; }
        public string Nota { get; set; }
        public bool CupoCreditoTiene { get; set; }
        public int? CupoCreditoPlazo { get; set; }
        public decimal? CupoCreditoValor { get; set; }
        public string FullName { get; set; }
        public string CiudadNomCiudad { get; set; }
        public string DptoNomDpto { get; set; }
        public string TipoRegimenNomTipoReg { get; set; }
        public string ClientesAgrup1NomAgrup1 { get; set; }
        public string ListaNomLista { get; set; }
        public string TipoDocNombreTipoDoc { get; set; }
    }
}
