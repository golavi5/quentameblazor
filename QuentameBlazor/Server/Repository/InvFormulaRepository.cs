using QuentameBlazor.Models.Entities;
using QuentameBlazor.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QuentameBlazor.Server.Parameters;

namespace QuentameBlazor.Server.Repository
{
    public class InvFormulaRepository : RepositoryBase<InventariosFormulas>, IInvFormulaRepository
    {
        public InvFormulaRepository(AppDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<InventariosFormulas> GetAllInvFormulas()
        {
            return FindAll()
                .OrderBy(i => i.IdFormula)
                .ToList();
        }

        public InventariosFormulas GetInvFormulasById(int id)
        {
            return FindByCondition(i => i.IdFormula.Equals(id))
                .OrderBy(i => i.IdFormula)
                .FirstOrDefault();
        }

        public IEnumerable<InventariosFormulas> GetInvFormulasByIdInv(int idinv)
        {
            return FindByCondition(f => f.IdInventario1.Equals(idinv))
                .Include(i => i.Inventario1)
                .Include(i => i.Inventario2)
                .OrderBy(i => i.IdFormula)
                .ToList();
        }

        public IEnumerable<InventariosFormulas> GetInvFormulasByCondition(Expression<Func<InventariosFormulas, bool>> expression)
        {
            return FindByCondition(expression)
                .Include(i => i.Inventario1)
                .Include(i => i.Inventario2)
                .OrderBy(i => i.IdFormula)
                .ToList();
        }

        public InventariosFormulas GetInvFormulaProd1ById(int idprod)
        {
            return FindByCondition(i => i.IdInventario1.Equals(idprod))
                .FirstOrDefault();
        }

        public InventariosFormulas GetInvFormulaProd2ById(int idprod)
        {
            return FindByCondition(i => i.IdInventario2.Equals(idprod))
                .FirstOrDefault();
        }

        public void UpdateInvFormula(InventariosFormulas invformula)
        {
            Update(invformula);
        }
    }
}
