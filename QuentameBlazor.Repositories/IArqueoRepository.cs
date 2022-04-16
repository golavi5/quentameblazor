using QuentameBlazor.Models.Entities;
using System.Collections.Generic;

namespace QuentameBlazor.Repositories
{
    public interface IArqueoRepository : IRepositoryBase<ArqueoCajas>
    {
        void CreateArqueo(ArqueoCajas arqueocaja);
    }
}
