using System;
using System.Collections.Generic;
using System.Text;

namespace JurnalModul6_103082400034
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random rnd = new Random();
            id = rnd.Next(10000, 100000);

        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;

        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Id : {id}, title : {title}, play count : {playCount}");

        }
    }
}
