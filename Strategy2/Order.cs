using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy2
{
    public class Order
    {
        private decimal _amount;

        public Order(decimal amount)
        {
            _amount = amount;
        }

        public decimal CalculateDiscount(ICalculateDiscount calculateDiscount)
        {
            return calculateDiscount.CalculateDiscount(_amount);
        }

    }
}
