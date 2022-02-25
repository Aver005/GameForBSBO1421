using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game14_Group
{
    internal class Chest : InteractiveEntity
    {
        public ChestGUI gui;
        public List<Item> items = new List<Item>();
        public Chest(bool Refily)
        {
            gui = new ChestGUI(this);
            symbol = "C";
            if (Refily) { Refil(GameLogic.random.Next(0, 4)); }
        }

        public void Interact() { GameLogic.gui = gui; }
        public void Refil(int sizy)
        {
            List<Item> list = GameLogic.preparedItems;
            for(int i = 0; i < sizy; i++)
            {
                Item item = list[GameLogic.random.Next(0, list.Count - 1)];
                items.Add(item);
            }
        }
    }
}
