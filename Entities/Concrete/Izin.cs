using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Izin
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string IzinTuru { get; set; }
        public DateTime IzinBaslama { get; set; }
        public DateTime IzinBitis { get; set; }
    }
}