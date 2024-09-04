using Core.Entities;

namespace Entities.Concrete
{
    public class KadroDurumlari : IEntity
    {
        public int Id { get; set; }
        public int SeflikId { get; set; }
        public int UnvanGrubuId { get; set; }
        public int KadroSayisi { get; set; }
        public int MevcutPersonelSayisi { get; set; }
    }
}
