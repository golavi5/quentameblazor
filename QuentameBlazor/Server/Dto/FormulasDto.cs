using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Server.Dto
{
    public partial class FormulasDto
    {
        public int IdFormula { get; set; }
        public int IdInventario1 { get; set; }
        public int IdInventario2 { get; set; }
        public string Inventario1NomInventario { get; set; }
        public string Inventario2NomInventario { get; set; }
        public decimal? Factor { get; set; }
    }
}
