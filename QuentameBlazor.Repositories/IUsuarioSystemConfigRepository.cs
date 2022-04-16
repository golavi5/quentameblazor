using System;
using System.Collections.Generic;
using System.Text;
using QuentameBlazor.Models.Entities;

namespace QuentameBlazor.Repositories
{
    public interface IUsuarioSystemConfigRepository : IRepositoryBase<UsuarioSystemConfig>
    {
        UsuarioSystemConfig GetUsuarioSystemConfigByIdUsuario(int idusuario);
    }
}
