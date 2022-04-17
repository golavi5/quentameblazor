using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Dto
{
    public partial class PreciosDto
    {
        public int IdInvP { get; set; }
        public int IdInventario { get; set; }
        public int IdLista { get; set; }
        public decimal Precio { get; set; }
        public int Porcentaje { get; set; }
        public string NomLista { get; set; }
        public string NomInventario { get; set; }

    }
}
