using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();

            p.MyClickEvent += Subscriber.Respond;

            p.Notification();

            Console.ReadKey();
        }
    }
}
