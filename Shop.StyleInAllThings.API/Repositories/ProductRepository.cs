using Microsoft.EntityFrameworkCore;
using Shop.StyleInAllThings.API.Data;
using Shop.StyleInAllThings.API.Entities;
using Shop.StyleInAllThings.API.Repositories.Contracts;

namespace Shop.StyleInAllThings.API.Repositories
{
    public class ProductRepository : IProductRepository 
    {
        private readonly ShopDbContext shopDbContext;
        public ProductRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.shopDbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await shopDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await shopDbContext.Products.FindAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.shopDbContext.Products.ToListAsync();

            return products;
        }
    }
}
