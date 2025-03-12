using System.ComponentModel.DataAnnotations;

namespace OrderProduct_Hotseat.Models
{
    public class Product
    {
        [Key]
        [Required]
        public string productID { get; set; }
        [Required]
        public string productName { get; set; }
        public string? productDescription { get; set; }
        public string? productCategory { get; set; }
    }
}
