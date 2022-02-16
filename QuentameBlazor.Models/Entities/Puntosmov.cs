using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Puntosmov
    {
        public int MovId { get; set; }
        public int TarId { get; set; }
        public int IdEncabezado { get; set; }
        public DateTime MovFecha { get; set; }
        public string MovTipo { get; set; }
        public decimal MovValor { get; set; }
        public int MovPuntos { get; set; }
        public int MovPuntosTotal { get; set; }
        public int MovPuntosRedimido { get; set; }
        public string MovObservacion { get; set; }
        public int IdUsuario { get; set; }
        public byte MovEstado { get; set; }

        public virtual Encabezados Encabezados { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
