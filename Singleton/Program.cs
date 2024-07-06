using Singleton;

Console.Title = "Singleton";

var instance1 = Logger.Instacne;
var instance2  = Logger.Instacne;
if (instance1 == instance2 && instance2 == Logger.Instacne)
{
    Console.WriteLine("instances are the same");
}

instance1.Log($"message from {nameof(instance1)}");
instance2.Log($"message from {nameof(instance2)}");
Logger.Instacne.Log($"message from {nameof(Logger.Instacne)}");
Console.ReadLine();