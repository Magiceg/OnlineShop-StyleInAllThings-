using Microsoft.EntityFrameworkCore;
using Shop.Models.DataTransferObjects;
using Shop.StyleInAllThings.API.Data;
using Shop.StyleInAllThings.API.Entities;
using Shop.StyleInAllThings.API.Repositories.Contracts;

namespace Shop.StyleInAllThings.API.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ShopDbContext shopDbContext;

        public ShoppingCartRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }
        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await shopDbContext.CartItems.AnyAsync(c => c.CartId == cartId && c.ProductId == productId);
        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if(await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
            {
                var item = await (from product in shopDbContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = product.Id,
                                      Quantity = cartItemToAddDto.Quantity
                                  }).SingleOrDefaultAsync();
                if (item != null)
                {
                    var result = await shopDbContext.CartItems.AddAsync(item);
                    await shopDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }
                return null;
        }


        public async Task<IEnumerable<CartItem>> GetAllItems(int userId)
        {
            return await (from cart in shopDbContext.Carts
                          join cartItem in shopDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Quantity = cartItem.Quantity,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in shopDbContext.Carts
                          join cartItem in shopDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Quantity = cartItem.Quantity,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }
        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await shopDbContext.CartItems.FindAsync(id);

            if(item != null)
            {
                shopDbContext.CartItems.Remove(item);
                await shopDbContext.SaveChangesAsync();
            }
            return item;
        }

        public Task<CartItem> UpdateQuantity(int id, CartItemQuantityUpdateDto cartItemQuantityUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
