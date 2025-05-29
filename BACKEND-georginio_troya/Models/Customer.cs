using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace BACKEND_georginio_troya.Models
{

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public required string Fname { get; set; }
        public required string Lname { get; set; }

        public required string Address { get; set; }
        public required string Phone { get; set; }
        public required string? Email { get; set; }

        [JsonIgnore]
        public ICollection<OrderHeader>? OrderHeaders { get; set; }
    }
}