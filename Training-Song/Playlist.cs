using System;
using Training_Song;

namespace Training_Song
{
    class Playlist : IItem
    {
        public Guid Id { get; }
        public Artist Artist { get; }
        public string Name { get; set; }
    }
}
