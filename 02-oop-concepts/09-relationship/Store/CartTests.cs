using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class CartTests
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Running Cart & Product Unit Tests ---\n");

            TestCart_AddAndGetQuantity();
            TestCart_ExistsByName();
            TestCart_GetQuantityByCategory();
            TestCart_GetByName();
            TestCart_GetTotalValue();
            TestCart_RemoveByName();
            TestCart_Clear();

            Console.WriteLine("\n--- All tests completed ---");
            Console.ReadLine();
        }

        static void TestCart_AddAndGetQuantity()
        {
            Cart cart = new Cart { Customer = "William" };
            cart.Add(new Product { Name = "Laptop", Category = "Electronics", Price = 2500.00 });
            cart.Add(new Product { Name = "Mouse", Category = "Electronics", Price = 150.00 });

            Assert(2, cart.GetQuantity(), "Cart.Add / GetQuantity - Should have 2 items");
        }

        static void TestCart_ExistsByName()
        {
            Cart cart = new Cart { Customer = "William" };
            cart.Add(new Product { Name = "Laptop", Category = "Electronics", Price = 2500.00 });

            Assert(true, cart.ExistsByName("lApToP"), "Cart.ExistsByName - Should find 'Laptop' ignoring case");
            Assert(false, cart.ExistsByName("Keyboard"), "Cart.ExistsByName - Should return false for non-existent item");
        }

        static void TestCart_GetQuantityByCategory()
        {
            Cart cart = new Cart { Customer = "William" };
            cart.Add(new Product { Name = "Laptop", Category = "Electronics", Price = 2500.00 });
            cart.Add(new Product { Name = "Mouse", Category = "Electronics", Price = 150.00 });
            cart.Add(new Product { Name = "Coffee", Category = "Food", Price = 20.00 });

            Assert(2, cart.GetQuantityByCategory("Electronics"), "Cart.GetQuantityByCategory - Should count 2 Electronics");
            Assert(1, cart.GetQuantityByCategory("Food"), "Cart.GetQuantityByCategory - Should count 1 Food");
            Assert(0, cart.GetQuantityByCategory("Clothing"), "Cart.GetQuantityByCategory - Should count 0 Clothing");
        }

        static void TestCart_GetByName()
        {
            Cart cart = new Cart { Customer = "William" };
            cart.Add(new Product { Name = "Coffee", Category = "Food", Price = 20.00 });

            Product foundProduct = cart.GetByName("cOfFeE");
            Assert(true, foundProduct != null && foundProduct.Name == "Coffee", "Cart.GetByName - Should return the correct product ignoring case");

            Product notFound = cart.GetByName("Water");
            Assert(true, notFound == null, "Cart.GetByName - Should return null if product does not exist");
        }

        static void TestCart_GetTotalValue()
        {
            Cart cart = new Cart { Customer = "William" };
            cart.Add(new Product { Name = "Laptop", Category = "Electronics", Price = 2500.00 });
            cart.Add(new Product { Name = "Mouse", Category = "Electronics", Price = 150.00 });
            cart.Add(new Product { Name = "Coffee", Category = "Food", Price = 20.00 });

            Assert(2670.00, cart.GetTotalValue(), "Cart.GetTotalValue - Should sum 2500.00 + 150.00 + 20.00 correctly");
        }

        static void TestCart_RemoveByName()
        {
            Cart cart = new Cart { Customer = "William" };
            cart.Add(new Product { Name = "Laptop", Category = "Electronics", Price = 2500.00 });
            cart.Add(new Product { Name = "Mouse", Category = "Electronics", Price = 150.00 });

            cart.RemoveByName("lApToP");

            Assert(1, cart.GetQuantity(), "Cart.RemoveByName - Should reduce quantity to 1");
            Assert(false, cart.ExistsByName("Laptop"), "Cart.RemoveByName - 'Laptop' should no longer exist in cart");
        }

        static void TestCart_Clear()
        {
            Cart cart = new Cart { Customer = "William" };
            cart.Add(new Product { Name = "Laptop", Category = "Electronics", Price = 2500.00 });
            cart.Add(new Product { Name = "Mouse", Category = "Electronics", Price = 150.00 });

            cart.Clear();

            Assert(0, cart.GetQuantity(), "Cart.Clear - Should reduce quantity to 0");
            Assert(0.0, cart.GetTotalValue(), "Cart.Clear - Total value should be 0.0");
        }

        // --- HELPER METHODS ---

        static void Assert(int expected, int actual, string testName)
        {
            if (expected == actual)
                Console.WriteLine($"[PASS] {testName}");
            else
                Console.WriteLine($"[FAIL] {testName} -> Expected: {expected}, Actual: {actual}");
        }

        static void Assert(double expected, double actual, string testName)
        {
            if (Math.Abs(expected - actual) < 0.001)
                Console.WriteLine($"[PASS] {testName}");
            else
                Console.WriteLine($"[FAIL] {testName} -> Expected: {expected}, Actual: {actual}");
        }

        static void Assert(bool expected, bool actual, string testName)
        {
            if (expected == actual)
                Console.WriteLine($"[PASS] {testName}");
            else
                Console.WriteLine($"[FAIL] {testName} -> Expected: {expected}, Actual: {actual}");
        }
    }
}
