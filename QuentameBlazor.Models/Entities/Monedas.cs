using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Monedas
    {
        public int MonedaId { get; set; }
        public string MonedaNombre { get; set; }
        public byte MonedaActivo { get; set; }
    }
}
