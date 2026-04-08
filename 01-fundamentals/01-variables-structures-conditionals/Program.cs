using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_variaveis_estruturas_condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Console.WriteLine();
            Exercise2();
            Console.WriteLine();
            Exercise3();
            Console.WriteLine();
            Exercise4();
        }

        static void Exercise1() {
            int childrenUnder4 = 1;
            int childrenUnder17 = 1;
            int childrenUnder19 = 1;

            int totalChildren = childrenUnder4 + childrenUnder17 + childrenUnder19;
            double totalBenefit = (childrenUnder4 * 25.12) + (childrenUnder17 * 15.88) + (childrenUnder19 * 12.44);

            Console.WriteLine("Exercise 1:");
            Console.WriteLine($"You have a total of {totalChildren} children and will receive R${totalBenefit} in benefits");
        }

        static void Exercise2() {
            int warmupMinutes = 15;
            int cardioMinutes = 20;
            int liftingMinutes = 40;


            int totalWorkoutMinutes = warmupMinutes + cardioMinutes + liftingMinutes;
            int totalCaloriesBurned = (warmupMinutes * 12) + (cardioMinutes * 20) + (liftingMinutes * 25);

            Console.WriteLine("Exercise 2:");
            Console.WriteLine($"Hello, Jorge. You did a total of {totalWorkoutMinutes} minutes workout and burned around {totalCaloriesBurned} calories");
        }

        static void Exercise3()
        {
            double productPrice = 15.99;
            int quantitySold = 3;
            double totalPaidByCustomer = 63.0;

            double totalChange = totalPaidByCustomer - (productPrice * quantitySold);

            Console.WriteLine("Exercise 3:");
            Console.WriteLine($"Your change is R${totalChange}");
        }

        static void Exercise4()
        {
            string name = "Matheus";
            double score1 = 7.7;
            double score2 = 8.6;
            double avg = (score1 + score2) / 2;

            Console.WriteLine("Exercise 4:");
            Console.WriteLine($"Hello, ${name}. Your average score was {avg}");
        }
    }
}
