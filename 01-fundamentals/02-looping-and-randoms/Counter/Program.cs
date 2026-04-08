namespace Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalValue = 0.15;
            for (int i = 0; totalValue < 4.85; i++)
            {
                totalValue += 0.15;
                Console.WriteLine(totalValue);
            }
        }
    }
}
