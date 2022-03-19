using System;
using System.Collections.Generic;
using System.Text;

namespace TouristsGroup
{
    public class Backpack:Item // рюкзак
    {
        public int Volume { get; set; }
        public Backpack():base()
        {

        }
        public Backpack(string name, int lvl, int weight,string picture, int volume) : base(name, lvl, weight,picture)
        {
            Volume = volume;
        }
        public override void Copy(Item other)
        {
            if (other is Backpack)
            {
               other.Name = Name;
                other.Level = Level;
                other.Weight = Weight;
                other.Picture = Picture;
                (other as Backpack).Volume = Volume;
            }
        }

    }
}
