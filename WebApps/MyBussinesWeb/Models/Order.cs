namespace MyBussinessWeb.Models
{
    public class Order(Guid Id,
        Guid CustomerId,
        string OrderName,
        Address ShippingAddress,
        Address BillingAddress,
        Payment Payment,
        OrderStatus Status,
        List<OrderItem> OrderItems)
    {
        public readonly Guid Id = Id;
        public readonly Guid CustomerId = CustomerId;
        public readonly string OrderName = OrderName;
        public readonly Address ShippingAddress = ShippingAddress;
        public readonly Address BillingAddress = BillingAddress;
        public readonly Payment Payment = Payment;
        public readonly OrderStatus Status = Status;
        public readonly List<OrderItem> OrderItems = OrderItems;
    }

    public enum OrderStatus
    {
        Draft = 1,
        Pending = 2,
        Completed = 3,
        Cancelled = 4
    }
}
