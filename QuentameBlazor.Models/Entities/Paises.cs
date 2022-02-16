using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Paises
    {
        public Paises()
        {
            Departamentos = new HashSet<Departamentos>();
        }

        public int IdPais { get; set; }
        public string CodPais { get; set; }
        public string NomPais1 { get; set; }
        public string NomPais2 { get; set; }
        public string NomPais2Imp { get; set; }
        public string Iso3 { get; set; }
        public short? CodigoInterno { get; set; }
        public string CodigoDian { get; set; }
        public virtual ICollection<Departamentos> Departamentos { get; set; }
    }
}
