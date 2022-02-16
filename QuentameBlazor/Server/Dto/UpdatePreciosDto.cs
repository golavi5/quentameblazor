using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Server.Dto
{
    public partial class UpdatePreciosDto
    {
        public int IdInvP { get; set; }
        public int IdLista { get; set; }
        public int IdInventario { get; set; }
        public decimal Precio { get; set; }
        public int Porcentaje { get; set; }
        public string InventariosListasNomLista { get; set; }
        public string InventariosNomInventario { get; set; }
    }
}
