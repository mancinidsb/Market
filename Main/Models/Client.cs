namespace Main.Models
{
    public class Client
    {
        public string Name { get; set; } = "";
        public string IdClient { get; set; } = "";
        public ShoppingCart ShoppingCart { get; set; } = new();
    }
}
