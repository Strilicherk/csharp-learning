namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please, insert your name:");
            string name = "";
            while (name == "" || name is null)
            {
                name = Console.ReadLine();
            }

            int amountOfTests = 0;
            while (amountOfTests <= 0)
            {
                Console.WriteLine("Now, how many tests did you do?");
                amountOfTests = Convert.ToInt32(Console.ReadLine());
            }


            double[] grade = new double[amountOfTests];
            double gradeSum = 0;
            for (int i = 0; i < amountOfTests; i++)
            {
                Console.WriteLine($"Insert your {i + 1} grade:");
                double gradeValue = Convert.ToDouble(Console.ReadLine());
                grade[i] = gradeValue;
                gradeSum += gradeValue;
            }

            Console.WriteLine(gradeSum);
            Console.WriteLine($"Student: {name}");
            Console.WriteLine($"Average: {gradeSum / amountOfTests}");


            Console.ReadKey();
        }
    }
}
