using System;
using System.Collections.Generic;

namespace Training_Songs
{
    internal class Album : Item
    {
        public Guid Id { get; }
        public Artist Artist { get; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        public Album(Guid idAlbum, Artist artist, List<Song> songs)
        {
            this.Id = idAlbum;
            this.Artist = artist;
            this.Songs = songs;
        }

        public Song this[int index]
        {
            get => this.Songs[index];
            set => this.Songs[index] = value;
        }
    }
}
