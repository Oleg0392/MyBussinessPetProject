namespace MyBussinessWeb.Models
{
    public class OrderItem(Guid orderId, Guid productId, int quantity, double price)
    {
        public readonly Guid OrderId = orderId;
        public readonly Guid ProductId = productId;
        public readonly int Quantity = quantity;
        public readonly double Price = price;
    }
}
