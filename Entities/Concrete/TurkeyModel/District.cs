using Core.Entities;

namespace Entities.Concrete.TurkeyModel
{
    public class District : IEntity
    {
        public string ilce_id { get; set; }
        public string ilce_title { get; set; }
        public string ilce_key { get; set; }
        public string ilce_sehirkey { get; set; }
    }
}
