namespace PizzeriaLibrary.Entities
{
    public class PizzaOrder
    {
        public string BasePizza { get; set; }
        public string Impasto { get; set; }
        public List<string> Ingredients { get; set; }

        public override string? ToString()
        {
            return $"{Impasto} {BasePizza} {string.Join(", ", Ingredients)}";
        }
    }
}
