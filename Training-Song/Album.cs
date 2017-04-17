using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Training_Songs
{
    internal class Album : IItem, IEnumerable<Song>
    {
        public Guid Id { get; }
        public Artist Artist { get; }
        public string Name { get; set; }
        public SortedList<int, Song> Songs { get; set; }

        public Album(Guid idAlbum, Artist artist, string name, SortedList<int, Song> songs)
        {
            Id = idAlbum;
            Artist = artist;
            Name = name;
            Songs = songs;
        }

        public Song this[int index]
        {
            get => Songs[index];
            set => Songs[index] = value;
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
