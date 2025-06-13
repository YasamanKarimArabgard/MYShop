namespace MYShop.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal GetTotalPrice()
        {
            if (Item != null && Item.Price > 0 && Quantity > 0)
            {
                return Item.Price * Quantity;
            }
            else
            {
                return 0;
            }
        }
                                    }
}
