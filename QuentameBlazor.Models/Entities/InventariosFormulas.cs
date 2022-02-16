using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosFormulas
    {

        public int IdFormula { get; set; }
        public int IdInventario1 { get; set; }
        public int IdInventario2 { get; set; }
        public decimal? Factor { get; set; }
        public decimal? SaldoProd { get; set; }

        public virtual Inventarios Inventario1 { get; set; }
        public virtual Inventarios Inventario2 { get; set; }

    }
}
