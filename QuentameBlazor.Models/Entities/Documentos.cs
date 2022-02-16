using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Documentos
    {
        public Documentos()
        {
            Encabezados = new HashSet<Encabezados>();
        }

        public int IdDoc { get; set; }
        public string CodDoc { get; set; }
        public string NomDoc { get; set; }
        public byte? EsActivo { get; set; }
        public string Grupo { get; set; }

        public virtual ICollection<Encabezados> Encabezados { get; set; }
    }
}
