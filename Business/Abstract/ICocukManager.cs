using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICocukManager
    {
        IDataResult<List<Cocuk>> GetAll(Expression<Func<Cocuk, bool>> filter = null);
        IResult Add(Cocuk entity);
        IResult Delete(Cocuk entity);
        IResult Update(Cocuk entity);
    }
}