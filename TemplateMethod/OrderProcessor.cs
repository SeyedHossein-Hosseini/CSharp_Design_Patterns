using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{

    public abstract class OrderProcessor
    {

        public List<OrderItem> Items = new();
        protected decimal TotalPrice;
        protected Guid OrderId;


        public void CompleteOrder()
        {
            ValidateOrder();
            CalculatePrice();
            ApplyDiscount();
            SaveOrder();
            SendNotification();
        }

        protected virtual void ValidateOrder() 
        {
            if (Items.Count == 0 || Items == null)
                throw new Exception("Order must have at least one item");
            Console.WriteLine("Order Validated ...");
        }
        protected virtual void CalculatePrice() 
        {
            TotalPrice = Items.Sum(i =>  i.Price * i.Quantity);
            Console.WriteLine($"Total Price without discount: {TotalPrice}");
        }
        protected abstract void ApplyDiscount();

        protected virtual void SaveOrder() 
        {
            OrderId = Guid.NewGuid();
            Console.WriteLine($"Order saved with Id: {OrderId} | Price: {TotalPrice}");
        }
        protected abstract void SendNotification();

    }
}
