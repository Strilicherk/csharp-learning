using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class CompanyTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n--- Running Company Tests ---");

            // Arrange
            Employee emp = new Employee();
            emp.name = "William";
            emp.role = "Systems Analyst";
            emp.salary = 4400.00;

            // Act & Assert
            // 4400 / 220 = 20.00 per hour
            Assert(20.00, emp.CalculateHourlyRate(), "CalculateHourlyRate - 4400 salary is 20/hr");

            // Overtime: 10 hours at 50% premium
            // Standard hour: 20.00. Premium hour: 30.00. Total = 10 * 30.00 = 300.00
            Assert(300.00, emp.CalculateOvertime(10, 50), "CalculateOvertime - 10h at 50% premium");

            emp.AdjustSalary(10);
            // 10% of 4400 is 440. New salary = 4840.00
            Assert(4840.00, emp.salary, "AdjustSalary - 10% increase");
        }

        static void Assert(double expected, double actual, string testName)
        {
            if (Math.Abs(expected - actual) < 0.001)
                Console.WriteLine($"[PASS] {testName}");
            else
                Console.WriteLine($"[FAIL] {testName} -> Expected: {expected}, Actual: {actual}");
        }
    }
}
