using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class Usuariostipo
    {
        public Usuariostipo()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdUsuarioTipo { get; set; }
        public string NomUsuarioTipo { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
