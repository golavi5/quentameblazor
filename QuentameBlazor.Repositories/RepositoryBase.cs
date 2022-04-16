using QuentameBlazor.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuentameBlazor.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AppDbContext AppDbContext { get; set; }

        public RepositoryBase(AppDbContext appdbcontext)
        {
            this.AppDbContext = appdbcontext;
        }

        public IEnumerable<T> FindAll()
        {
            return AppDbContext.Set<T>().AsNoTracking();
        }


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return AppDbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public int FindMaxCod(Expression<Func<T,int >> expression)
        {
            return AppDbContext.Set<T>().Max(expression);
        }

        public void Create(T entity)
        {
            AppDbContext.Set<T>().Add(entity);
        }

        public void CreateRange(List<T> entity)
        {
            AppDbContext.Set<T>().AddRange(entity);
        }

        public void Update(T entity)
        {
            AppDbContext.Set<T>().Update(entity);
        }

        public void UpdateRange(List<T> entity)
        {
            AppDbContext.Set<T>().UpdateRange(entity);
        }

        public void Delete(T entity)
        {
            AppDbContext.Set<T>().Remove(entity);
        }
    }
}