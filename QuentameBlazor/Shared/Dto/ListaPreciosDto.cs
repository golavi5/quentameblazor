using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Dto
{
    public partial class ListaPreciosDto
    {

        public int IdInvP { get; set; }
        public int IdInventario { get; set; }
        public string NombreProd { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio1 { get; set; }
        public int Porcentaje1 { get; set; }
        public decimal Precio2 { get; set; }
        public int Porcentaje2 { get; set; }
        public decimal Precio3 { get; set; }
        public int Porcentaje3 { get; set; }
        public decimal Precio4 { get; set; }
        public int Porcentaje4 { get; set; }
    }
}
