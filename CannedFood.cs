using System;
using System.Collections.Generic;
using System.Text;

namespace TouristsGroup
{
    // Консервы.
    public class CannedFood : Item
    {
        public CannedFood() : base()
        {

        }
        public CannedFood(string name, int lvl, int weight, string picture) : base(name, lvl, weight, picture)
        {

        }
    }
}
