using System.Linq;
using QuentameBlazor.Models.Entities;

namespace QuentameBlazor.Repositories.RepositoryExtensions
{
    public static class RepositoryInvPreciosExtensions
    {
        public static IQueryable<InventariosPrecios> Search(this IQueryable<InventariosPrecios> invprices, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return invprices;

            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

            return invprices.Where(i => i.Inventarios.NomInventario.ToLower().Contains(lowerCaseSearchTerm));
        }
    }
}