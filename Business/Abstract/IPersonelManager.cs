using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IPersonelManager
    {
        IDataResult<List<Personel>> GetAll(Expression<Func<Personel, bool>> filter = null);
        IResult Add(Personel genel);
        IResult Delete(Personel genel);
        IResult Update(Personel genel);
    }
}