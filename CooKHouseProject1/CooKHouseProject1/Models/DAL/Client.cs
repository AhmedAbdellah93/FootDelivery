using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookHouseDB.DAL
{
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        //[MaxLength(14)]
        public int Phone { get; set; }
        public Address Address { get; set; }
    }
}