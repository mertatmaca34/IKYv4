using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IIzinManager
    {
        IDataResult<List<Izin>> GetAll(Expression<Func<Izin, bool>> filter = null);
        IResult Add(Izin entity);
        IResult Delete(Izin entity);
        IResult Update(Izin entity);
    }
}