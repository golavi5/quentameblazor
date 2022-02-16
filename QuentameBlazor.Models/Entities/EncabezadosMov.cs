using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class EncabezadosMov
    {
        public int IdEncabMov { get; set; }
        public int IdEncab { get; set; }
        public int IdInventario { get; set; }
        public decimal Cant { get; set; }
        public decimal? FactorCant { get; set; }
        public byte? FactorMov { get; set; }
        public int Iva { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal ValorSubTotal { get; set; }
        public decimal ValorIva { get; set; }
        public decimal ValorTotal { get; set; }
        public int IdCliente { get; set; }
        public string Nota { get; set; }
        public decimal? Dcto { get; set; }

        public virtual Clientes Clientes { get; set; }
        public virtual Encabezados Encabezados { get; set; }
        public virtual Inventarios Inventarios { get; set; }
    }
}
