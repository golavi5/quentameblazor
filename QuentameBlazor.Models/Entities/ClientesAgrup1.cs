using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class ClientesAgrup1
    {
        public ClientesAgrup1()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int IdAgrup1 { get; set; }
        public string NomAgrup1 { get; set; }
        public byte EsActivo { get; set; }
        public string Nota { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
