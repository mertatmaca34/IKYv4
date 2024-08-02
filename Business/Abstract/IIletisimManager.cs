using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IIletisimManager
    {
        IDataResult<List<Iletisim>> GetAll(Expression<Func<Iletisim, bool>> filter = null);
        IResult Add(Iletisim genel);
        IResult Delete(Iletisim genel);
        IResult Update(Iletisim genel);
    }
}