using Microsoft.AspNetCore.Mvc;
using sushiAPI.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using sushiAPI.models;
using sushiAPI.DTOs;

namespace sushiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly sushiDBContext _context;

        public OrdersController(sushiDBContext context)
        {
            _context = context;
        }

        [HttpPost("create-order")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderDto orderDto)
        {
            if (orderDto == null || orderDto.OrderItems == null || orderDto.OrderItems.Count == 0)
            {
                return BadRequest("Invalid order data.");
            }

            var order = new Order
            {
                TotalAmount = orderDto.TotalAmount,
                OrderItems = orderDto.OrderItems.Select(oi => new OrderItem
                {
                    ProductId = oi.ProductId,
                    ProductQuantity = oi.ProductQuantity
                }).ToList()
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateOrder), new { orderId = order.OrderId }, order);
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<OrderDetails>> GetOrder(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .SingleOrDefaultAsync(o => o.OrderId == orderId);

            if (order == null)
            {
                return NotFound();
            }

            var orderDetails = new OrderDetails
            {
                OrderId = order.OrderId,
                TotalAmount = order.TotalAmount,
                OrderItems = order.OrderItems.Select(oi => new OrderItemDto
                {
                    ProductId = oi.ProductId,
                    ProductQuantity = oi.ProductQuantity,
                }).ToList()
            };

            return Ok(orderDetails);
        }

        [HttpDelete("delete-order/{orderId}")]
        public async Task<IActionResult> DeleteOrder(int orderId)
        {

            var order = await _context.Orders
               .Include(c => c.OrderItems)
               .FirstOrDefaultAsync(c => c.OrderId == orderId);

            if (order == null)
            {
                return NotFound("Order not found.");
            }

            _context.Orders.Remove(order);

            await _context.SaveChangesAsync();

            return Ok(new { Success = true, Message = "Order deleted successfully." });
        }
    }
}
