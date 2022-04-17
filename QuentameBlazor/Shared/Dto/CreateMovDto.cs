using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Dto
{
    public partial class CreateMovDto
    {
        public int IdInventario { get; set; }
        public decimal Cant { get; set; }
        public int Iva { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal ValorSubtotal { get; set; }
        public decimal ValorIva { get; set; }
        public decimal ValorTotal { get; set; }
        public string Nota { get; set; }
    }
}
