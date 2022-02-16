using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class EncabezadosPagodet
    {
        public int IdPago { get; set; }
        public int IdEncab { get; set; }
        public string NumDoc { get; set; }
        public decimal? ValorPago { get; set; }
        public DateTime? FechaPago { get; set; }
        public int IdFormaPago { get; set; }
        public decimal ValorIva { get; set; }
        public byte? FactorSuma { get; set; }

        public virtual Encabezados Encabezados { get; set; }
        public virtual Formaspago FormasPago { get; set; }
    }
}
