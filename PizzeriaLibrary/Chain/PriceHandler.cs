using PizzeriaLibrary.Entities;

namespace PizzeriaLibrary.Chain
{
    public abstract class PriceHandler
    {
        protected PriceHandler? _next;

        public void SetNext(PriceHandler nextHandler) { _next = nextHandler; }

        public abstract void HandleRequest(PizzaOrder pizza);
    }
}
