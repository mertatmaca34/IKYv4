using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Seflik : IEntity
    {
        public int Id { get; set; }
        public string MudurlukAdi { get; set; }
        public string SeflikAdi { get; set; }
    }
}