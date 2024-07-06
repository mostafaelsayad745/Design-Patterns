using System.Threading.Channels;

namespace AbstractFactory
{
   /// <summary>
   /// Abstract factory class
   /// </summary>
   public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostService CreateShippingCostService();
    }

    /// <summary>
    /// Abstract Product
    /// </summary>
    public interface IDiscountService
    {
        public int DiscountPrecentage { get; }
    }

    /// <summary>
    /// concrete product
    /// </summary>

    public class FranceDiscountService : IDiscountService
    {
       public int DiscountPrecentage => 10;
    }

    /// <summary>
    /// concrete product
    /// </summary>

    public class GermanyDiscountService : IDiscountService
    {
        public int DiscountPrecentage => 15;
    }

    /// <summary>
    /// abstract product
    /// </summary>
    public interface IShippingCostService
    {
        public decimal ShippingCost { get; }
    }

    /// <summary>
    /// concrete product
    /// </summary>
    
    public class FranceShippingCostService : IShippingCostService
    {
        public decimal ShippingCost => 10;
    }

    /// <summary>
    /// concrete product
    /// </summary>
    
    public class GermanyShippingCostService : IShippingCostService
    {
        public decimal ShippingCost => 15;
    }

    /// <summary>
    /// concrete factory
    /// </summary>
    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }
        public IShippingCostService CreateShippingCostService()
        {
            return new FranceShippingCostService();
        }
    }
    /// <summary>
    /// concrete factory
    /// </summary>
    public class GermanyShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new GermanyDiscountService();
        }
        public IShippingCostService CreateShippingCostService()
        {
            return new GermanyShippingCostService();
        }
    }
    /// <summary>
    /// Client
    /// </summary>
    public class  ShoppingCart 
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostService _shippingCostService;
        private int _orderCosts;
        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostService = factory.CreateShippingCostService();
            _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total Costs " +
                $"{_orderCosts - (_orderCosts / 100 * _discountService.DiscountPrecentage) + _shippingCostService.ShippingCost}");
        }

    }

}
