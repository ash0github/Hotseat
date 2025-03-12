using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderProduct_Hotseat.Models
{
    public class OrderProduct
    {
        [Key]
        [Required]
        public string OPID { get; set; }

        [Required]
        public string orderID { get; set; }

        [ForeignKey(nameof(orderID))]
        public Order order { get; set; }

        [Required]
        public string productID { get; set; }

        [ForeignKey(nameof(productID))]
        public Product product { get; set; }

        //Explain mapping of keys in the context of MVC - ORM (as opposed to DAO)
        //This uses EF to build tables in the same way you would using SQL
        //Instances of the classes are created -- Their primary key is denoted to the property created to hold it as a FK reference
    }
}
