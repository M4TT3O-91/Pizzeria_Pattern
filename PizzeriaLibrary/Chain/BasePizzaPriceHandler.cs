using PizzeriaLibrary.Entities;
using PizzeriaLibrary.PriceList;

namespace PizzeriaLibrary.Chain
{
    public class BasePizzaPriceHandler : PriceHandler
    {
        public override void HandleRequest(PizzaOrder pizza)
        {
            PrezzoBasePizza prezzoBase = new PrezzoBasePizza();
            Console.WriteLine(prezzoBase.GetPrice(pizza.BasePizza));

            _next?.HandleRequest(pizza);
        }
    }
}
