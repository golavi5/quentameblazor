using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            Clientes = new HashSet<Clientes>();
            Empresas = new HashSet<Empresas>();
        }

        public int IdCiudad { get; set; }
        public string NomCiudad { get; set; }
        public int? IdDpto { get; set; }
        public int? CodMunicipio { get; set; }
        public byte EsEspecial { get; set; }

        public virtual Departamentos Dep { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Empresas> Empresas { get; set; }
    }
}
