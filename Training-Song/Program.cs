using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Training_Songs;

namespace Training_Song
{
    class Program
    {
        static void Main(string[] args)
        {
            Artist germans = new Artist(Guid.NewGuid(), "Germans");
            Song cruel = new Song(Guid.NewGuid(), "Cruel", germans);
            Song crueler = new Song(Guid.NewGuid(), "Crueler", germans);
            Song cruelest = new Song(Guid.NewGuid(), "Cruelest", germans);
            SortedList<int, Song> songs = new SortedList<int, Song>() { { 0, cruel }, { 1, crueler }, { 2, cruelest } };
            Album album = new Album(Guid.NewGuid(), germans, "Cruel", songs);
            Console.WriteLine("Album : " + album);

            Console.WriteLine(album.ListSongs());
            Library library = new Library(new SortedSet<Item>() { album });
            Console.WriteLine("Library : " + library.Items);
            Debugger.Break();
        }
    }
}