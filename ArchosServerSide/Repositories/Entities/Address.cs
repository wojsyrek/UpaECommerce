using System.ComponentModel.DataAnnotations.Schema;

namespace ArchosServerSide.Repositories.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string PostCode  { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public List<Client> Client { get; set; }
   
    }
}
