using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMudurlukManager
    {
        IDataResult<List<Mudurluk>> GetAll(Expression<Func<Mudurluk, bool>> filter = null);
        IResult Add(Mudurluk genel);
        IResult Delete(Mudurluk genel);
        IResult Update(Mudurluk genel);
    }
}
