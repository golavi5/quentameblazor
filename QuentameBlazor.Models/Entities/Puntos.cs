using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Puntos
    {
        public int TarId { get; set; }
        public int IdCliente { get; set; }
        public DateTime TarFecha { get; set; }
        public string TarCodigo { get; set; }
        public string TarCliente { get; set; }
        public int TarPuntosTotal { get; set; }
        public int TarPuntosRedimido { get; set; }
        public decimal TarValorCompra { get; set; }
        public int TarPuntosXCompra { get; set; }
        public int TarPuntosMultiplicar { get; set; }
        public string TarObservacion { get; set; }
        public byte TarEstado { get; set; }

        public virtual Clientes Clientes { get; set; }
    }
}
