namespace Poll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mozzarella = 0;
            int fourCheese = 0;
            int calabresa = 0;
            int randNumber;
            Random rand = new Random();

            for (int i = 0; i < 11; i++)
            {
                randNumber = rand.Next(4);
                switch (randNumber)
                {
                    case 1:
                        mozzarella++;
                        break;
                    case 2:
                        calabresa++;
                        break;
                    default:
                        fourCheese++;
                        break;
                }
            }

            Console.WriteLine($"Mozzarela: {mozzarella} | Four Cheese: {fourCheese} | Calabresa: {calabresa}");

            string prefix = "The most popular flavor was: ";
            if (mozzarella > fourCheese && mozzarella > calabresa)
            {
                Console.WriteLine(prefix + "mozzarela");
            } else if (fourCheese > mozzarella && fourCheese > calabresa)
            {
                Console.WriteLine(prefix + "four cheese");

            } else
            {
                Console.WriteLine(prefix + "calabresa");
            }

        }
    }
}
