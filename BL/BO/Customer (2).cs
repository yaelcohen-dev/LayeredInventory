
namespace BO
{
    public class Customer
    {
        public int Id { get; init; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public Customer(int id, string name=null, string address=null, string phone=null)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }
        public Customer():this(-1)
        {
            
        }
    }
}