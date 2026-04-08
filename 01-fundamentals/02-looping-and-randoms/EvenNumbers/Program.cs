namespace EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 41) {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}
