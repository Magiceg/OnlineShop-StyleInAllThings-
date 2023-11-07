using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Shop.Models.DataTransferObjects;
using SHOP.StyleInAllThings.Services.Contracts;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.Json.Serialization.Metadata;

namespace SHOP.StyleInAllThings.Pages
{
    public class ShoppingCartBase : ComponentBase
    {
        [Inject]
        public IJSRuntime Js {  get; set; }
        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }
        public List<CartItemDto> ShoppingCartItems { get; set; }
        public string ErrorMessage { get; set; }
        protected string TotalPrice { get; set; }
        protected int TotalQuantity { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ShoppingCartService.GetItems(HardCoded.UserId);
                CalculateCartSummaryTotals();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
        protected async Task DeleteCartItem_Click(int id)
        {
            var cartItem = await ShoppingCartService.DeleteItem(id);
            RemoveCartItem(id);
            CalculateCartSummaryTotals();
        }

        protected async Task UpdateQuantityCartItem_Click(int id, int quantity)
        {
            try
            {
                if (quantity > 0)
                {
                    var updateItemDto = new CartItemQuantityUpdateDto
                    {
                        CartItemId = id,
                        Quantity = quantity
                    };

                    var returnedUpdateItemDto = await ShoppingCartService.UpdateQuantity(updateItemDto);
                    
                    UpdateItemTotalPrice(returnedUpdateItemDto);

                    CalculateCartSummaryTotals();

					await Js.InvokeVoidAsync("MakeUpdateQtyButtonVisible", id, false);
				}
                else
                {
                    var item = ShoppingCartItems.FirstOrDefault(x => x.Id == id);
                    if (item != null)
                    {
                        item.Quantity = quantity;
                        item.TotalPrice = item.Price;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        protected async Task UpdateQuantity_Input(int id)
        {
            await Js.InvokeVoidAsync("MakeUpdateQtyButtonVisible", id, true);
        }

        private void UpdateItemTotalPrice(CartItemDto cartItemDto)
        {
            var item = GetCartItem(cartItemDto.Id);
            if (item != null)
            {
                item.TotalPrice = cartItemDto.Price * cartItemDto.Quantity;
            }
        }
        private void CalculateCartSummaryTotals()
        {
            SetTotalPrice();
            SetTotalQuantity();
        }
        private void SetTotalPrice()
        {
            TotalPrice = ShoppingCartItems.Sum(x => x.TotalPrice).ToString("C", new CultureInfo("en-US").NumberFormat);
        }
        private void SetTotalQuantity()
        {
            TotalQuantity = ShoppingCartItems.Sum(x => x.Quantity);
        }
        private CartItemDto GetCartItem(int id)
        {
            return ShoppingCartItems.FirstOrDefault(i => i.Id == id);
        }
        private void RemoveCartItem(int id)
        {
            var cartItemDto = GetCartItem(id);

            ShoppingCartItems.Remove(cartItemDto);
        }


    }
}
