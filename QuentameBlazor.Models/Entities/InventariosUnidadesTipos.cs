using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosUnidadesTipos
    {
        public InventariosUnidadesTipos()
        {
            InventariosUnidades = new HashSet<InventariosUnidades>();
        }

        public int IdTipoUnidad { get; set; }
        public string NomTipoUnidad { get; set; }

        public virtual ICollection<InventariosUnidades> InventariosUnidades { get; set; }
    }
}
