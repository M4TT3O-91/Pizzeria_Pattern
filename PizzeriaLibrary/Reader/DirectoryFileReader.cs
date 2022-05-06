using PizzeriaLibrary.Entities;

namespace PizzeriaLibrary.Reader
{
    public static class DirectoryFileReader
    {
        public static IEnumerable<List<PizzaOrder>> ReadAllFile(string path)
        {
            var orderReader = new OrderFileReader();
            var dir = Directory.GetFiles(path);
            foreach (var file in dir)
            {
                var order = orderReader.ReadOrder(file);

                yield return order.ToList<PizzaOrder>();
            }
        }
    }
}
