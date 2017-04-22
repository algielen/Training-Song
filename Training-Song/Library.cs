using System.Collections.Generic;

namespace Training_Song
{
    internal class Library
    {
        public SortedSet<INamedItem> Items { get; }

        public Library(SortedSet<INamedItem> items)
        {
            Items = items;
        }

        public Library AddItem(INamedItem item)
        {
            Items.Add(item);
            return this;
        }

        public Library RemoveItem(INamedItem item)
        {
            Items.Remove(item);
            return this;
        }
    }
}
