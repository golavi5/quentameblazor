using QuentameBlazor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace QuentameBlazor.Repositories
{
    public interface IInvFormulaRepository : IRepositoryBase<InventariosFormulas>
    {
        IEnumerable<InventariosFormulas> GetAllInvFormulas();
        IEnumerable<InventariosFormulas> GetInvFormulasByIdInv(int idinv);
        InventariosFormulas GetInvFormulasById(int id);
        IEnumerable<InventariosFormulas> GetInvFormulasByCondition(Expression<Func<InventariosFormulas, bool>> expression);
        InventariosFormulas GetInvFormulaProd1ById(int idprod);
        InventariosFormulas GetInvFormulaProd2ById(int idprod);
        void UpdateInvFormula(InventariosFormulas inv);
    }
}
