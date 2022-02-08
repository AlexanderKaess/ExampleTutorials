using System;

namespace Tutorial_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            Post post1 = new Post("Meine neuen Schuhe sind schön", true, "ALEX");
            Console.WriteLine("Die Post.ToString-Methode ergibt: {0}", post1.ToString());

            ImagePost bildPost1 = new ImagePost("Meine neuen Schuhe", "ALEX", "https://www.amazon.de/DoGeek-Aufladen-Leuchtend-Sportschuhe-Turnschuhe/dp/B01MZZ5QPG", true);
            Console.WriteLine("Die Post.ToString-Methode ergibt: {0}", bildPost1.ToString());

            VideoPost videoPost1 = new VideoPost("Video meiner Schuhe", "ALEX", "https://www.amazon.de/DoGeek-Aufladen-Leuchtend-Sportschuhe-Turnschuhe/dp/B01MZZ5QPG", 10, true);
            Console.WriteLine("Die Post.ToString-Methode ergibt: {0}", videoPost1.ToString());
            videoPost1.PlayVideo();
            Console.WriteLine("Drücke eine Taste um das Video zu stoppen");
            Console.ReadKey();
            videoPost1.StopVideo();

            Console.ReadKey();
        }
    }
}
