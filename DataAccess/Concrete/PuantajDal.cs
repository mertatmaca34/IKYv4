using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class PuantajDal : BaseRepository<Puantaj, IKYContext>, IPuantajDal { }
}
