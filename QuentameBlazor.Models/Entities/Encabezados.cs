using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Encabezados
    {
        public Encabezados()
        {
            ArqueoCajas = new HashSet<ArqueoCajas>();
            EncabezadosCostos = new HashSet<EncabezadosCostos>();
            EncabezadosMov = new HashSet<EncabezadosMov>();
            EncabezadosPagodet = new HashSet<EncabezadosPagodet>();
            Puntosmov = new HashSet<Puntosmov>();
            InventariosKardex = new HashSet<InventariosKardex>();
        }

        public int IdEncab { get; set; }
        public int IdEmpresa { get; set; }
        public int IdDocumento { get; set; }
        public int NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? Vence { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public string Nota { get; set; }
        public int IdFormaPago { get; set; }
        public byte EsAnulado { get; set; }
        public decimal? ValorPago { get; set; }

        public virtual Clientes Clientes { get; set; }
        public virtual Documentos Documentos { get; set; }
        public virtual Formaspago Formaspago { get; set; }
        public virtual Empresas Empresas { get; set; }
        public virtual Usuarios Usuarios { get; set; }

        public virtual ICollection<ArqueoCajas> ArqueoCajas { get; set; }
        public virtual ICollection<EncabezadosCostos> EncabezadosCostos { get; set; }
        public virtual ICollection<EncabezadosMov> EncabezadosMov { get; set; }
        public virtual ICollection<EncabezadosPagodet> EncabezadosPagodet { get; set; }
        public virtual ICollection<Puntosmov> Puntosmov { get; set; }
        public virtual ICollection<InventariosKardex> InventariosKardex { get; set; }
    }
}
