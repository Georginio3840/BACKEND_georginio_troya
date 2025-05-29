using System.ComponentModel.DataAnnotations;



namespace BACKEND_georginio_troya.Models
{
    public class OrderHeader
    {
        [Key]
        public int OrderId { get; set; }
        public required DateTime OrderDate { get; set; }

        public required TimeSpan OrderTime { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public ICollection<Delivery>? Deliveries { get; set; } 

        

    }
}