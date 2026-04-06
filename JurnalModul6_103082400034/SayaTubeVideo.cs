using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null, "Precondition gagal: Judul video tidak boleh null.");
            Debug.Assert(title.Length <= 200, "Precondition gagal: Judul video memiliki panjang maksimal 200 karakter.");
            this.title = title;
            Random rnd = new Random();
            id = rnd.Next(10000, 100000);

            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount >= 0, "Precondition gagal: Input play count tidak boleh negatif.");
            Debug.Assert(playCount <= 25000000, "Precondition gagal: Input penambahan maksimal 25.000.000 per panggilan.");

          
            this.playCount = checked(this.playCount + playCount);

        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Id : {id}, title : {title}, play count : {playCount}");

        }

        public int GetPlayCount()
        {
            return this.playCount;
        }
    }
}
