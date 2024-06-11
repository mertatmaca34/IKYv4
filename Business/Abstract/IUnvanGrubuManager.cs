using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUnvanGrubuManager
    {
        IDataResult<List<UnvanGrubu>> GetAll(Expression<Func<UnvanGrubu, bool>> filter = null);
        IResult Add(UnvanGrubu entity);
        IResult Delete(UnvanGrubu entity);
        IResult Update(UnvanGrubu entity);
    }
}