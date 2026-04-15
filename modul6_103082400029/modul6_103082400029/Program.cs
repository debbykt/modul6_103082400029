using System;

namespace modul6_103082400029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OUTPUT NORMAL ===\n");

            SayaTubeUser user = new SayaTubeUser("NamaKamu");

            string[] filmList = {
                "Avengers",
                "Inception",
                "Interstellar",
                "The Dark Knight",
                "Parasite",
                "Joker",
                "Titanic",
                "Forrest Gump",
                "The Matrix",
                "Harry Potter"
            };

            foreach (var film in filmList)
            {
                SayaTubeVideo video = new SayaTubeVideo($"Review Film {film} oleh NamaKamu");
                video.IncreasePlayCount(1000);
                user.AddVideo(video);
            }

            user.PrintAllVideoPlaycount();
            Console.WriteLine("\nTotal Play Count: " + user.GetTotalVideoPlayCount());


            Console.WriteLine("\n=== TEST ERROR ===\n");

            try
            {
                SayaTubeVideo errorVideo = new SayaTubeVideo(null);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error (judul null): " + e.Message);
            }

            try
            {
                SayaTubeVideo video2 = new SayaTubeVideo("Test Video");
                video2.IncreasePlayCount(-10);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error (playcount negatif): " + e.Message);
            }

            SayaTubeVideo testOverflow = new SayaTubeVideo("Test Overflow");

            for (int i = 0; i < 100; i++)
            {
                testOverflow.IncreasePlayCount(25000000);
            }

            Console.WriteLine("\n=== SELESAI ===");
        }

    }

}