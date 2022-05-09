using PizzeriaLibrary.Entities;
using PizzeriaLibrary.PriceList;

namespace PizzeriaLibrary.Chain
{
    public class IngredientPriceHandler : PriceHandler
    {
        public override decimal HandleRequest(PizzaOrder pizza)
        {
            decimal totPrice = 0M;

            PrezzoIngredienti prezzoIngredienti = new PrezzoIngredienti();

            if (pizza.Ingredients.Any())
            {
                foreach (var item in pizza.Ingredients)
                {
                    totPrice += prezzoIngredienti.GetPrice(item);
                }
            }
            
            //Console.WriteLine(totPrice);

            _next?.HandleRequest(pizza);
            return totPrice;
        }
    }
}
