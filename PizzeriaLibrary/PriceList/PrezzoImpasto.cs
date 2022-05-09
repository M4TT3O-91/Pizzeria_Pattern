namespace PizzeriaLibrary.PriceList
{
    public class PrezzoImpasto : IPriceHandler
    {
        private Dictionary<string, decimal> _priceList;

        public PrezzoImpasto()
        {
            _priceList = new Dictionary<string, decimal>()
            {
                {"normale", 0M},
                {"integrale", 1M}
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