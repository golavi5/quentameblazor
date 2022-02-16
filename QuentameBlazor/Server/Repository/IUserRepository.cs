using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuentameBlazor.Server.Repository
{
    public interface IUserRepository : IRepositoryBase<Usuarios>
    {
        Usuarios GetUsuarioById(int userid);
    }
}
