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

        public Playlist AddSong(Song song)
        {
            Songs.Add(song);
            return this;
        }

        public Playlist AddSongs(List<Song> songs)
        {
            Songs.AddRange(songs);
            return this;
        }

        public Playlist RemoveSong(Song song)
        {
            Songs.Remove(song);
            return this;
        }

        public Playlist RemoveSongs(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                Songs.Remove(song);
            }
            return this;
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