namespace StrategyPatternTwo
{
    public class LiverpoolDeliveryTaxStrategy : IDeliveryTaxStrategy
    {
        public decimal GetChargeFor(Order order)
        {
            var destination = order.DeliveryDetails.City.ToLowerInvariant();
            if (destination == "liverpool")
            {
                return order.TotalCost * 1.26m;
            }
            return 0;
        }
    }
}
