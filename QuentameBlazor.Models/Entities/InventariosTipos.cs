using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosTipos
    {
        public InventariosTipos()
        {
            Inventarios = new HashSet<Inventarios>();
        }

        public int IdInvenTipo { get; set; }
        public string NomTipoInven { get; set; }
        public byte EsActivo { get; set; }

        public virtual ICollection<Inventarios> Inventarios { get; set; }
    }
}
