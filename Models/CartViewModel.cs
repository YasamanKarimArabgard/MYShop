namespace MYShop.Models;

public class CartViewModel
{

    public CartViewModel()
    {
       CartItems = new List<CartItem>();
    }

    public List<CartItem> CartItems { get; set; }

    public int CartTotal { get; set; }
}

