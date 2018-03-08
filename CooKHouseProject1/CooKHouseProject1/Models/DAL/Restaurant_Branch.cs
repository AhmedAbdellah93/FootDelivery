using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHouseDB.DAL
{
    public class Restaurant_Branch
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Restaurant")]
        public int Rest_ID { get; set; }
        public virtual Restaurant Restaurant { get; set; } //update Ahmed
        [ForeignKey("Quarter")]
        public int Quarter_ID { get; set; }
        public virtual Quarter Quarter { get; set; } //update Ahmed
        public int Rate { get; set; }
    }
}
