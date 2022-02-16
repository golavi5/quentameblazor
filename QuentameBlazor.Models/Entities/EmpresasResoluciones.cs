using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class EmpresasResoluciones
    {
        public int IdResol { get; set; }
        public string Prefijo { get; set; }
        public int IdEmpresa { get; set; }
        public int NumResol { get; set; }
        public int NumInicial { get; set; }
        public int NumFinal { get; set; }
        public int NumAlerta { get; set; }
        public DateTime FechaResol { get; set; }
        public DateTime VenceResol { get; set; }
        public DateTime FechaAlerta { get; set; }
        public int NumActual { get; set; }
        public byte? EsActivo { get; set; }
        public string Concepto { get; set; }

        public virtual Empresas Empresas { get; set; }
    }
}
