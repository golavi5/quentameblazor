using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosAbc
    {
        public int AbcId { get; set; }
        public int Idinventario { get; set; }
        public decimal AbcCosto { get; set; }
        public decimal AbcRotacion { get; set; }
        public decimal AbcTotalcostoventa { get; set; }
        public decimal AbcParticipacion { get; set; }
        public decimal AbcAcumulado { get; set; }
        public string AbcClasificacion { get; set; }
        public DateTime AbcFechaini { get; set; }
        public DateTime AbcFechafin { get; set; }

        public virtual Inventarios Inventarios { get; set; }
    }
}
