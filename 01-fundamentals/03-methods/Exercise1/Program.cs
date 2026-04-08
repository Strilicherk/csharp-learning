namespace Exercise1
{
    internal class ExerciseMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VerifyMajority(23));
            Console.WriteLine(CalculateAverage(4, 5.0, 10));
            Console.WriteLine(LargestNumber(5, 15, 8));
            Console.WriteLine(CalculateFactorial(5));
            Console.WriteLine(VerifyPrime(10));
            Console.WriteLine(CalculatePower(2, 5));
            Console.WriteLine(CalculateChangeInCandies(15, 20));
            Console.WriteLine(VerifyPalindrome("arara"));
        }

        static bool VerifyMajority(int age)
        {
            Console.WriteLine("Verifying Majority...");
            return age >= 18;
        }

        static double CalculateAverage(double value1, double value2, double value3)
        {
            Console.WriteLine("Calculating Average...");
            return (value1 + value2 + value3) / 3;
        }

        static int LargestNumber(int value1, int value2, int value3)
        {
            Console.WriteLine("Calculating Largest Number...");
            if (value1 >= value2 && value1 >= value3)
            {
                return value1;
            }
            else if (value2 >= value1 && value2 >= value3)
            {
                return value2;
            }
            else
            {
                return value3;
            }
        }

        static int CalculateFactorial(int value)
        {
            Console.WriteLine("Calculating Factorial...");
            int total = 1;
            for (int i = value; i > 1; i--)
            {
                total = total * i;
            }
            return total;
        }

        static bool VerifyPrime(int value)
        {
            Console.WriteLine("Verifying Prime...");
            if (value <= 1)
            {
                return false;
            }

            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int CalculatePower(int baseValue, int exponent)
        {
            Console.WriteLine("Calculating Power...");
            int total = 1;
            for (int i = 0; i < exponent; i++)
            {
                total = total * baseValue;
            }
            return total;
        }

        static int CalculateChangeInCandies(double purchaseValue, double receivedValue)
        {
            Console.WriteLine("Calculating Changes...");
            if (purchaseValue >= receivedValue)
            {
                return 0;
            }
            else
            {
                double change = receivedValue - purchaseValue;
                int total = 0;

                while (change >= 0.25)
                {
                    total++;
                    change -= 0.25;
                }

                return total;
            }
        }

        static bool VerifyPalindrome(string word)
        {
            string lowerWord = word.ToLower();
            string backwardWord = "";
            Console.WriteLine("Verifying Palindrome");
            for (int i = word.Length - 1; i >= 0; i--)
            {
                backwardWord += lowerWord[i];
            }
            return lowerWord == backwardWord;
        }
    }
}
