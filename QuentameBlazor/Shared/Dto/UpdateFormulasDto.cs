using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Dto
{
    public partial class UpdateFormulasDto
    {
        public int IdFormula { get; set; }
        public int IdInventario1 { get; set; }
        public int IdInventario2 { get; set; }
        public decimal? Factor { get; set; }
    }
}
