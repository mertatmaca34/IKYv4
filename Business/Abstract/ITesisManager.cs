using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ITesisManager
    {
        IDataResult<List<Tesis>> GetAll(Expression<Func<Tesis, bool>> filter = null);
        IResult Add(Tesis entity);
        IResult Delete(Tesis entity);
        IResult Update(Tesis entity);
    }
}