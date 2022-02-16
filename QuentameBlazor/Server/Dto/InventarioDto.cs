using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using QuentameBlazor.Models.Entities;
using QuentameBlazor.Server.Repository;

namespace QuentameBlazor.Server.Dto
{
    public partial class InventarioDto : NotifyBase
    {
        public int IdInventario { get; set; }
        [Required(ErrorMessage = "El Código de producto es obligatorio")]
        public string CodInventario { get; set; }
        [StringLength(13)]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese sólo números")]
        public string CodigoBarras { get; set; }
        [Required(ErrorMessage = "El nombre del producto es requerido")]
        public string NomInventario { get; set; }
        public byte EsActivo { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Ingrese sólo números")]
        public decimal? CantMaxima { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Ingrese sólo números")]
        public decimal? CantMinima { get; set; }
        public decimal? PuntoReorden { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Ingrese sólo números")]
        public decimal? CantFisica { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Ingrese sólo números")]
        public decimal? CostoPromedio { get; set; }
        [Required(ErrorMessage ="Iva es Requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese números enteros")]
        public int Iva { get; set; }
        public string Observacion { get; set; }
        public byte EsFactSinExistencia { get; set; }
        public byte? TipoVentaKit { get; set; }
        public byte EsFactorMov { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaUltModificacion { get; set; }
        public decimal? FactorEscala1 { get; set; }
        public decimal? FactorEscala2 { get; set; }
        public int IdUnidad { get; set; }
        public string InventariosUnidadesNomUnidad { get; set; }
        public int IdAgrup1 { get; set; }
        public string InventariosAgrup1NomAgrup1 { get; set; }
        public int IdTipoInv { get; set; }
        public string InventariosTiposNomTipoInven { get; set; }
        public int IdClasifImpto { get; set; }
        public string InventariosClasifimptoNomClasifImpto { get; set; }
        public ObservableCollection<InventarioPreciosDto> ListaPrecios { get; set; }
    }
}
