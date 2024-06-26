using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CalismaSaatleri : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string PazartesiBaslama { get; set; }
        public string PazartesiBitme { get; set; }
        public string SaliBaslama { get; set; }
        public string SaliBitme { get; set; }
        public string CarsambaBaslama { get; set; }
        public string CarsambaBitme { get; set; }
        public string PersembeBaslama { get; set; }
        public string PersembeBitme { get; set; }
        public string CumaBaslama { get; set; }
        public string CumaBitme { get; set; }
        public string CumartesiBaslama { get; set; }
        public string CumartesiBitme { get; set; }
        public string PazarBaslama { get; set; }
        public string PazarBitme { get; set; }
    }
}
