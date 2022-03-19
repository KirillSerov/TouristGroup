using System;
using System.Collections.Generic;
using System.Text;

namespace TouristsGroup
{
     public class Item
    {
        public Item()
        {

        }
        public Item(string name, int lvl, int weight, string picture)
        {
            Name = name;
            Level = lvl;
            Weight = weight;
            Picture = picture;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Weight { get; set; }
        public string Picture { get; set; }
        public virtual void Copy(Item other)
        {
            other.Name = Name;
            other.Level = Level;
            other.Weight = Weight;  
            other.Picture = Picture;
        }
        public string ShowInfo()
        {
            return $"Название: {Name}, уровень: {Level}, вес: {Weight}";
        }
       
    }
}
