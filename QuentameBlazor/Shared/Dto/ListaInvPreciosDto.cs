using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuentameBlazor.Dto
{
    public partial class ListaInvPreciosDto
    {
        public int IdInvP { get; set; }
        public int IdLista { get; set; }
        public int IdInventario { get; set; }
        public decimal Precio { get; set; }
        public int Porcentaje { get; set; }
        public string InventariosCodInventario { get; set; }
        public string InventariosCodigoBarras { get; set; }
        public string InventariosNomInventario { get; set; }
        public decimal InventariosCantFisica { get; set; }
        public decimal InventariosCostoPromedio { get; set; }
        public int InventariosIva { get; set; }
        public int InventariosIdAgrup1 { get; set; }
        public string InventariosInventariosAgrup1NomAgrup1 { get; set; }
        public int InventariosIdClasifImpto { get; set; }
        public string InventariosInventariosClasifimptoNomClasifImpto { get; set; }
        public int InventariosIdUnidad { get; set; }
        public string InventariosInventariosUnidadesNomUnidad { get; set; }
        public string InventariosObservacion { get; set; }
        public byte InventariosEsFactSinExistencia { get; set; }
        public byte? InventariosTipoVentaKit { get; set; }
        public byte InventariosEsFactorMov { get; set; }
        public string InventariosInventariosTiposNomTipoInven { get; set; }
        public int InventariosInventariosTiposIdInvenTipo { get; set; }

        public ObservableCollection<InventarioPreciosDto> ListaPrecios { get; set; }
    }
}
