using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class TesisDal : BaseRepository<Tesis, IKYContext>, ITesisDal { }
}