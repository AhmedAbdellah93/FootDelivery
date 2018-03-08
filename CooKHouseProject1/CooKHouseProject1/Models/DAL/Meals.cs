using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHouseDB.DAL
{

    public enum Size
    {
        Normal,
        Small,
        Medium,
        Large
    }
    public class Meals
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Size Size { get; set; }
        [ForeignKey("Restaurant")]
        public int Rest_ID { get; set; }
        public virtual Restaurant Restaurant { get; set; } //update Ahmed
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public virtual Category Category { get; set; } //update Ahmed
        public virtual ICollection<Meals_Order> Meals_Order { get; set; }
    }
}
