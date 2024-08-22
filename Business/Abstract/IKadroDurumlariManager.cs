using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKadroDurumlariManager
    {
        IDataResult<List<KadroDurumlari>> GetAll(Expression<Func<KadroDurumlari, bool>> filter = null);
        IResult Add(KadroDurumlari entity);
        IResult Delete(KadroDurumlari entity);
        IResult Update(KadroDurumlari entity);
    }
}
