namespace StrategyPatternTwo
{
    public interface IDeliveryTaxStrategy
    {
        public decimal GetChargeFor(Order order);
    }
}
