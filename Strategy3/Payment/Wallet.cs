using DesignPatterns.Strategy3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy3.Payment
{
    public class Wallet : IPayment
    {
        public void pay()
        {
            Console.WriteLine("wallet payment");
        }
    }
}
