using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game14_Group
{
    internal class ChestGUI : GUI
    {
        public Chest chest;
        public ChestGUI(Chest chesty)
        {
            chest = chesty;
        }

        public void Draw()
        {
            Console.WriteLine("▌▬▬▬▬▬▬▬▬ Chest ▬▬▬▬▬▬▬▬▬");
            int i = 1;
            foreach(Item item in chest.items)
            {
                Console.WriteLine("▌ " + i + ". " + item.name);
                i++;
            }
            Console.WriteLine("▌▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
        }
    }
}
