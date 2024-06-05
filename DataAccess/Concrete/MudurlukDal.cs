using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class MudurlukDal : BaseRepository<Mudurluk, IKYContext>, IMudurlukDal { }
}
