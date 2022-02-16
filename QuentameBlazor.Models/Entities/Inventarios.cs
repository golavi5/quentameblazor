using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Inventarios
    {
        public Inventarios()
        {
            EncabezadosCostos = new HashSet<EncabezadosCostos>();
            EncabezadosMov = new HashSet<EncabezadosMov>();
            InventariosPrecios = new HashSet<InventariosPrecios>();
            InventariosAbc = new HashSet<InventariosAbc>();
            InventariosKardex = new HashSet<InventariosKardex>();
            Inventario1 = new HashSet<InventariosFormulas>();
            Inventario2 = new HashSet<InventariosFormulas>();
        }

        public int IdInventario { get; set; }
        public string CodInventario { get; set; }
        public string CodigoBarras { get; set; }
        public string NomInventario { get; set; }
        public byte EsActivo { get; set; }
        public decimal? CantMaxima { get; set; }
        public decimal? CantMinima { get; set; }
        public decimal? PuntoReorden { get; set; }
        public decimal CantFisica { get; set; }
        public decimal CostoPromedio { get; set; }
        public int IdUnidad { get; set; }
        public int Iva { get; set; }
        public int IdAgrup1 { get; set; }
        public string Observacion { get; set; }
        public int IdTipoInv { get; set; }
        public byte EsFactSinExistencia { get; set; }
        public byte TipoVentaKit { get; set; }
        public byte EsFactorMov { get; set; }
        public int IdClasifImpto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaUltModificacion { get; set; }
        public decimal? FactorEscala1 { get; set; }
        public decimal? FactorEscala2 { get; set; }

        public virtual InventariosAgrup1 InventariosAgrup1 { get; set; }
        public virtual InventariosClasifimpto InventariosClasifimpto { get; set; }
        public virtual InventariosTipos InventariosTipos { get; set; }
        public virtual InventariosUnidades InventariosUnidades { get; set; }

        public virtual ICollection<EncabezadosCostos> EncabezadosCostos { get; set; }
        public virtual ICollection<EncabezadosMov> EncabezadosMov { get; set; }
        public virtual ICollection<InventariosPrecios> InventariosPrecios { get; set; }
        public virtual ICollection<InventariosAbc> InventariosAbc { get; set; }
        public virtual ICollection<InventariosKardex> InventariosKardex { get; set; }
        public virtual ICollection<InventariosFormulas> Inventario1 { get; set; }
        public virtual ICollection<InventariosFormulas> Inventario2 { get; set; }

        public string SearchProduct()
        {
            return $"{NomInventario} {'-'} {CantFisica}";
        }
    }
}
