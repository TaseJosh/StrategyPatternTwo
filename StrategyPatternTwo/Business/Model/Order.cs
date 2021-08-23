using System.Collections.Generic;

namespace StrategyPatternTwo
{
    public class Order
    {

        public Dictionary<Item, decimal> AddItem = new Dictionary<Item, decimal>();
        public DeliveryDetails DeliveryDetails { get; set; }

        public IDeliveryTaxStrategy DeliveryTaxStrategy { get; set; }

        public decimal TotalCost { get; set; }
        
        public decimal DeliveryTax()
        {
            if (DeliveryTaxStrategy == null)
            {
                return 0m;
            }
            return DeliveryTaxStrategy.GetChargeFor(this);
        }
        public decimal Total()
        {
            TotalCost = 0m;
            foreach (KeyValuePair<Item, decimal> entry in AddItem)
            {
                TotalCost = TotalCost + entry.Key.Cost;
            }


            return TotalCost;
        }

    }
}