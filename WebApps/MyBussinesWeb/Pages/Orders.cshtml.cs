using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBussinessWeb.Services;
using MyBussinessWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyBussinessWeb.Pages
{
    public class OrdersModel(IOrderService orderService, ILogger<OrdersModel> logger) : PageModel
    {
        public IEnumerable<Order> Orders { get; set; } = default!;
        
        public async Task<IActionResult> OnGetAsync()
        {
            // допустим что мы получили customerId для авторизованного пользователя
            var customerId = new Guid("58c49479-ec65-4de2-86e7-033c546291aa");

            var response = await orderService.GetOrdersByCustomer(customerId);
            Orders = response.Orders;

            return Page();
        }
    }
}
