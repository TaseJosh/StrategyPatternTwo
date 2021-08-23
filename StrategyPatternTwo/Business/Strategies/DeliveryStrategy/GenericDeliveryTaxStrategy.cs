namespace StrategyPatternTwo
{
    public class GenericDeliveryTaxStrategy : IDeliveryTaxStrategy
    {
        public decimal GetChargeFor(Order order)
        {
            return order.TotalCost * 1.10m;
        }
    }
}
