using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitPass
{
    internal class Bus
    {
        public int AmountPassengers { get; set; }
        public double TicketPrice { get; set; }

        public void ChargeFare(TransitPass transitPass)
        {
            if (transitPass.Blocked)
            {
                Console.WriteLine("Blocked transit pass.");
            } else if (transitPass.Balance < TicketPrice)
            {
                Console.WriteLine("Insufficient balance to perform the operation.");
            } else
            {
                if (transitPass.Student)
                {
                    transitPass.Balance -= TicketPrice / 2;
                } else
                {
                    transitPass.Balance -= TicketPrice;
                }

                AmountPassengers++;
            }
            return;
        }

        public void ChargeFare(double money)
        {
            if (money < TicketPrice)
            {
                Console.WriteLine("Insufficient money to perform the operation");
            } else
            {
                AmountPassengers++;
            }
            return;
        }
    }
}
