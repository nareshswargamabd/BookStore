using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace bookstore.Models
{
    [Table("Books")]
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }        
        public double Price { get; set; }
        [NotMapped]
        //[JsonIgnore]
        public byte[] ImageArray { get; set; }
        
        [JsonIgnore]
        public ICollection<OrderDetail> OrderDetails { get; set; }
        
        [JsonIgnore]
        public ICollection<CartItems> ShoppingCartItems { get; set; }
    }
}
