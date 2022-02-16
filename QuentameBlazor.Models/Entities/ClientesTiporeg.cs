using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class ClientesTiporeg
    {
        public ClientesTiporeg()
        {
            Clientes = new HashSet<Clientes>();
            Empresas = new HashSet<Empresas>();
        }

        public int IdTipoReg { get; set; }
        public string NomTipoReg { get; set; }
        public byte? EsActivo { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Empresas> Empresas { get; set; }
    }
}
