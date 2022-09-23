using QuentameBlazor.Models.Entities;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;

namespace QuentameBlazor.Repositories.RepositoryExtensions
{
    public static class RepositoryExtensions
    {
        public static IQueryable<Inventarios> Search(this IQueryable<Inventarios> products, string searchQueryString)
        {
            if (string.IsNullOrWhiteSpace(searchQueryString))
                return products;

            //var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
            var searchParams = searchQueryString.Trim().Split(','); 
            var propertyInfos = typeof(Inventarios).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            
            var searchQueryBuilder = new StringBuilder();


            var searchType = searchParams[0];
            var searchText = searchParams[1];

            var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(searchType, StringComparison.InvariantCulture));

            searchQueryBuilder.Append($" {objectProperty.Name} {searchText}, ");

            var searchQuery = searchQueryBuilder.ToString().Trim(',',' ');

            /* foreach (var param in searchParams) 
            { 
                if (string.IsNullOrWhiteSpace(param)) 
                    continue; 
                        
                var propertyFromQueryName = param.Split(" ")[0];
                //var propertyFromQueryString = param.Split(" ")[1];
                var objectProperty = propertyInfos.Where(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));
                        
                if (objectProperty == null) 
                    continue; 
                        
                //var searchTerm = param.Equals(" desc") ? "descending" : "ascending"; 
                searchQueryBuilder.Append($"{objectProperty.Name} == {param}, "); 
            } 

            var searchQuery = searchQueryBuilder.ToString().TrimEnd(',', ' '); */
            
            if (string.IsNullOrWhiteSpace(searchQuery)) 
                return products; 
                    
            return products.Where(searchQuery);
        }
    }
}