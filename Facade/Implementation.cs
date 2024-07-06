namespace Facade
{
    public class OrderService
    {
        public bool HasEnoughtOrders(int customerId)
        {
            return (customerId > 5);
        }
    }

    public class CustomerDiscountBaseService
    {
        public double CalculateDiscountBase(int customerId)
        {
            return (customerId > 8) ? 10 : 20;
        }
    }

    public class DayOfTheWeekFActorService
    {
        public double CalculateDayOfTheWeekFactor()
        {
            switch (DateTime.UtcNow.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return 0.8;

                case DayOfWeek.Saturday:

                default:
                    return 1.2;
            }
        }
    }

    public class DiscountFacade
    {
        private readonly OrderService _orderService = new();
        private readonly CustomerDiscountBaseService _customerDiscountBaseService = new();
        private readonly DayOfTheWeekFActorService _dayOfTheWeekFActorService = new();


        public double CalculateDiscountPercentage ( int customerId)
        {
            if (!_orderService.HasEnoughtOrders(customerId))
            {
                return 0;
            }
            return _customerDiscountBaseService.CalculateDiscountBase(customerId)
                *_dayOfTheWeekFActorService.CalculateDayOfTheWeekFactor();
        }
    }
}
