using System;
using System.Collections.Generic;

namespace QuentameBlazor.Models.Entities
{
    public partial class UsuarioSystemConfig
    {
        public int ScId { get; set; }
        public int IdUsuario { get; set; }
        public byte? ScEsImprimir { get; set; }
        public byte? ScEsWindowsPrint { get; set; }
        public Int16? ScCantCopPrint { get; set; }
        public byte? ScEsCodInvPrefix { get; set; }
        public string ScCodInvPrefix { get; set; }
        public byte ScEsBascula { get; set; }
        public string ScPuertoBascula { get; set; }

        public virtual Usuarios Usuarios { get; set; }
        
    }
}
