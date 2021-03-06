namespace ArchosServerSide.Repositories.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Checkout> Checkouts { get; set; }
    }
}
