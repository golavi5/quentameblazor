using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Clientes
    {
        public Clientes()
        {
            Encabezados = new HashSet<Encabezados>();
            EncabezadosMov = new HashSet<EncabezadosMov>();
            Puntos = new HashSet<Puntos>();
        }

        public int IdCliente { get; set; }
        public int IdTipoDoc { get; set; }
        public string NumDoc { get; set; }
        public int? Dvcliente { get; set; }
        public int IdCiudad { get; set; }
        public int IdDpto { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public byte EsActivo { get; set; }
        public string Nota { get; set; }
        public int IdTipoRegimen { get; set; }
        public int IdAgrup1 { get; set; }
        public byte CupoCreditoTiene { get; set; }
        public int? CupoCreditoPlazo { get; set; }
        public decimal? CupoCreditoValor { get; set; }
        public int IdLista { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaUltModificacion { get; set; }

        public virtual ClientesAgrup1 ClientesAgrup1 { get; set; }
        public virtual Ciudades Ciudad { get; set; }
        public virtual InventariosListas Lista { get; set; }
        public virtual ClientesTiporeg TipoRegimen { get; set; }
        public virtual ClientesTipodoc TipoDoc { get; set; }
        public virtual Departamentos Dpto { get; set; }

        public string FullName()
        {
            return $"{Nombre1} {Nombre2} {Apellido1} {Apellido2}";
        }

        public string SearchClient()
        {
            return $"{NumDoc} {'-'} {Nombre1} {Nombre2} {Apellido1} {Apellido2}";
        }

        public virtual ICollection<Encabezados> Encabezados { get; set; }
        public virtual ICollection<EncabezadosMov> EncabezadosMov { get; set; }
        public virtual ICollection<Puntos> Puntos { get; set; }
    }
}
