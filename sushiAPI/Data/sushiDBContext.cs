using Microsoft.EntityFrameworkCore;
using sushiAPI.models;
using sushiAPI.Entities;

namespace sushiAPI.Data
{
    public class sushiDBContext : DbContext
    {
        public sushiDBContext(DbContextOptions<sushiDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
         new Product
       {
         ProductId = 1,
         ProductName = "Liten sushi 8 bitar",
         ProductDescription = "3 lax, 1 räka, 1 avokado, 3 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
         ProductImage = "/images/menu-1.jpg",
         ProductPrice = 110,
      },
       new Product
     {
        ProductId = 2,
        ProductName = "Mellan sushi 11 bitar",
        ProductDescription = "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
        ProductImage = "/images/menu-2.jpg",
        ProductPrice = 145,
     },
      new Product
     {
       ProductId = 3,
       ProductName = "Stor sushi 14 bitar",
       ProductDescription = "5 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
       ProductImage = "/images/menu-3.jpg",
       ProductPrice = 165,
    },
    new Product
    {
      ProductId = 4,
      ProductName = "Lätt grillad 8 bitar",
      ProductDescription = "Halstrad lax med chilimajonnäs, ålsås, sesamfrö och rostad lök.",
      ProductImage = "/images/menu-4.jpg",
      ProductPrice = 150,
   },
   new Product
   {
      ProductId = 5,
      ProductName = "Yume special sushi 11 bitar",
      ProductDescription = "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 pilgrims mussla, 1 sardin, 1 ål, 1 bläckfisk, chillimajonäs, ålsås, sesamfrö, rom och rostad lök.",
      ProductImage = "/images/menu-5.jpg",
      ProductPrice = 165,
   },
   new Product
   {
      ProductId = 6,
      ProductName = "Lax sushi 9 bitar",
      ProductDescription = "9 bitar laxnigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "/images/menu-6.jpg",
      ProductPrice = 150,
   },
   new Product
   {
      ProductId = 7,
      ProductName = "Lax avokado sushi 9 bitar",
      ProductDescription = "5 lax, 4 avokado, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "/images/menu-7.jpg",
      ProductPrice = 145,
   },
   new Product
   {
      ProductId = 8,
      ProductName = "Lax räkor sushi 9 bitar",
      ProductDescription = "5 lax, 4 räkor, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "/images/menu-8.jpg",
      ProductPrice = 145,
   },
   new Product
   {
      ProductId = 9,
      ProductName = "Räk sushi 9 bitar",
      ProductDescription = "9 bitar räknigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "/images/menu-9.jpg",
      ProductPrice = 145,
    },
   new Product
   {
      ProductId = 10,
      ProductName = "Vegetarisk sushi 9 bitar",
      ProductDescription = "3 avokado, 2 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.",
      ProductImage = "/images/menu-10.jpg",
      ProductPrice = 120,
   },
   new Product
   {
      ProductId = 11,
      ProductName = "Vegetarisk sushi 12 bitar",
      ProductDescription = "5 avokado, 3 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.",
      ProductImage = "/images/menu-11.jpg",
      ProductPrice = 140,
   },
   new Product
   {
      ProductId = 12,
      ProductName = "Mamma sushi 9 bitar",
      ProductDescription = "2 avokado, 1 räka, 1 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.",
      ProductImage = "/images/menu-12.jpg",
      ProductPrice = 120,
   },
   new Product
   {
      ProductId = 13,
      ProductName = "Mamma sushi 12 bitar",
      ProductDescription = "4 avokado, 1 räka, 2 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.",
      ProductImage = "/images/menu-13.jpg",
      ProductPrice = 140,
   },
   new Product
   {
      ProductId = 14,
      ProductName = "Sashimi mellan",
      ProductDescription = "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö och rostad lök",
      ProductImage = "/images/menu-14.jpg",
      ProductPrice = 205,
   },
   new Product
   {
      ProductId = 15,
      ProductName = "Sushi 6 bitar och sashimi",
      ProductDescription = "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
      ProductImage = "/images/menu-15.jpg",
      ProductPrice = 250,
   },
   new Product
   {
      ProductId = 16,
      ProductName = "Yume special roll 10 bitar",
      ProductDescription = "Lax, tonfisk, avokado, gurka, crabstick surimi, ål sås, chilimajonnäs, sesamfrö och rostad lök.",
      ProductImage = "/images/menu-16.jpg",
      ProductPrice = 165,
   }
  );
            );

            modelBuilder.Entity<Order>()
                 .Property(e => e.TotalAmount)
                 .HasPrecision(18, 2);

            modelBuilder.Entity<Product>()
                 .Property(e => e.ProductPrice)
                 .HasPrecision(18, 2);

            modelBuilder.Entity<Cart>()
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OrderId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
