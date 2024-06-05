using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Unvan : IEntity
    {
        public int Id { get; set; }
        public int UnvanGrubuId { get; set; }
    }
}