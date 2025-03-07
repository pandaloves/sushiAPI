using System.ComponentModel.DataAnnotations;

namespace sushiAPI.Entities
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string NameOnCard { get; set; } = string.Empty;
        public string ExpirationDate { get; set; } = string.Empty;
        public string CVV { get; set; } = string.Empty;

        public int OrderId { get; set; }

        public Order? Order { get; set; }
    }
}
