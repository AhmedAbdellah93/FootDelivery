using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHouseDB.DAL
{
    public class Quarter
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Quarter_Name { get; set; }
        [ForeignKey("Governorate")]
        public int Governorate_ID { get; set; }
        public virtual Governorate Governorate { get; set; } //update Ahmed
    }
}
