using System;
using System.Collections.Generic;
using System.Diagnostics;
using Training_Songs;

namespace Training_Song
{
    class Program
    {
        static void Main(string[] args)
        {
            Artist germans = new Artist(Guid.NewGuid(), "Germans");
            Song cruel = new Song(Guid.NewGuid(), "Cruel", germans);
            Item album = new Album(Guid.NewGuid(), germans, new SortedSet<Song>() { cruel });
            Console.WriteLine("Album : " + album);
            Library library = new Library(new SortedSet<Item>() { album });
            Console.WriteLine("Library : " + library.Items);
            Debugger.Break();
        }
    }
}