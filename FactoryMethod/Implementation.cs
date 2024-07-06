namespace FactoryMethod
{
    /// <summary>
    /// product
    /// </summary>
    public abstract class  DiscountService
    {
        public abstract int DiscountPrectange { get; }

        public override string ToString() => GetType().Name;
    }
    /// <summary>
    /// Concrete product
    /// </summary>

    public class  CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override int DiscountPrectange
        {
            get
            {
                switch(_countryIdentifier)
                {
                    case "BE":
                        return 20;
                    default:
                        return 10;
                }
            }
        }
    }
    /// <summary>
    /// Concrete product
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;

        public CodeDiscountService(Guid code)
        {
            _code = code;
        }

        public override int DiscountPrectange
        {
            get
            {
                return 15;
            }
        }
    }
    /// <summary>
    /// Creator
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
    /// <summary>
    /// Concrete Creator
    /// </summary>

    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryDiscount;

        public CountryDiscountFactory(string countryDiscount)
        {
            _countryDiscount = countryDiscount;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryDiscount);
        }
    }
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _discountCode;

        public CodeDiscountFactory(Guid discountCode)
        {
            _discountCode = discountCode;
        }
        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_discountCode);
        }
    }
}
