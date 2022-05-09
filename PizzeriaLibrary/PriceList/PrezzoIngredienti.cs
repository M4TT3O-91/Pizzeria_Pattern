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
            if (!_priceList.ContainsKey(item))
                return 0;
            return _priceList[item];
        }
    }
}
