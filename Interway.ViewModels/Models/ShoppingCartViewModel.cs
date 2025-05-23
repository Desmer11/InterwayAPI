namespace InterwayAPI.ViewModels.Models
{
    public class ShoppingCartViewModel
    {
        public List<ShoppingCartItemViewModel> ShoppingCartItems { get; set; }

        public ShoppingCartViewModel()
        {
            ShoppingCartItems = new List<ShoppingCartItemViewModel>();
        }
    }
}
