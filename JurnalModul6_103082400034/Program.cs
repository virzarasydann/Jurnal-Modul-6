using System;
using System.Collections.Generic;
using System.Text;

namespace JurnalModul6_103082400034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Train To Busan");
            SayaTubeVideo video2 = new SayaTubeVideo("Snowpiercer");
            SayaTubeVideo video3 = new SayaTubeVideo("Lucy 2014");

            SayaTubeUser user = new SayaTubeUser("Virza Absyar");
            user.AddVideo(video1);
            user.AddVideo(video2);
            user.AddVideo(video3);

            user.PrintAllVideoPlaycount();
        }
    }
}
