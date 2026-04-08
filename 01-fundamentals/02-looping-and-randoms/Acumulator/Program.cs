namespace Acumulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalValue = 0;
            int? currentNumber = null;
            Random random = new Random();


            while (currentNumber != 0)
            {
                currentNumber = random.Next(11);
                Console.WriteLine($"Drawn number: {currentNumber}");
                totalValue += (int)currentNumber;
            }

            Console.WriteLine($"The sum of the numbers is: {totalValue}");
        }
    }
}
