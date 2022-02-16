using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class InventariosUnidades
    {
        public InventariosUnidades()
        {
            Inventarios = new HashSet<Inventarios>();
        }

        public int IdUnidad { get; set; }
        public string NomUnidad { get; set; }
        public string Abreviatura { get; set; }
        public byte EsEspecial { get; set; }
        public decimal FactorEscala { get; set; }
        public int? IdTipoUnidad { get; set; }
        public byte EsDinamica { get; set; }

        public virtual InventariosUnidadesTipos InventariosUnidadesTipos { get; set; }
        public virtual ICollection<Inventarios> Inventarios { get; set; }
    }
}
