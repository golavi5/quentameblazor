using System.Collections.Generic;
using System;

namespace QuentameBlazor.Dto
{
    public partial class CreateEncabDto
    {
        public int IdCliente { get; set; }
        public int IdDocumento { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? Vence { get; set; }
        public string Nota { get; set; }
        public int IdEmpresa { get; set; }
        public int IdFormaPago { get; set; }
        public decimal? ValorPago { get; set; }
        public int IdUsuario { get; set; }

        public List<CreateMovDto> EncabMovs {get; set; }
    }
        
}