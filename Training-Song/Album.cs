using System;
using System.Collections.Generic;

namespace Training_Songs
{
    internal class Album : Item
    {
        public Guid Id { get; }
        public Artist Artist { get; }
        public string Name { get; set; }
        public SortedSet<Song> Songs { get; set; }

        public Album(Guid idAlbum, Artist artist, SortedSet<Song> songs)
        {
            this.Id = idAlbum;
            this.Artist = artist;
            this.Songs = songs;
        }
    }
}
