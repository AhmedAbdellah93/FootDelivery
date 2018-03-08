using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHouseDB.DAL
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public double TotalPrice { get; set; }
        [ForeignKey("Restaurant_Branch")]
        public int Rest_ID { get; set; }
        public virtual Restaurant_Branch Restaurant_Branch { get; set; } //update Ahmed
        [ForeignKey("Client")]
        public int client_ID { get; set; }
        public  virtual Client Client { get; set; }  //update Ahmed
        public virtual ICollection<Meals_Order> Meals_Order { get; set; }
    }
}
