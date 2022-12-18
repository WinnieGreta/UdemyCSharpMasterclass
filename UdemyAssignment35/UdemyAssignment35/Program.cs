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
        }
    }

}
