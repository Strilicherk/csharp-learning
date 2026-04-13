using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages
{
    internal class PackageTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n--- Running Package Tests ---");

            // Arrange
            Package pkg = new Package();
            pkg.size = "M";
            pkg.distance = 100;
            pkg.productValue = 100.00;

            // Act & Assert
            // Size M (3% of 100 = 3.00) + Distance 100km (5.00) = 8.00 shipping
            Assert(8.00, pkg.CalculateShipping(), "CalculateShipping - Medium size, 100km");

            // Total = 100.00 (product) + 8.00 (shipping)
            Assert(108.00, pkg.TotalPackageValue(), "TotalPackageValue - Before discount");

            pkg.ApplyDiscountCoupon(20);
            // New product value = 80.00. 
            // New Shipping = Size M (3% of 80 = 2.40) + Distance 100km (5.00) = 7.40
            Assert(80.00, pkg.productValue, "ApplyDiscountCoupon - 20% off 100.00 should be 80.00");
            Assert(87.40, pkg.TotalPackageValue(), "TotalPackageValue - After discount (80.00 + 7.40)");
        }

        static void Assert(double expected, double actual, string testName)
        {
            // Floating point comparison with a small tolerance is best practice
            if (Math.Abs(expected - actual) < 0.001)
                Console.WriteLine($"[PASS] {testName}");
            else
                Console.WriteLine($"[FAIL] {testName} -> Expected: {expected}, Actual: {actual}");
        }
    }
}
