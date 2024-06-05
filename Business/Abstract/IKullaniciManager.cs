using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IKullaniciManager
    {
        IDataResult<List<Kullanici>> GetAll(Expression<Func<Kullanici, bool>> filter = null);
        IResult Add(Kullanici genel);
        IResult Delete(Kullanici genel);
        IResult Update(Kullanici genel);
    }
}