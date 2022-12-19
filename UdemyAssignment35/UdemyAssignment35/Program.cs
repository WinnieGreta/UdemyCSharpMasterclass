using System;

namespace UdemyAssignment35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Merry Christmas", true, "Panjuta");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my shoes", "Panjuta", "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Dancing in the Snow", "Panjuta", "https://youtube.com/snow", 10, true);
            Console.WriteLine(videoPost1.ToString());

            VideoPost videoPost2 = new VideoPost("Dancing in the Snow - 2", "Panjuta", "https://youtube.com/snow", 15, true);
            Console.WriteLine(videoPost2.ToString());
        }
    }

}
