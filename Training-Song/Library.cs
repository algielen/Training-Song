using System.Collections.Generic;

namespace Training_Songs
{
    internal class Library
    {
        public SortedSet<IItem> Items { get; }

        public Library(SortedSet<IItem> items)
        {
            Items = items;
        }

        public Library AddItem(IItem item)
        {
            Items.Add(item);
            return this;
        }
    }
}
