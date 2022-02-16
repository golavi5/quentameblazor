using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Empresas
    {
        public Empresas()
        {
            EmpresasResoluciones = new HashSet<EmpresasResoluciones>();
            Encabezados = new HashSet<Encabezados>();
        }

        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Nit { get; set; }
        public int? Dv { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int? IdCiudad { get; set; }
        public int? IdTipoRegimen { get; set; }
        public string PagWeb { get; set; }
        public string Email { get; set; }
        public int? IdDpto { get; set; }
        public byte EsActivo { get; set; }
        public string RepLegalNom1 { get; set; }
        public string RepLegalNom2 { get; set; }
        public string RepLegalApe1 { get; set; }
        public string RepLegalApe2 { get; set; }
        public string RepLegalDoc { get; set; }

        public virtual Ciudades Ciudad { get; set; }
        public virtual Departamentos Dep { get; set; }
        public virtual ClientesTiporeg TipoRegimen { get; set; }

        public virtual ICollection<EmpresasResoluciones> EmpresasResoluciones { get; set; }
        public virtual ICollection<Encabezados> Encabezados { get; set; }
    }
}
