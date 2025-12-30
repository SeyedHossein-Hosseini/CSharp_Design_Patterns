using DesignPatterns.Strategy3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy3
{
    public class OrderProcessor
    {
        public void SaveOrder(IPricing pricing, IPayment payment, INotification notification)
        {
            pricing.CalculatePrice();
            payment.pay();
            notification.SendNotification();
        }
    }
}
