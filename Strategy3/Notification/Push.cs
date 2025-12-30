using DesignPatterns.Strategy3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy3.Notification
{
    public class Push : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Push notification sent");
        }
    }
}
