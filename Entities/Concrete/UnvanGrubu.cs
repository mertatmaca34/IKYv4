using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UnvanGrubu : IEntity
    {
        public int Id { get; set; }
        public string UnvanGrubuAdi { get; set; }
        public string PK { get; set; }
        public string MK { get; set; }
        public string TK { get; set; }
    }
}