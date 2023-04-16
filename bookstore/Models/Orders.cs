using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public double OrderTotal { get; set; }
        public DateTime OrderPlacedDate { get; set; }
        public bool IsOrderCompleted { get; set; }     
        public string UserId { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
