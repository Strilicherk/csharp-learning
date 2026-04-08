namespace ExerciseArrays
{
    internal class ExerciseArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sum ---");
            Console.WriteLine(Sum([1,3,4,10])); // Expected: 18

            Console.WriteLine("--- Calculate Average ---");
            Console.WriteLine(CalculateAverage([8,6.8,7.3,2.5,4.2,9])); // Expected: 6.3

            Console.WriteLine("--- FindLargestNumber ---");
            Console.WriteLine(FindLargestNumber([5, 15, 8, 42, 3])); // Expected: 42

            Console.WriteLine("\n--- CalculateDecimal ---");
            Console.WriteLine(CalculateDecimal([1, 0, 1, 0])); // Expected: 10

            Console.WriteLine("\n--- Reverse ---");
            Console.WriteLine(Reverse(['c', 's', 'h', 'a', 'r', 'p'])); // Expected: prahsc 

            Console.WriteLine("\n--- Merge ---");
            Console.WriteLine(Merge([1, 2, 5, 8], [3, 4, 6])); // Expected: 1, 2, 3, 4, 5, 6, 8

            Console.WriteLine("\n--- TwoSum ---");
            Console.WriteLine(TwoSum([2, 7, 11, 15], 9)); // Expected: 0, 1
        }

        static int Sum(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            return total;
        }

        static double CalculateAverage(double[] grades)
        {
            double total = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }
            return total / grades.Length;
        }

        static int FindLargestNumber(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int CalculateDecimal(int[] binary)
        {
            int total = 0;
            int power = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == 1)
                {
                    total += (int)Math.Pow(2.0, power);
                }
                power++;
            }
            return total;
        }

        static char[] Reverse(char[] array)
        {
            char[] newArray = new char[array.Length];
            int newIndex = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[newIndex] = array[i];
                newIndex++;
            }
            return newArray;
        }

        static int[] Merge(int[] array1, int[] array2)
        {
            int[] newArray = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] <= array2[j])
                {
                    newArray[k] = array1[i];
                    i++;
                }
                else
                {
                    newArray[k] = array2[j];
                    j++;
                }
                k++;
            }

            while (i < array1.Length)
            {
                newArray[k] = array1[i];
                i++;
                k++;
            }

            while (j < array2.Length)
            {
                newArray[k] = array2[j];
                j++;
                k++;
            }

            return newArray;
        }

        static int[] TwoSum(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }
    }
}
