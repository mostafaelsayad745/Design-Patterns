using Strategy;

Console.Title = "Strategy";

var order = new Order("Mostafa Ahmed", "Order 1", 1000);
order.Export(new CSVExportService());
order.Export(new JsonExportService());