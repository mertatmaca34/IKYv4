using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface INakilManager
    {
        IDataResult<List<Nakil>> GetAll(Expression<Func<Nakil, bool>> filter = null);
        IResult Add(Nakil genel);
        IResult Delete(Nakil genel);
        IResult Update(Nakil genel);
    }
}