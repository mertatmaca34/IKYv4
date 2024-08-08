using Core.Entities;

namespace Entities.Concrete.TurkeyModel
{
    public class Neighbourhood : IEntity
    {
        public string mahalle_id { get; set; }
        public string mahalle_title { get; set; }
        public string mahalle_key { get; set; }
        public string mahalle_ilcekey { get; set; }
    }
}
