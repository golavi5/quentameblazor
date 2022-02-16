using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class ClientesTipodoc
    {
        public ClientesTipodoc()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int IdTipoDoc { get; set; }
        public int TipoDoc { get; set; }
        public string NombreTipoDoc { get; set; }
        public string DescripTipoDoc { get; set; }
        public byte EsActivo { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
