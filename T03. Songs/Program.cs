using System;
using System.Collections.Generic;

namespace T03._Songs
{
    class Song
    {
        //public Song(string type, string name, string time)
        //{
        //    this.TypeList = type;
        //    this.Name = name;
        //    this.Time = time;
        //}
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<Song> allSongs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                Song song = new Song();

                string[] currentSongInfo = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);

                string type = currentSongInfo[0];
                string name = currentSongInfo[1];
                string time = currentSongInfo[2];

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                allSongs.Add(song);
            }

            string wantedType = Console.ReadLine();

            if (wantedType != "all")
            {
                List<Song> filteredSongs = allSongs.FindAll(x => x.TypeList == wantedType);

                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in allSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
