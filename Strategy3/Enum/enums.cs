using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy3.Enum
{
    public enum PaymentType
    {
        Cash,
        Gateway,
        Wallet
    }

    public enum PricingType
    {
        Tax,
        NoTax
    }

    public enum NotificationType
    {
        SMS,
        Email,
        Push
    }
}
