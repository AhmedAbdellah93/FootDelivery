using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHouseDB.DAL
{
    public class Restaurant
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
       // [ MaxLength(14)]
        public int Phone  { get; set; }
        public string LogoImage { get; set; }
        public virtual ICollection<Restaurant_Branch> Restaurant_Branch { get; set; }
    }

   
}
