using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Server.Dto
{
    public partial class InventarioPreciosDto
    {
        public int IdLista { get; set; }
        public int IdInventario { get; set; }
        public decimal Precio { get; set; }
        public int Porcentaje { get; set; }
        public string InventariosListasNomLista { get; set; }
        public string InventariosNomInventario { get; set; }
        public decimal ValorUnit { get; set; }
    }
}
