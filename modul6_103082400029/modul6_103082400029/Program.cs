using modul6_103082400029;
using System;

class Program
{
    static void Main(string[] args)
    {
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
        Console.WriteLine("Total Play Count: " + user.GetTotalVideoPlayCount());

    }

}