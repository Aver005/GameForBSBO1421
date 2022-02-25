using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game14_Group
{
    class AgressiveEntity : LivingEntity
    {
        public Item gunSlot { get; set; }
        public AgressiveEntity() { symbol = "E"; }
    }
}
