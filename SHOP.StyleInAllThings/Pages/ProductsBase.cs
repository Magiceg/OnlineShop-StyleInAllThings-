using Microsoft.AspNetCore.Components;
using Microsoft.Identity.Client;
using Shop.Models.DataTransferObjects;
using SHOP.StyleInAllThings.Services.Contracts;

namespace SHOP.StyleInAllThings.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
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
