namespace sushiAPI.Entities
{
    public class Cart
    {
        public int CartId { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
        public Cart()
        {
            CartItems = new List<CartItem>(); 
        }

    }

    public class CartItem
    {
        public int CartItemId { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int CartId { get; set; } 
        public Cart? Cart { get; set; } 

        public int ProductQuantity { get; set; } 
    }
}
