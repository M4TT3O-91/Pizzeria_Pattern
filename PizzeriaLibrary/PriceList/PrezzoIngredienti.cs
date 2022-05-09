namespace PizzeriaLibrary.PriceList
{
    public class PrezzoIngredienti : IPriceHandler
    {
        private Dictionary<string, decimal> _priceList;

        public PrezzoIngredienti()
        {
            _priceList = new Dictionary<string, decimal>()
            {
                {"prosicutto cotto", 1M},
                {"funghi", 2M},
                {"crudo", 3M}
            };
        }

        public decimal GetPrice(string item)
        {
            if (_priceList.TryGetValue(item, out decimal price))
                return price;
            return 0;
        }
    }
}
