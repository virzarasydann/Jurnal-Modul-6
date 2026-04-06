using System;
using System.Collections.Generic;
using System.Text;

namespace JurnalModul6_103082400034
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            Username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public void GetTotalVideoPlayCount()
        {
            Console.WriteLine($"Total playcount {uploadedVideos.Count}");

        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            int count = 0;
            Console.WriteLine($"Username : {Username}");
            foreach (var item in uploadedVideos)
            {
                count++;
                Console.Write($"Video {count} judul - ");

                
                item.PrintVideoDetails();
            }
        }
    }
}
