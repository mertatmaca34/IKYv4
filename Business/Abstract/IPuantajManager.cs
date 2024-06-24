using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IPuantajManager
    {
        IDataResult<List<Puantaj>> GetAll(Expression<Func<Puantaj, bool>> filter = null);
        IResult Add(Puantaj puantaj);
        IResult Delete(Puantaj puantaj);
        IResult Update(Puantaj puantaj);
    }
}