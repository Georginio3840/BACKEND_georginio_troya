using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BACKEND_georginio_troya.Models;
using BACKEND_georginio_troya.Data;

namespace BACKEND_georginio_troya.Controllers
{
    [ApiController]
    [Route("api/customers/{customerId}/orders/{orderId}/deliveries")]
    public class DeliveryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DeliveryController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> AddDelivery(int customerId, int orderId, [FromBody] Delivery delivery)
        {

            var order = await _context.OrderHeaders
                            .FirstOrDefaultAsync(o => o.OrderId == orderId && o.CustomerId == customerId);
            if (order == null)
                return NotFound("Order not found for the specified customer.");
            delivery.Departure = DateTime.SpecifyKind(delivery.Departure, DateTimeKind.Utc);
            delivery.Arrival = DateTime.SpecifyKind(delivery.Arrival, DateTimeKind.Utc);
            delivery.OrderId = orderId;


            _context.Deliveries.Add(delivery);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetDelivery), new { id = delivery.DeliveryId }, delivery);
        }

        [HttpGet("~/api/deliveries/{id}")]
        public async Task<IActionResult> GetDelivery(int id)
        {
            var delivery = await _context.Deliveries
                .Include(d => d.Order)
                .FirstOrDefaultAsync(d => d.DeliveryId == id);

            if (delivery == null)
            {
                return NotFound();
            }

            return Ok(delivery);
        }

    }
}