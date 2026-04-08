namespace Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseValue = 2;
            int exponentValue = 5;
            int totalValue = baseValue;

            for (int i = 1; i < exponentValue; i++)
            {
                totalValue = totalValue * baseValue;
                Console.WriteLine($"Total Value: {totalValue}");
            }
        }
    }
}
