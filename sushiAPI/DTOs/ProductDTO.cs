namespace sushiAPI.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? ProductDescription { get; set; }
        public string? ProductImage { get; set; }
        public decimal? ProductPrice { get; set; }
    }
}