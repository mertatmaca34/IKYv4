using Core.Entities;

namespace Entities.Concrete
{
    public class Sertifika : IEntity
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public string SertifikaAdi { get; set; }
    }
}