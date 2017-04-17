using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Songs
{
    internal class Song : Item
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
    }
}
