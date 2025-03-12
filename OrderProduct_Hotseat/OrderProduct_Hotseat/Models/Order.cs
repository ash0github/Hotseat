using System.ComponentModel.DataAnnotations;

namespace OrderProduct_Hotseat.Models
{
    public class Order
    {
        [Key]
        [Required]
        public string orderID { get; set; }
        public DateTime orderDate { get; set; }
        public string? orderDetails { get; set; }

        //Discuss DataAnnotations - Keywords that handle validation
        //Discuss ? - Deals with nullable properties
    }
}
