using System;

namespace Training_Song
{
    internal class Artist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Artist(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}