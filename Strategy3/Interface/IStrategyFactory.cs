using DesignPatterns.Strategy3.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy3.Interface
{
    public interface IStrategyFactory
    {
        IPricing CreatePricing(PricingType type);
        IPayment CreatePayment(PaymentType type);
        INotification CreateNotification(NotificationType notification);
    }
}
