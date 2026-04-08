using System.Security.Cryptography;

namespace Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chosenNumber = 5;
            int attempts = 0;
            int? currentNumber = null;
            Random random = new Random();


            while (currentNumber != chosenNumber){
                currentNumber = random.Next(11);
                Console.WriteLine($"Drawn number: {currentNumber}");

                if (currentNumber != chosenNumber)
                {
                    attempts++;
                }
                else if (attempts <= 3)
                {
                    Console.WriteLine("You're VERY lucky.");
                }
                else if (attempts <= 10)
                {
                    Console.WriteLine("You're lucky.");
                }
                else
                {
                    Console.WriteLine("It is better to stop betting and go find a job.");
                }
            }

        }
    }
}
