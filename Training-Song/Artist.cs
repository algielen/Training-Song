using System;

namespace Training_Songs
{
    internal class Artist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Artist(Guid id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}