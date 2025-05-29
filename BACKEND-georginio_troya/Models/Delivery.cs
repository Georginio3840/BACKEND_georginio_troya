using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace BACKEND_georginio_troya.Models
{
    public class Delivery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeliveryId { get; set; }


        public int OrderId { get; set; }

        public required string Type { get; set; }

        public required string Status { get; set; }
        public required DateTime Departure { get; set; }
        public required DateTime Arrival { get; set; }

        [JsonIgnore]
        public OrderHeader? Order { get; set; }

    }
}