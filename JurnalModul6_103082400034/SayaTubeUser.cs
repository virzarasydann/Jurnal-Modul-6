using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(username != null, "Precondition gagal: Nama username tidak boleh null.");
            Debug.Assert(username.Length <= 100, "Precondition gagal: Nama username maksimal 100 karakter.");

            Username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public void GetTotalVideoPlayCount()
        {
            Console.WriteLine($"Total playcount {uploadedVideos.Count}");

        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null, "Precondition gagal: Video yang ditambahkan tidak boleh null.");
            Debug.Assert(video.GetPlayCount() < int.MaxValue, "Precondition gagal: Video playCount sudah mencapai integer maksimum.");

            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            int count = 0;
            Console.WriteLine($"Username : {Username}");
            foreach (var item in uploadedVideos)
            {
                Debug.Assert(count < 8, "Postcondition gagal: Jumlah video maksimal yang di-print adalah 8.");

                
                if (count >= 8)
                {
                    Console.WriteLine("... (Video lainnya tidak ditampilkan)");
                    break;
                }
                count++;
                Console.Write($"Video {count} judul - ");

                
                item.PrintVideoDetails();
            }
        }
    }
}
