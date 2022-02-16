using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosClasifimpto
    {
        public InventariosClasifimpto()
        {
            Inventarios = new HashSet<Inventarios>();
        }

        public int IdClasifImpto { get; set; }
        public string NomClasifImpto { get; set; }

        public virtual ICollection<Inventarios> Inventarios { get; set; }
    }
}
