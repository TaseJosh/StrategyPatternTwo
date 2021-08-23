using System;

namespace StrategyPatternTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
               DeliveryDetails = new DeliveryDetails
               {
                   Name = "Erutase Akpobome",
                   City="Liverpool"
               }
            };

            order.AddItem.Add(new Item( "Milk",1.29m), 1);

            order.AddItem.Add(new Item("Bread", 1.07m), 1);

            order.AddItem.Add(new Item("Corn Flakes", 1.59m), 1);

            var destination = order.DeliveryDetails.City.ToLowerInvariant();

            if (destination=="liverpool")
            {
                order.DeliveryTaxStrategy = new LiverpoolDeliveryTaxStrategy();
            }
            else
            {
                order.DeliveryTaxStrategy = new GenericDeliveryTaxStrategy();
            }
            order.Total();

            Console.WriteLine(order.DeliveryTax());
        }
    }
}