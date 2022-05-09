namespace PizzeriaLibrary.Entities
{
    public class PizzaBuilder
    {
        private PizzaOrder _pizza;
        private PizzaBuilder()
        {
            _pizza = new PizzaOrder();
        }

        public static PizzaBuilder Create()
        {
            return new PizzaBuilder();
        }

        public PizzaBuilder WithPizzaType(string pizzaType)
        {
            _pizza.BasePizza = pizzaType;
            return this;
        }
        public PizzaBuilder WithImpastoType(string impasto)
        {
            _pizza.Impasto = impasto;
            return this;
        }

        public PizzaBuilder WithIngredients(string ingredientsList)
        {
            if(ingredientsList?.Any() != true)
            {
                _pizza.Ingredients = new List<string>();
            }

            _pizza.Ingredients.Add(ingredientsList);
            return this;
        }

        public PizzaOrder Build()
        {
            return _pizza;
        }


    }
}
