using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public static class TemplateMethodMain
    {
        public static void Main()
        {
            var onlineOrder = new OnlineOrder();

            onlineOrder.Items.Add(new OrderItem
            {
                Name = "Laptop",
                Price = 1000,
                Quantity = 2
            });

            onlineOrder.CompleteOrder();
        }
    }
}
