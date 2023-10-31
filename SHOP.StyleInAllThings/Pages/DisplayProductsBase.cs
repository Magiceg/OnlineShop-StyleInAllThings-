using Microsoft.AspNetCore.Components;
using Shop.Models.DataTransferObjects;

namespace SHOP.StyleInAllThings.Pages
{
	public class DisplayProductsBase : ComponentBase
	{
		[Parameter]
		public IEnumerable<ProductDto> Products { get; set; }
	}
}
