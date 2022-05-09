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
        public decimal GetPrice(List<string> ingredients)
        {
            decimal price = 0;
            foreach (var item in ingredients)
            {
                price += _priceList[item];
            }
            return price;
        }
    }
}
