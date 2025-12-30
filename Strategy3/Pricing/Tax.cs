using DesignPatterns.Strategy3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy3.Pricing
{
    public class Tax : IPricing
    {
        public void CalculatePrice()
        {
            Console.WriteLine("Tax calculate price");
        }
    }
}
