namespace ArchosServerSide.Repositories.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOfOrder { get; set; }
        public int Amount { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set;}
    }
}
