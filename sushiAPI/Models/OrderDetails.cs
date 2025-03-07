using sushiAPI.DTOs;

namespace sushiAPI.models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItemDto>? OrderItems { get; set; }
    }
}
