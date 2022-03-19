using System;
using System.Collections.Generic;
using System.Text;

namespace TouristsGroup
{
    public class Shoes : Item // обувь
    {
        public Shoes():base()
        {

        }
        public Shoes(string name, int lvl, int weight, string picture) : base(name, lvl, weight, picture)
        {

        }
       
    }
}
