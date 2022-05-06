using PizzeriaLibrary.Entities;

namespace PizzeriaLibrary.PriceList
{
    public class PrezzoImpasto
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

        public decimal GetPrice(PizzaOrder pizza)
        {
            return _priceList[pizza.BasePizza];
        }
    }
}

/*
 * var components = impastoList = new Dictionary<string, decimal>()
 * {
 *  {"normale", 0M},
 *  {"integrale", 1M}
 * }