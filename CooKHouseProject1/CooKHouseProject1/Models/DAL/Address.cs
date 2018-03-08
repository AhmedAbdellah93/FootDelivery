using System.ComponentModel.DataAnnotations.Schema;

namespace CookHouseDB.DAL
{

    [ComplexType]
    public class Address
    {
        public string Gov { get; set; }
        public string Quarter { get; set; }
        public string Street { get; set; }
    }
}