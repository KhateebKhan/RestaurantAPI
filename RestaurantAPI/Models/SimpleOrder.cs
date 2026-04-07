namespace RestaurantAPI.Models
{
    public class SimpleOrder
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public decimal VAT { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal VatAmount { get; set; }
    }
    public class CreateOrderRequest
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        
        public decimal VAT { get; set; }
    }

    public class OrderItem
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
