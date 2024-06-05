using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tesis : IEntity
    {
        public int Id { get; set; }
        public string SeflikAdi { get; set; }
        public string TesisAdi { get; set; }
    }
}