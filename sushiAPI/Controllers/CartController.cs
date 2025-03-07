using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sushiAPI.Data;
using sushiAPI.DTOs;
using sushiAPI.Entities;


namespace sushiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly sushiDBContext _context;

        public CartController(sushiDBContext context)
        {
            _context = context;
        }

        [HttpPost("add-to-cart")]
        public async Task<IActionResult> AddToCart([FromBody] CartDto cartDto)
        {
            if (cartDto == null || cartDto.CartItems == null || cartDto.CartItems.Count == 0)
            {
                return BadRequest("Invalid cart data.");
            }

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync();

            if (cart == null)
            {
                cart = new Cart
                {
                    CartItems = new List<CartItem>()
                };
            }

            foreach (var cartItemDto in cartDto.CartItems)
            {
                var existingCartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == cartItemDto.ProductId);

                if (existingCartItem != null)
                {
                    existingCartItem.ProductQuantity += cartItemDto.ProductQuantity;
                }
                else
                {
                    cart.CartItems.Add(new CartItem
                    {
                        ProductId = cartItemDto.ProductId,
                        ProductQuantity = cartItemDto.ProductQuantity
                    });
                }
            }

            if (cart.CartId == 0)
            {
                _context.Carts.Add(cart);
            }

            await _context.SaveChangesAsync();

            return Ok(new { Success = true, Message = "Cart updated successfully." });
        }

        [HttpGet("get-cart-items/")]
        public async Task<IActionResult> GetCartItems()
        {
            var cartItemsWithProductInfo = await _context.CartItems
                .Include(ci => ci.Product)
                .Include(ci => ci.Cart)
                .Where(ci => ci.Cart != null)
                .Where(ci => ci.Product != null)
                .Select(ci => new
                {
                    ProductId = ci.Product!.ProductId,
                    ProductName = ci.Product!.ProductName,
                    ProductDescription = ci.Product!.ProductDescription,
                    ProductImage = ci.Product!.ProductImage,
                    ProductPrice = ci.Product!.ProductPrice,
                    ProductQuantity = ci.ProductQuantity,
                })
                .ToListAsync();

            return Ok(cartItemsWithProductInfo);
        }


        [HttpDelete("delete-cart/")]
        public async Task<IActionResult> DeleteCart()
        {
            var cart = await _context.Carts
               .Include(c => c.CartItems)
               .FirstOrDefaultAsync();

            if (cart == null)
            {
                return NotFound("Cart not found.");
            }

            _context.Carts.Remove(cart);

            await _context.SaveChangesAsync();

            return Ok(new { Success = true, Message = "Cart deleted successfully." });
        }


        [HttpDelete("delete-cart-item/{productId}")]
        public async Task<IActionResult> DeleteCartItem(int productId)
        {
            var cart = await _context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync();

            if (cart == null)
            {
                return NotFound("Cart not found.");
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);

            if (cartItem == null)
            {
                return NotFound("Cart item not found.");
            }

            cart.CartItems.Remove(cartItem);

            await _context.SaveChangesAsync();

            return Ok(new { Success = true, Message = "Cart item deleted successfully." });
        }

        [HttpPost("increment-cart-item/{productId}")]
        public async Task<IActionResult> IncrementCartItem(int productId)
        {
            var cart = await _context.Carts
               .Include(c => c.CartItems)
               .FirstOrDefaultAsync();

            if (cart == null)
            {
                return NotFound("Cart not found.");
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);

            if (cartItem == null)
            {
                return NotFound("Cart item not found.");
            }

            cartItem.ProductQuantity++;

            await _context.SaveChangesAsync();

            return Ok(new { Success = true, Message = "Cart item quantity incremented successfully." });
        }

        [HttpPost("decrement-cart-item/{productId}")]
        public async Task<IActionResult> DecrementCartItem(int productId)
        {
            var cart = await _context.Carts
             .Include(c => c.CartItems)
             .FirstOrDefaultAsync();

            if (cart == null)
            {
                return NotFound("Cart not found.");
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);

            if (cartItem == null)
            {
                return NotFound("Cart item not found.");
            }

            if (cartItem.ProductQuantity > 1)
            {
                cartItem.ProductQuantity--;
            }

            await _context.SaveChangesAsync();

            return Ok(new { Success = true, Message = "Cart item quantity decremented successfully." });
        }


    }
}


