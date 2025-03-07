using sushiAPI.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Order
{
    [Key]
    public int OrderId { get; set; }
    public decimal TotalAmount { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public Payment? Payment { get; set; }

}

public class OrderItem
{
    public int OrderItemId { get; set; }

    public int ProductId { get; set; }
    public Product? Product { get; set; }

    public int OrderId { get; set; }

    [JsonIgnore]
    public Order? Order { get; set; }

    public int ProductQuantity { get; set; }
}

