namespace sushiAPI.DTOs
{
    public class OrderDto
    {
        public required List<OrderItemDto> OrderItems { get; set; }

        public decimal TotalAmount { get; set; }
    }

    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
    }
}
