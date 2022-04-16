using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuentameBlazor.Repositories
{
    public interface IUserRepository : IRepositoryBase<Usuarios>
    {
        Usuarios GetUsuarioById(int userid);
    }
}
