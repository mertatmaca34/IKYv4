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
        public double PK { get; set; }
        public double MK { get; set; }
        public double TK { get; set; }
    }
}