using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitPass
{
    internal class TransitTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Running Transit System Unit Tests ---\n");

            TestBus_ChargeFare_NormalPass();
            TestBus_ChargeFare_StudentPass();
            TestBus_ChargeFare_BlockedPass();
            TestBus_ChargeFare_InsufficientBalance();
            TestBus_ChargeFare_WithMoney_Success();
            TestBus_ChargeFare_WithMoney_Insufficient();

            TestRechargeStation_CheckBalance_Success();
            TestRechargeStation_CheckBalance_Blocked();

            TestRechargeStation_Recharge_Success();
            TestRechargeStation_Recharge_BelowMinimum();
            TestRechargeStation_Recharge_BlockedPass();

            TestRechargeStation_BlockPass();

            Console.WriteLine("\n--- All tests completed ---");
            Console.ReadLine();
        }

        // --- BUS TESTS ---

        static void TestBus_ChargeFare_NormalPass()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 10.0, Blocked = false, Student = false };
            Bus bus = new Bus { TicketPrice = 4.40, AmountPassengers = 0 };

            // Act
            bus.ChargeFare(pass);

            // Assert
            Assert(5.60, pass.Balance, "Bus.ChargeFare (Normal) - Should deduct full ticket price");
            Assert(1, bus.AmountPassengers, "Bus.ChargeFare (Normal) - Should increment amountPassengers");
        }

        static void TestBus_ChargeFare_StudentPass()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 10.0, Blocked = false, Student = true };
            Bus bus = new Bus { TicketPrice = 4.40, AmountPassengers = 0 };

            // Act
            bus.ChargeFare(pass);

            // Assert
            Assert(7.80, pass.Balance, "Bus.ChargeFare (Student) - Should deduct exactly half the ticket price");
            Assert(1, bus.AmountPassengers, "Bus.ChargeFare (Student) - Should increment amountPassengers");
        }

        static void TestBus_ChargeFare_BlockedPass()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 10.0, Blocked = true };
            Bus bus = new Bus { TicketPrice = 4.40, AmountPassengers = 0 };

            // Act
            Console.Write("[Expected Console Msg: blocked transit pass] -> ");
            bus.ChargeFare(pass);

            // Assert
            Assert(10.0, pass.Balance, "Bus.ChargeFare (Blocked) - Balance must not change");
            Assert(0, bus.AmountPassengers, "Bus.ChargeFare (Blocked) - amountPassengers must remain 0");
        }

        static void TestBus_ChargeFare_InsufficientBalance()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 2.00, Blocked = false, Student = false };
            Bus bus = new Bus { TicketPrice = 4.40, AmountPassengers = 0 };

            // Act
            Console.Write("[Expected Console Msg: Insufficient balance...] -> ");
            bus.ChargeFare(pass);

            // Assert
            Assert(2.00, pass.Balance, "Bus.ChargeFare (Low Balance) - Balance must not change");
            Assert(0, bus.AmountPassengers, "Bus.ChargeFare (Low Balance) - amountPassengers must remain 0");
        }

        static void TestBus_ChargeFare_WithMoney_Success()
        {
            // Arrange
            Bus bus = new Bus { TicketPrice = 4.40, AmountPassengers = 0 };

            // Act
            bus.ChargeFare(5.00);

            // Assert
            Assert(1, bus.AmountPassengers, "Bus.ChargeFare(Money) - Should increment amountPassengers when money >= ticketPrice");
        }

        static void TestBus_ChargeFare_WithMoney_Insufficient()
        {
            // Arrange
            Bus bus = new Bus { TicketPrice = 4.40, AmountPassengers = 0 };

            // Act
            Console.Write("[Expected Console Msg: Insufficient money...] -> ");
            bus.ChargeFare(2.00);

            // Assert
            Assert(0, bus.AmountPassengers, "Bus.ChargeFare(Money) - Should not increment if money is insufficient");
        }

        // --- RECHARGE STATION TESTS ---

        static void TestRechargeStation_CheckBalance_Success()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 15.50, Blocked = false };
            RechargeStation station = new RechargeStation { ConsultationCount = 0 };

            // Act
            double returnedBalance = station.CheckBalance(pass);

            // Assert
            Assert(15.50, returnedBalance, "Station.CheckBalance (Success) - Should return correct balance");
            Assert(1, station.ConsultationCount, "Station.CheckBalance (Success) - Should increment consultationCount");
        }

        static void TestRechargeStation_CheckBalance_Blocked()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 15.50, Blocked = true };
            RechargeStation station = new RechargeStation { ConsultationCount = 0 };

            // Act
            Console.Write("[Expected Console Msg: blocked transit pass] -> ");
            double returnedBalance = station.CheckBalance(pass);

            // Assert
            Assert(0.0, returnedBalance, "Station.CheckBalance (Blocked) - Should return 0");
            Assert(0, station.ConsultationCount, "Station.CheckBalance (Blocked) - Should NOT increment consultationCount");
        }

        static void TestRechargeStation_Recharge_Success()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 10.0, Blocked = false };
            RechargeStation station = new RechargeStation { RechargeCount = 0 };

            // Act
            station.Recharge(pass, 20.0);

            // Assert
            Assert(30.0, pass.Balance, "Station.Recharge (Success) - Should add amount to balance");
            Assert(1, station.RechargeCount, "Station.Recharge (Success) - Should increment rechargeCount");
        }

        static void TestRechargeStation_Recharge_BelowMinimum()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 10.0, Blocked = false };
            RechargeStation station = new RechargeStation { RechargeCount = 0 };

            // Act
            Console.Write("[Expected Console Msg: Minimum recharge value not reached] -> ");
            station.Recharge(pass, 3.0);

            // Assert
            Assert(10.0, pass.Balance, "Station.Recharge (Below Min) - Should not alter balance");
            Assert(0, station.RechargeCount, "Station.Recharge (Below Min) - Should not increment rechargeCount");
        }

        static void TestRechargeStation_Recharge_BlockedPass()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 10.0, Blocked = true };
            RechargeStation station = new RechargeStation { RechargeCount = 0 };

            // Act
            Console.Write("[Expected Console Msg: blocked transit pass] -> ");
            station.Recharge(pass, 10.0);

            // Assert
            Assert(10.0, pass.Balance, "Station.Recharge (Blocked) - Should not alter balance");
            Assert(0, station.RechargeCount, "Station.Recharge (Blocked) - Should not increment rechargeCount");
        }

        static void TestRechargeStation_BlockPass()
        {
            // Arrange
            TransitPass pass = new TransitPass { Balance = 10.0, Blocked = false };
            RechargeStation station = new RechargeStation();

            // Act
            station.Block(pass);

            // Assert
            if (pass.Blocked == true)
                Console.WriteLine("[PASS] Station.Block - Should set pass to blocked");
            else
                Console.WriteLine("[FAIL] Station.Block - Should set pass to blocked -> Expected: True, Actual: False");
        }

        // --- HELPER METHOD ---

        static void Assert(double expected, double actual, string testName)
        {
            if (Math.Abs(expected - actual) < 0.001)
                Console.WriteLine($"[PASS] {testName}");
            else
                Console.WriteLine($"[FAIL] {testName} -> Expected: {expected}, Actual: {actual}");
        }
    }
}
