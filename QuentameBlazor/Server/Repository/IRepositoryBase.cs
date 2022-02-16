using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuentameBlazor.Server.Repository
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();

        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        
        int FindMaxCod(Expression<Func<T, int>> expression);

        void Create(T entity);

        void CreateRange(List<T> entity);

        void Update(T entity);

        void UpdateRange(List<T> entity);

        void Delete(T entity);
    }
}
