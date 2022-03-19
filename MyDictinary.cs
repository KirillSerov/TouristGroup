using System;
using System.Collections.Generic;
using System.Text;

namespace TouristsGroup
{
    public class MyDictinary
    {
        public Item Item { get; set; }
        public int Count { get; set; }
        public MyDictinary()
        {

        }
        public MyDictinary(Item item, int count)
        {
            Item = item;
            Count = count;
        }

        public override string ToString()
        {
            return $"{Item.Name} - {Count} шт.";
        }
    }
}
