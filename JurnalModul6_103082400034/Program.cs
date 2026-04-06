using System;
using System.Collections.Generic;
using System.Text;

namespace JurnalModul6_103082400034
{
    internal class Program
    {
        static void Main(string[] args)
        {


            SayaTubeUser userGagal = new SayaTubeUser(null);
            SayaTubeVideo videoGagal = new SayaTubeVideo(new string('A', 250));

            SayaTubeUser user = new SayaTubeUser("Virza Absyar");
            SayaTubeVideo videoUtama = new SayaTubeVideo("Tutorial C# dengan Debug Assert");

            user.AddVideo(null);
            videoUtama.IncreasePlayCount(-100);
            videoUtama.IncreasePlayCount(30000000);


            Console.WriteLine("=== PENGUJIAN EXCEPTION OVERFLOW ===");
            try
            {
                
                for (int i = 0; i < 100; i++)
                {
                    videoUtama.IncreasePlayCount(25000000);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Pengecekan Overflow Berhasil: " + ex.Message);
            }

            
            Console.WriteLine("\n=== PENGUJIAN POSTCONDITION ===");
            for (int i = 1; i <= 10; i++)
            {
                user.AddVideo(new SayaTubeVideo($"Video Keren Part {i}"));
            }

            
            user.PrintAllVideoPlaycount();

            Console.ReadLine();
        }
    }
}
