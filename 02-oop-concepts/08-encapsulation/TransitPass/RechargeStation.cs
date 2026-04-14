using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitPass
{
    internal class RechargeStation
    {
        public int ConsultationCount { get; set; }
        public int RechargeCount { get; set; }

        public double CheckBalance(TransitPass transitPass)
        {
            if (transitPass.Blocked)
            {
                Console.WriteLine("blocked transit pass");
                return 0;
            } else
            {
                ConsultationCount++;
                return transitPass.Balance;
            }
        }

        public void Recharge(TransitPass transitPass, double amount)
        {
            if (amount < 5)
            {
                Console.WriteLine("Minimum recharge value not reached");    
            } else if (transitPass.Blocked)
            {
                Console.WriteLine("blocked transit pass");
            } else
            {
                transitPass.Balance += amount;
                RechargeCount++;
            }
        }

        public void Block(TransitPass transitPass)
        {
            transitPass.Blocked = true;
        }
    }
}
