using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            ArqueoCajas = new HashSet<ArqueoCajas>();
            Encabezados = new HashSet<Encabezados>();
            Puntosmov = new HashSet<Puntosmov>();
            UsuarioSystemConfigs = new HashSet<UsuarioSystemConfig>();
        }

        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Clave { get; set; }
        public byte EsActivo { get; set; }
        public string CorreoElectronico { get; set; }
        public int IdUsuarioTipo { get; set; }

        public virtual Usuariostipo UsuariosTipo { get; set; }
        public virtual ICollection<ArqueoCajas> ArqueoCajas { get; set; }
        public virtual ICollection<Encabezados> Encabezados { get; set; }
        public virtual ICollection<Puntosmov> Puntosmov { get; set; }
        public virtual ICollection<UsuarioSystemConfig> UsuarioSystemConfigs { get; set; }
    }
}
