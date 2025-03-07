using sushiAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using sushiAPI.Data;
using sushiAPI.Entities;

namespace sushiAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly sushiDBContext _context;
        public ProductRepository(sushiDBContext context)
        {
            _context = context;
        }

        public async Task<Product> AddProduct(Product product, List<IFormFile> files)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product?> DeleteProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == id);
            if (product == null)
            {
                return null;
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product?> GetProduct(int id)
        {
            return await _context.Products
                .FirstOrDefaultAsync(x => x.ProductId == id);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products
                .ToListAsync();
        }

        public async Task<Product?> UpdateProduct(int id, Product product, List<IFormFile> files)
        {
            var productToUpdate = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == id);
            if (productToUpdate == null)
            {
                return null;
            }
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductDescription = product.ProductDescription;
            productToUpdate.ProductImage = product.ProductImage;
            productToUpdate.ProductPrice = product.ProductPrice;

        await _context.SaveChangesAsync();
            return productToUpdate;
        }
    }
}