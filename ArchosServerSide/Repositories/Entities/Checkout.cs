namespace ArchosServerSide.Repositories.Entities
{
    public class Checkout
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }


    }
}
