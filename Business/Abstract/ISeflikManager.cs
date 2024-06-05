using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ISeflikManager
    {
        IDataResult<List<Seflik>> GetAll(Expression<Func<Seflik, bool>> filter = null);
        IResult Add(Seflik entity);
        IResult Delete(Seflik entity);
        IResult Update(Seflik entity);
    }
}
