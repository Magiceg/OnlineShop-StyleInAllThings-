using Microsoft.AspNetCore.Components;
using Microsoft.Identity.Client;
using Shop.Models.DataTransferObjects;
using SHOP.StyleInAllThings.Services;
using SHOP.StyleInAllThings.Services.Contracts;

namespace SHOP.StyleInAllThings.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        public NavigationManager NavigationManager { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
				Products = await ProductService.GetItems();

                var shoppingCartItems = await ShoppingCartService.GetItems(HardCoded.UserId);

                var totalQuantity = shoppingCartItems.Sum(x => x.Quantity);

                ShoppingCartService.RaiseEventOnShoppingCartChanged(totalQuantity);



			}
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
				   group product by product.CategoryId into prodByCatGroup
				   orderby prodByCatGroup.Key
				   select prodByCatGroup;
		}
        protected string GetCategoryName(IGrouping<int, ProductDto> groupedProductDto)
        {
            return groupedProductDto.FirstOrDefault(pg => pg.CategoryId == groupedProductDto.Key).CategoryName;
        }
    }
}
