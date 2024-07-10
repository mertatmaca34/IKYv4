using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface INufusManager
    {
        IDataResult<List<Nufus>> GetAll(Expression<Func<Nufus, bool>> filter = null);
        IResult Add(Nufus genel);
        IResult Delete(Nufus genel);
        IResult Update(Nufus genel);
    }
}