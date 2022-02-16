using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Departamentos
    {
        public Departamentos()
        {
            Ciudades = new HashSet<Ciudades>();
            Clientes = new HashSet<Clientes>();
            Empresas = new HashSet<Empresas>();
        }

        public int IdDpto { get; set; }
        public string NomDpto { get; set; }
        public int? IdPais { get; set; }
        public byte EsEspecial { get; set; }

        public virtual Paises Pais { get; set; }
        public virtual ICollection<Ciudades> Ciudades { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Empresas> Empresas { get; set; }
    }
}
