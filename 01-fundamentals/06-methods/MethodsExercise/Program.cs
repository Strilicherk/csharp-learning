namespace MethodsExercise
{
    public class GradeManager
    {
        public static void Main(string[] args)
        {
            GradeManager manager = new GradeManager();

            List<double> grades = manager.ReadGrades();

            double? average = manager.CalculateAverage(grades);
            if (average.HasValue)
            {
                Console.WriteLine($"Average: {average.Value}");
            }

            bool? result = manager.VerifyResult(average);
            if (result.HasValue)
            {
                Console.WriteLine($"Passed: {result.Value}");
            }

            if (average.HasValue)
            {
                manager.CalculateDifference(grades, average.Value);
            }

            double? weightedAverage = manager.CalculateWeightedAverage(grades);
            if (weightedAverage.HasValue)
            {
                Console.WriteLine($"Weighted Average: {weightedAverage.Value}");
            }

            Console.ReadKey();
        }

        public List<double> ReadGrades()
        {
            Console.WriteLine("Enter the number of grades:");
            if (!int.TryParse(Console.ReadLine(), out int count) || count < 1)
            {
                return new List<double>();
            }

            List<double> grades = new List<double>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter grade {i + 1}:");
                if (double.TryParse(Console.ReadLine(), out double grade))
                {
                    grades.Add(grade);
                }
                else
                {
                    grades.Add(0);
                }
            }

            return grades;
        }

        public double? CalculateAverage(List<double> grades)
        {
            if (grades == null || grades.Count == 0)
            {
                return null;
            }

            return grades.Average();
        }

        public bool? VerifyResult(double? average)
        {
            if (average == null || average < 0)
            {
                return null;
            }

            return average >= 7.0;
        }

        public void CalculateDifference(List<double> grades, double average)
        {
            foreach (double grade in grades)
            {
                double difference = grade - average;

                if (grade == average)
                {
                    Console.WriteLine($"Grade {grade} is exactly the average.");
                }
                else if (grade > average)
                {
                    Console.WriteLine($"Grade {grade} is {difference} point(s) above the average.");
                }
                else
                {
                    Console.WriteLine($"Grade {grade} is {difference} point(s) below the average.");
                }
            }
        }

        public double? CalculateWeightedAverage(List<double> grades)
        {
            if (grades == null || grades.Count == 0)
            {
                return null;
            }

            List<double> weights = new List<double>();
            double sumOfWeights = 0;
            double weightedSum = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine($"Enter the weight for grade {grades[i]}:");
                if (double.TryParse(Console.ReadLine(), out double weight))
                {
                    weights.Add(weight);
                    sumOfWeights += weight;
                    weightedSum += grades[i] * weight;
                }
                else
                {
                    weights.Add(1);
                    sumOfWeights += 1;
                    weightedSum += grades[i] * 1;
                }
            }

            if (sumOfWeights == 0)
            {
                return null;
            }

            return weightedSum / sumOfWeights;
        }
    }
}
