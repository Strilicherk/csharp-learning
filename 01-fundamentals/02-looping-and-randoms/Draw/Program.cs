namespace Draw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectedNumber = 78;
            int? firstMatch = null;
            int currentNumber;
            int evens = 0;
            int odds = 0;
            Random random = new Random();


            for (int i = 1; i <= 200; i++)
            {
                currentNumber = random.Next(1, 101);
                Console.WriteLine(currentNumber);
                if (currentNumber % 2 == 0)
                {
                    evens++;
                }
                else
                {
                    odds++;
                }

                if (firstMatch == null && currentNumber == selectedNumber)
                {
                    firstMatch = i;
                }
            }

            Console.WriteLine($"{odds} odd numbers drawn.");
            Console.WriteLine($"{evens} even numbers drawn.");

            if (firstMatch == null)
            {
                Console.WriteLine($"The selected number was never drawn.");
            } else
            {
                Console.WriteLine($"The selected number was drawn for the first time on attempt number {firstMatch}.");
            }
        }
    }
}
