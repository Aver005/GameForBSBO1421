using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game14_Group
{
    class Enemy : AgressiveEntity
    {
        public LivingEntity target { get; set; }
        public List<LivingEntity> targets { get; set; }
    }
}
