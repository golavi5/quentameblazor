using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace QuentameBlazor.Server.Repository
{
    public class EncabezadoMovRepository : RepositoryBase<EncabezadosMov>, IEncabezadoMovRepository
    {
        public EncabezadoMovRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<EncabezadosMov> GetAllMov()
        {
            return FindAll()
                .OrderBy(e => e.IdEncabMov)
                .ToList();
        }

        public IEnumerable<EncabezadosMov> GetMovsByIdEncab(int idencab)
        {
            return FindByCondition(e => e.IdEncab.Equals(idencab))
                .Include(e => e.Inventarios)
                .Include(e => e.Encabezados)
                .Include(e => e.Clientes)
                .ToList();
        }

        public void CreateEncabezadoMov(EncabezadosMov encabezadomov)
        {
            Create(encabezadomov);
        }
        public void CreateRangeEncabezadosMov(List<EncabezadosMov> encabezadosmov)
        {
            CreateRange(encabezadosmov);
        }
        public void UpdateEncabezadoMov(EncabezadosMov encabezadomov)
        {
            Update(encabezadomov);
        }
        public void DeleteEncabezadoMov(EncabezadosMov encabezadomov)
        {
            Delete(encabezadomov);
        }

    }
}
