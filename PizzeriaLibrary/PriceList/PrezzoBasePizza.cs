namespace PizzeriaLibrary.PriceList
{
    public class PrezzoBasePizza : IPriceHandler
    {
        private Dictionary<string, decimal> _priceList;

        public PrezzoBasePizza()
        {
            _priceList = new Dictionary<string, decimal>()
            {
                {"margherita", 5M},
                {"pepperoni", 7M},
                {"napoletana", 3M}
            };
        }
        public decimal GetPrice(string item)
        {
            return _priceList[item];
        }
    }
}
