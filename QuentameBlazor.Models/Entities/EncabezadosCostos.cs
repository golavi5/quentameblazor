using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class EncabezadosCostos
    {
        public int IdEncabCosto { get; set; }
        public int IdEncab { get; set; }
        public int? IdInventario { get; set; }
        public decimal? Costo { get; set; }
        public DateTime? EncabFecha { get; set; }
        public byte? EsActivo { get; set; }

        public virtual Encabezados Encabezados { get; set; }
        public virtual Inventarios Inventarios { get; set; }
    }
}
