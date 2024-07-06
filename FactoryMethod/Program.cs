using FactoryMethod;

Console.Title = "Factory Method";
var factories = new List<DiscountFactory>()
{
    new CountryDiscountFactory("BE"),
    new CodeDiscountFactory(new Guid()),
};
foreach (var fact in factories)
{
    var discountService = fact.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPrectange}"+ 
        $" comming from {discountService}");
}
Console.ReadKey();
