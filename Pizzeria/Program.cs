using PizzeriaLibrary;
using PizzeriaLibrary.Entities;
//var ingred = new List<string>();

//ingred.Add("prosciutto");
//ingred.Add("funghi");
//ingred.Add("olive");

//var pizza = new PizzaOrder
//{
//    BasePizza = "margherita",
//    Impasto = "Integrale",
//    Ingredients = ingred,
//};

//Console.WriteLine(pizza);

var fileReader = new OrderFileReader();


var dir = Directory.GetFiles(Constants.DIR_PATH);
foreach(var file in dir)
{
    var order = fileReader.ReadOrder(file);
    order.ToList().ForEach(x => Console.WriteLine(x));
}
Console.WriteLine(dir);



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