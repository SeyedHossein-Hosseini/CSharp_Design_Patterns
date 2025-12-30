using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy2
{
    public class SeasonalDiscountStrategy : ICalculateDiscount
    {
        public decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.8m;
        }
    }
}
