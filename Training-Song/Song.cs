using System;

namespace Training_Song
{
    internal class Song : INamedItem
    {
        public Guid Id { get; }
        public Artist Artist { get; }
        public string Name { get; set; }
        public Song(Guid idSong, string name, Artist artist)
        {
            Id = idSong;
            Name = name;
            Artist = artist;
        }

        public override string ToString()
        {
            return Artist + " - " + Name;
        }

        public void Play()
        {
            Console.WriteLine(this + " is now playing");
        }
    }
}
