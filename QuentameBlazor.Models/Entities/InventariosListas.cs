using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosListas
    {
        public InventariosListas()
        {
            Clientes = new HashSet<Clientes>();
            InventariosPrecios = new HashSet<InventariosPrecios>();
        }

        public int IdLista { get; set; }
        public string NomLista { get; set; }
        public byte EsActivo { get; set; }
        public byte EsIvaIncluido { get; set; }
        public byte EsImptoConsumo { get; set; }
        public byte EsExtranjero { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<InventariosPrecios> InventariosPrecios { get; set; }
    }
}
