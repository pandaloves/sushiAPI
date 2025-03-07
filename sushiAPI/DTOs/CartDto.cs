namespace sushiAPI.DTOs
{
    public class CartDto
    {
        public required List<CartItemDto> CartItems { get; set; }
    }

    public class CartItemDto
    {
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
    }
}

