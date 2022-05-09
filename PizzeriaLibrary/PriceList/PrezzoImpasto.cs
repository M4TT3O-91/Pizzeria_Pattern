﻿namespace PizzeriaLibrary.PriceList
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
            return _priceList[item];
        }
    }
}