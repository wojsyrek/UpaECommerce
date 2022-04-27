namespace ArchosServerSide.Repositories.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string PostCode  { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PersonId { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Client> Clients { get; set; }
   
    }
}
