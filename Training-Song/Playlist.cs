using System;
using System.Collections.Generic;
using Training_Song;

namespace Training_Song
{
    class Playlist : IPlayableItem
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        public Playlist(Guid id, string name, List<Song> songs)
        {
            Id = id;
            Name = name;
            Songs = songs;
        }

        public void Play()
        {
            foreach (Song song in Songs)
            {
                song.Play();
            }
        }
    }
}
