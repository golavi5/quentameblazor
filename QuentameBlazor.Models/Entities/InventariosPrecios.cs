using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosPrecios
    {

        public int IdInvP { get; set; }
        public int IdLista { get; set; }
        public int IdInventario { get; set; }
        public decimal Precio { get; set; }
        public int Porcentaje { get; set; }

        public virtual Inventarios Inventarios { get; set; }
        public virtual InventariosListas InventariosListas { get; set; }
    }
}
