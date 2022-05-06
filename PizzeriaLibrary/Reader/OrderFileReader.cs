using PizzeriaLibrary.Entities;

namespace PizzeriaLibrary
{
    public class OrderFileReader
    {
        public IEnumerable<PizzaOrder> ReadOrder(string path)
        {
            using (var stream = new StreamReader(path))
            {
                var header = "BasePizza;Impasto;Aggiunte";

                var firstLine = stream.ReadLine();

                if (!firstLine.Equals(header))
                    throw new Exception("File non conforme!");

                while (!stream.EndOfStream)
                {
                    var row = stream.ReadLine();
                    var splitted = row.Split(";");

                    yield return new PizzaOrder
                    {
                        BasePizza = splitted[0].ToLower(),
                        Impasto = splitted[1].ToLower(),
                        Ingredients = splitted[2].ToLower().Split(",").ToList(),
                    };
                }

            }
        }
    }
}