using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class ArqueoCajas
    {
        public int ArqId { get; set; }
        public int IdUsuario { get; set; }
        public int IdEncab { get; set; }
        public DateTime ArqFecha { get; set; }
        public byte ArqEsBase { get; set; }
        public byte ArqEsCerrado { get; set; }
        public int IdFormaPago { get; set; }
        public decimal ArqValor { get; set; }
        public byte ArqEsProcesado { get; set; }

        public virtual Encabezados Encabezados { get; set; }
        public virtual Formaspago Formaspago { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
