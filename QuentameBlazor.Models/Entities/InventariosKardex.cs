using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosKardex
    {
        public int KardexId { get; set; }
        public int IdInventario { get; set; }
        public int IdEncab { get; set; }
        public decimal KardexCant { get; set; }
        public DateTime KardexFecha { get; set; }
        public string KardexMov { get; set; }
        public decimal KardexSaldo { get; set; }

        public virtual Encabezados Encabezados { get; set; }
        public virtual Inventarios Inventarios { get; set; }
    }
}
