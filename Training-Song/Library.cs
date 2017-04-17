using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Songs
{
    internal class Library
    {
        public SortedSet<Item> Items { get; }

        public Library(SortedSet<Item> items)
        {
            Items = items;
        }

        public Library AddItem(Item item)
        {
            Items.Add(item);
            return this;
        }
    }
}
