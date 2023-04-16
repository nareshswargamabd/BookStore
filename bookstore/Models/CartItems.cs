using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Models
{
    [Table("CartItems")]
    public class CartItems
    {
        [Key]
        public int CartId { get; set; }
        public double Price { get; set; }     
        public int Qty { get; set; }
        public double TotalAmount { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; } 

    }
}
