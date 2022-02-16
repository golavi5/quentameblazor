using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosAgrup1
    {
        public InventariosAgrup1()
        {
            Inventarios = new HashSet<Inventarios>();
        }

        public int IdAgrup1 { get; set; }
        public string CodigoAgrup1 { get; set; }
        public string NomAgrup1 { get; set; }
        public byte EsActivo { get; set; }
        public string Nota { get; set; }

        public virtual ICollection<Inventarios> Inventarios { get; set; }
    }
}
