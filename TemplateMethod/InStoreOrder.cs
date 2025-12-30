using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class InStoreOrder : OrderProcessor
    {
        protected override void ApplyDiscount()
        {
            Console.WriteLine("No Discount for in-store purchases");
        }

        protected override void SendNotification()
        {
            Console.WriteLine($"Receipt printed for in-store order: {OrderId}");
        }
    }
}
