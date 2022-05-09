using PizzeriaLibrary;
using PizzeriaLibrary.Chain;
using PizzeriaLibrary.Reader_Writer;
using System.Text;

int orderID = 1;

var basePizzaHandler = new BasePizzaPriceHandler();
var impastoPizzaHandler = new ImpastoPriceHandler();
var ingredientiHandler = new IngredientPriceHandler();

basePizzaHandler.SetNext(impastoPizzaHandler);
impastoPizzaHandler.SetNext(ingredientiHandler);

var orderPriceList = new List<Decimal>();

var fileReader = new OrderFileReader();
var fileWriter = new OrderFileWriter();
StringBuilder myStringBuilder = new StringBuilder();

try
{
    var dir = Directory.GetFiles(Constants.DIR_PATH);
    foreach (var file in dir)
    {
        var order = fileReader.ReadOrder(file).ToList();
        foreach (var pizza in order)
        {
            orderPriceList.Add(basePizzaHandler.HandleRequest(pizza));
        }

        var total = orderPriceList.Sum();
        myStringBuilder.AppendLine($"Ordine: {orderID++} Totale: {total}");

        Console.WriteLine($"Ordine: {orderID++} Totale: {total}");
        
    }
    fileWriter.WriteToFile(Constants.DIR_PATH,myStringBuilder.ToString());
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}


Console.ReadLine();

/*
 * var dir = Directory.GetFiles(path)
 * foreac( var item in dir)
 * {
 *      var lines = File.ReadAllLines(item)
 *      foreach(var line in lines)
 *      {
 *          var pizza comp = line.split(';');
 *          var tipoPizza = pizzaComp[0]
 *          var impasto = pizzaComp[1]
 *          var componenti = pizzaComp[2].split(",");
 *      }
 *  }
 */