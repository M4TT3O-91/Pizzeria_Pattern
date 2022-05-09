using PizzeriaLibrary.Entities;
using PizzeriaLibrary.PriceList;

namespace PizzeriaLibrary.Chain
{
    public class IngredientPriceHandler : PriceHandler
    {
        public override void HandleRequest(PizzaOrder pizza)
        {
            decimal totPrice = 0M;

            PrezzoIngredienti prezzoIngredienti = new PrezzoIngredienti();

            Console.WriteLine(prezzoIngredienti.GetPrice[pizza.Ingredients]);

        }
    }
}
