using Facade;

Console.Title = "Facade";

DiscountFacade discountFacade = new DiscountFacade();

Console.WriteLine($"Discount nercenta e for customer with id 1: {discountFacade.CalculateDiscountPercentage(1)}");
Console.WriteLine($"Discount nercenta e for customer with id 10: {discountFacade.CalculateDiscountPercentage(10)}");