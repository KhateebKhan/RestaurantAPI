using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderClassController : ControllerBase
    {
        private static List<SimpleOrder> orders = new List<SimpleOrder>();

        [HttpGet]
        public ActionResult Get() 
        {
            return Ok(orders);
        }

        [HttpPost]

        public ActionResult Post(CreateOrderRequest request)
        {
            var order = new SimpleOrder
            {
                Id = orders.Count + 1,
                Items = request.Items,
                VAT = request.VAT
            };

            decimal subtotal = 0;

            foreach(var item in order.Items)
            {
                 subtotal += item.Price * item.Quantity;

            }

            order.VatAmount = (subtotal * order.VAT) / 100m;  // ✅ correct
            order.TotalPrice = subtotal + order.VatAmount;

            orders.Add(order);
            return Ok(order);
        }
    }
   
}