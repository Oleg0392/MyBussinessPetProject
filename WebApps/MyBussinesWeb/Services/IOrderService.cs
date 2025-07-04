﻿using MyBussinessWeb.Models;
using Refit;

namespace MyBussinessWeb.Services
{
    public interface IOrderService
    {
        [Get("/ordering-service/orders?pageIndex={pageIndex}&pageSize={pageSize}\"")]
        Task<GetOrdersResponse> GetOrders(int? pageIndex = 1, int? pageSize = 10);

        [Get("/ordering-service/orders/{orderName}")]
        Task<GetOrdersByNameResponse> GetOrdersByName(string orderName);

        [Get("/ordering-service/orders/customer/{customerId}")]
        Task<GetOrdersByCustomerResponse> GetOrdersByCustomer(Guid customerId);
    }
}
