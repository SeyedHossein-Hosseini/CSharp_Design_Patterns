using DesignPatterns.Strategy3.Notification;
using DesignPatterns.Strategy3.Payment;
using DesignPatterns.Strategy3.Pricing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy3
{
    public static class MainStrategy3
    {
        public static void Main()
        {
            var orderProcessor = new OrderProcessor();
            orderProcessor.SaveOrder(new Tax(), new Cash(), new SMS());
        }
    }
}
