using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Training_Songs
{
    internal class Album : Item, IEnumerable<Song>
    {
        public Guid Id { get; }
        public Artist Artist { get; }
        public string Name { get; set; }
        public SortedList<int, Song> Songs { get; set; }

        public Album(Guid idAlbum, Artist artist, string name, SortedList<int, Song> songs)
        {
            this.Id = idAlbum;
            this.Artist = artist;
            this.Name = name;
            this.Songs = songs;
        }

        public Song this[int index]
        {
            get => this.Songs[index];
            set => this.Songs[index] = value;
        }

        public IEnumerator<Song> GetEnumerator()
        {
            return Songs.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Songs.GetEnumerator();
        }

        public override string ToString()
        {
            return Artist + " - " + Name;
        }

        public string ListSongs()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("[");
            foreach (Song song in this)
            {
                builder.Append(song).Append(", ");
            }
            // removes last ", "
            if (builder.Length > 2)
            {
                builder.Remove(builder.Length - 2, 2);
            }
            builder.Append("]");
            return builder.ToString();
        }
    }
}
