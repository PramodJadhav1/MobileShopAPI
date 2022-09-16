using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MobileShopAPI.Model
{
    [Table("Brand")]
    public class Brand
    {

        [Key]
        public int? Id { get; set; }
        public string? MName { get; set; }
        public int? ModelNo  { get; set; }
        public int? Price { get; set; }
       
    }

    
}
