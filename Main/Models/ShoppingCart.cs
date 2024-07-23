namespace Main.Models
{
    public class ShoppingCart
    {
        public string IdShoppingCart { get; set; } = "";
        public Client Client { get; set; } = new();
        public List<Product> ListProducts = [];
    }
}
