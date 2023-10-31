using Microsoft.AspNetCore.Components;
using Shop.Models.DataTransferObjects;
using SHOP.StyleInAllThings.Services.Contracts;
using System.Text.Json.Serialization.Metadata;

namespace SHOP.StyleInAllThings.Pages
{
    public class ShoppingCartBase : ComponentBase
    {
        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }
        public IEnumerable<CartItemDto> ShoppingCartItems { get; set; }
        public string ErrorMessage { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ShoppingCartService.GetItems(HardCoded.UserId);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
