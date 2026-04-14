using System;
using System.Collections.Generic;
using System.Text;

namespace modul6_103082400029
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            if (username == null || username.Length > 100)
            {
                throw new ArgumentException("Username tidak valid");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
            {
                throw new ArgumentException("Video tidak boleh null");
            }

            if (video.GetPlayCount() == int.MaxValue)
            {
                throw new ArgumentException("PlayCount sudah mencapai batas maksimum");
            }

            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;

            foreach (var video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }

            return total;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + Username);

            int jumlah = uploadedVideos.Count;


            if (jumlah > 8)
            {
                jumlah = 8;
            }

            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }

    }

}