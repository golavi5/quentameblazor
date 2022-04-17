using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuentameBlazor.Dto
{
    public partial class PrintMovsDto
    {
        
        [Column("Descripción")]
        public string InventariosNomInventario { get; set; }
        [Column("VUnit")]
        public decimal Cant { get; set; }
        public decimal ValorUnit { get; set; }
        [Column("VSubtotal")]
        public decimal ValorSubTotal { get; set; }
        [Column("VIva")]
        public decimal ValorIva { get; set; }
        [Column("VTotal")]
        public decimal ValorTotal { get; set; }
        
    }
}
