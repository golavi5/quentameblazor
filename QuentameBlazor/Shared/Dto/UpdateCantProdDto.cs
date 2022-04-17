using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Dto
{
    public partial class UpdateCantProdDto
    {
        public int IdInventario { get; set; }
        public string CodInventario { get; set; }
        public string CodigoBarras { get; set; }
        public string NomInventario { get; set; }
        public byte EsActivo { get; set; }
        public decimal? CantMaxima { get; set; }
        public decimal? CantMinima { get; set; }
        public decimal? PuntoReorden { get; set; }
        public decimal? CantFisica { get; set; }
        public decimal? CostoPromedio { get; set; }
        public int IdUnidad { get; set; }
        public int Iva { get; set; }
        public int IdAgrup1 { get; set; }
        public string Observacion { get; set; }
        public int IdTipoInv { get; set; }
        public byte EsFactSinExistencia { get; set; }
        public byte? TipoVentaKit { get; set; }
        public byte EsFactorMov { get; set; }
        public int IdClasifImpto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaUltModificacion { get; set; }
        //public decimal? FactorEscala1 { get; set; }
        //public decimal? FactorEscala2 { get; set; }
    }
}
