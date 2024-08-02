using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ITahsilManager
    {
        IDataResult<List<Tahsil>> GetAll(Expression<Func<Tahsil, bool>> filter = null);
        IResult Add(Tahsil genel);
        IResult Delete(Tahsil genel);
        IResult Update(Tahsil genel);
    }
}