using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHouseDB.DAL
{
    public class Meals_Order
    {

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Meals")]
        public int Meals_ID { get; set; }
        public virtual Meals Meals { get; set; } //update Ahmed
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Order")]
        public int Order_ID { get; set; }
        public virtual Order Order { get; set; } //update Ahmed
        public int Quantity { get; set; }
        
    }
}
