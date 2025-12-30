using DesignPatterns.Strategy3.Enum;
using DesignPatterns.Strategy3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy3
{
    internal class StrategyFactory : IStrategyFactory
    {
        public INotification CreateNotification(NotificationType notification)
        {
            throw new NotImplementedException();
        }

        public IPayment CreatePayment(PaymentType type)
        {
            throw new NotImplementedException();
        }

        public IPricing CreatePricing(PricingType type)
        {
            throw new NotImplementedException();
        }
    }
}
