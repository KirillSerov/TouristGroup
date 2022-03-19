using System;
using System.Collections.Generic;
using System.Text;

namespace TouristsGroup
{
    public class Jacket : Item // куртка
    {
        public Jacket():base()
        {

        }
        public Jacket(string name, int lvl, int weight, string picture) : base(name, lvl, weight,picture)
        {

        }
        
    }
}
