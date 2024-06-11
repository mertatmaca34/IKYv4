using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUnvanManager
    {
        IDataResult<List<Unvan>> GetAll(Expression<Func<Unvan, bool>> filter = null);
        IResult Add(Unvan entity);
        IResult Delete(Unvan entity);
        IResult Update(Unvan entity);
    }
}