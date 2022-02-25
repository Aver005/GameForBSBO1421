using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game14_Group
{
    class LivingEntity : Entity
    {
        public int hp { get; set; }
        public LivingEntity() { symbol = "L"; }
    }
}
