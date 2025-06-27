namespace MyBussinessWeb.Models
{
    public record GetOrdersResponse(PaginatedResult<Order> Orders);
    public record GetOrdersByNameResponse(IEnumerable<Order> Orders);
    public record GetOrdersByCustomerResponse(IEnumerable<Order> Orders);
}