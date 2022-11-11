using System.Security.Cryptography;

namespace SHVFS_P101_C6_GD_Bandy
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Write your name");
            string B =Console.ReadLine();

            int C = 0;

            string[] food = new string[] {"rice","noodle" };
            Random random = new Random();
            int A = random.Next(food.Length);
            string S = "";
            while (S!= food[A])
            {
                Console.Clear();
                C++;
                Console.WriteLine($"{B} Guess a word");
                S = Console.ReadLine();
            }
            Console.WriteLine($"You guess {C} times, Right");
        }
    }
}
