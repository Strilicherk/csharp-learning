using Bakery;
using System;

namespace Bakery
{
    public class BakeryTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Running Bakery Tests ---");

            // Arrange
            Cake myCake = new Cake();
            myCake.flavor = "Chocolate";
            myCake.price = 50.00;
            myCake.quantitySold = 0;
            myCake.quantityInStock = 20;

            // Act & Assert
            myCake.SellCake(5);
            Assert(15, myCake.AvailableQuantity(), "SellCake - Should reduce stock to 15");
            Assert(5, myCake.quantitySold, "SellCake - Should increase sold to 5");
            Assert(250.00, myCake.TotalSold(), "TotalSold - 5 cakes at 50.00 should be 250.00");

            myCake.SellCake(-2); // Invalid negative amount
            Assert(15, myCake.AvailableQuantity(), "SellCake (Negative) - Stock should remain 15");

            myCake.SellCake(100); // Exceeds limit
            Assert(15, myCake.AvailableQuantity(), "SellCake (Exceeds) - Stock should remain 15");

            myCake.IncreaseStock(10);
            Assert(25, myCake.AvailableQuantity(), "IncreaseStock - Stock should become 25");
        }

        // A simple custom Assert method for Console testing
        static void Assert(double expected, double actual, string testName)
        {
            if (expected == actual)
                Console.WriteLine($"[PASS] {testName}");
            else
                Console.WriteLine($"[FAIL] {testName} -> Expected: {expected}, Actual: {actual}");
        }
    }
}