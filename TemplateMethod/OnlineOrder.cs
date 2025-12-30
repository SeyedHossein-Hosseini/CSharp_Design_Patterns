using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class OnlineOrder : OrderProcessor
    {

        private readonly decimal OnlineDiscountPercent = 0.10m;

        protected override void ApplyDiscount()
        {
            var discountValue  = TotalPrice * OnlineDiscountPercent;
            TotalPrice -= discountValue;

            Console.WriteLine($"Online discount applied: {discountValue}, totalPrice with discount: {TotalPrice}");
        }

        protected override void SendNotification()
        {
            Console.WriteLine($"SMS & Email sent for online order: {OrderId}");
        }
    }
}
