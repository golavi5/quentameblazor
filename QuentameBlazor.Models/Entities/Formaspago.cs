using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Formaspago
    {
        public Formaspago()
        {
            ArqueoCajas = new HashSet<ArqueoCajas>();
            Encabezados = new HashSet<Encabezados>();
            EncabezadosPagodet = new HashSet<EncabezadosPagodet>();
        }

        public int IdFormaPago { get; set; }
        public string NomFormaPago { get; set; }
        public byte EsActivo { get; set; }

        public virtual ICollection<ArqueoCajas> ArqueoCajas { get; set; }
        public virtual ICollection<Encabezados> Encabezados { get; set; }
        public virtual ICollection<EncabezadosPagodet> EncabezadosPagodet { get; set; }
    }
}
