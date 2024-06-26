using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICalismaSaatleriManager
    {
        IDataResult<List<CalismaSaatleri>> GetAll(Expression<Func<CalismaSaatleri, bool>> filter = null);
        IResult Add(CalismaSaatleri entity);
        IResult Delete(CalismaSaatleri entity);
        IResult Update(CalismaSaatleri entity);
    }
}