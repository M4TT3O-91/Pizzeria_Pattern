using PizzeriaLibrary.Entities;
using PizzeriaLibrary.PriceList;

namespace PizzeriaLibrary.Chain
{
    public class ImpastoPriceHandler : PriceHandler
    {
        public override decimal HandleRequest(PizzaOrder pizza)
        {
            PrezzoImpasto prezzoBase = new PrezzoImpasto();
            //Console.WriteLine(prezzoBase.GetPrice(pizza.Impasto));

            _next?.HandleRequest(pizza);
            return prezzoBase.GetPrice(pizza.Impasto);
        }
    }
}
