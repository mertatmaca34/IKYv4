using Core.Entities;

namespace Entities.Concrete.TurkeyModel
{
    public class City : IEntity
    {
        public string sehir_id { get; set; }
        public string sehir_title { get; set; }
        public string sehir_key { get; set; }
    }
}
