using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy2
{
    public static class MainStrategy2
    {
        public static void Main()
        {
            var order = new Order(1000_000);
            var PriceWithDiscount = order.CalculateDiscount(new SeasonalDiscountStrategy());
            Console.WriteLine(PriceWithDiscount);
        }
    }
}
