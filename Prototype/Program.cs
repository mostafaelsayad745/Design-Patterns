using Prototype;

Console.Title = "Prototype";

var manger = new Manager("mostafa");
var mangerClone = (Manager)manger.Colne();
Console.WriteLine($"Mangager was colned {mangerClone.Name}");