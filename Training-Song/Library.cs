using System.Collections.Generic;

namespace Training_Song
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

        public Library RemoveItem(IItem item)
        {
            Items.Remove(item);
            return this;
        }
    }
}
