using System;
using System.Collections.Generic;
using System.Text;

namespace TouristsGroup
{
    public class Tourist
    {
        public static string[] LevelString => new string[] { "новичок", "любитель", "профессионал" };
        public enum Level
        {
            BEGIN,
            MIDDLE,
            HIGHT
        }
        public Item[] Items { get; set; }
        public List<MyDictinary> Inventar { get; set; }
        public Tourist()
        {

        }
        public Tourist(string firstname, string surname, Level lvl)
        {
            Firstname = firstname;
            Surname = surname;
            TouristLevel = lvl;
            Items = new Item[4];
            Inventar = new List<MyDictinary>();
        }

        public string Firstname { get; set; }
        public string Surname { get; set; }
        public Level TouristLevel { get; set; }

        public bool AddItem(Item item)
        {
            if (item is Cap)
                Items[0] = item;
            else if (item is Jacket)
                Items[1] = item;
            else if (item is Shoes)
                Items[2] = item;
            else if (item is Backpack)
                Items[3] = item;
            else
                return false;

            return true;
        }
        public bool AddOtherItem(Item item, int count)
        {
            foreach (var i in Inventar)
            {
                if (i.Item.GetType().Name == item.GetType().Name)
                {
                    i.Count += count;
                    return true;
                }
            }
            Inventar.Add(new MyDictinary(item, count));
            return true;
            
        }
    }

}

