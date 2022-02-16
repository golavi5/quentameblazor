using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Server.Repository
{
    public interface IArqueoRepository : IRepositoryBase<ArqueoCajas>
    {
        void CreateArqueo(ArqueoCajas arqueocaja);
    }
}
