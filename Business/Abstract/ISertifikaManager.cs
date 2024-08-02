using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ISertifikaManager
    {
        IDataResult<List<Sertifika>> GetAll(Expression<Func<Sertifika, bool>> filter = null);
        IResult Add(Sertifika genel);
        IResult Delete(Sertifika genel);
        IResult Update(Sertifika genel);
    }
}