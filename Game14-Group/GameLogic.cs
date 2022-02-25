using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game14_Group
{
    static class GameLogic
    {
        public static Player player;
        public static Terrain map;
        public static Random random = new Random();
        public static List<Entity> allEntities = new List<Entity>();
        public static List<Item> allItems = new List<Item>();

        public static GUI gui;
        public static List<String> guiText = new List<String>();

        public static List<Item> preparedItems = new List<Item>();


        public static void Init()
        {
            Item item = new Item("Катана");
            preparedItems.Add(item);
            item = new Item("Аптечка");
            preparedItems.Add(item);
            item = new Item("Ускоритель");
            preparedItems.Add(item);
            item = new Item("Телепортер");
            preparedItems.Add(item);
        }

    }
}
