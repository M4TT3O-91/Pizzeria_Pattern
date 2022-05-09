using PizzeriaLibrary.Entities;
using PizzeriaLibrary.PriceList;

namespace PizzeriaLibrary.Chain
{
    public class BasePizzaPriceHandler : PriceHandler
    {
        public override decimal HandleRequest(PizzaOrder pizza)
        {
            PrezzoBasePizza prezzoBase = new PrezzoBasePizza();
            _next?.HandleRequest(pizza);
            return prezzoBase.GetPrice(pizza.BasePizza);
            //Console.WriteLine(prezzoBase.GetPrice(pizza.BasePizza));

            
        }
    }
}
