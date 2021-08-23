namespace StrategyPatternTwo
{
    public class Item
    {
        private  string _foodName;
        private  decimal _cost;

        public Item(string foodName, decimal cost)
        {
            FoodName = foodName;
            Cost = cost;
        }

        public string FoodName { get { return _foodName; } set { _foodName = value; } }

        public decimal Cost { get { return _cost; } set { _cost = value; } }
    }
}