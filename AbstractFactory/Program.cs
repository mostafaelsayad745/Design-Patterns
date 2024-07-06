using AbstractFactory;

Console.Title = "Abstract Factory";

var belgiumShoppingCartPurchaseFactory = new GermanyShoppingCartPurchaseFactory();
var ShoppingCartForBeligum = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
ShoppingCartForBeligum.CalculateCosts();

var FranceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var ShoppingCartForFrance = new ShoppingCart(FranceShoppingCartPurchaseFactory);
ShoppingCartForFrance.CalculateCosts();