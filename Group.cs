using System;
using System.Collections.Generic;
using System.Text;

namespace TouristsGroup
{
    public class Group
    {
        public string Name { get; set; }
        public int size;
        public Tourist[] Tourists { get; set; }
        public Group()
        {

        }
        public Group(string name, int size)
        {
            if (string.IsNullOrWhiteSpace(name))
                return;
            Name = name;
            this.size = size;
            Tourists = new Tourist[size];
        }
        public bool GroupIsFull()
        {
            foreach (var tourist in Tourists)
            {
                if (tourist == null)
                    return false;
            }
            return true;
        }
        public bool AddTourist(Tourist tourist, int index)
        {
            if (index < 0 || index >= size)
                return false;

            if (tourist != null)
            {
                Tourists[index] = tourist;
                return true;
            }
            return false;
        }
        public bool DeleteTourist(int index)
        {
            if (index >= 0 && index < Tourists.Length)
            {
                Tourists[index] = null;
                return true;
            }
            return false;
        }
    }
}
