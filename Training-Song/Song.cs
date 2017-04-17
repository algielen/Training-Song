using System;

namespace Training_Songs
{
    internal class Song : IItem
    {
        public Guid Id { get; }
        public Artist Artist { get; }
        public string Name { get; set; }
        public Song(Guid idSong, string name, Artist artist)
        {
            this.Id = idSong;
            this.Name = name;
            this.Artist = artist;
        }

        public override string ToString()
        {
            return Artist + " - " + Name;
        }
    }
}
