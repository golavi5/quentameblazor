using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Dto
{
    public partial class KardexDto
    {
        public decimal KardexCant { get; set; }
        public DateTime KardexFecha { get; set; }
        public string KardexMov { get; set; }
        public string KardexSaldo { get; set; }
        public string InventariosNomInventario { get; set; }
        public string EncabezadosNumDocumento { get; set; }

    }
}
