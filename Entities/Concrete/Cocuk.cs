using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cocuk : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string CocukAdi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string CocukCinsiyeti { get; set; }
        public string Hakkinda { get; set; }
    }
}
