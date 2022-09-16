using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileShopAPI.Model
{
    [Table("PlaceOrder")]
    public class PlaceOrder
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? BrandName { get; set; }
        public string? Address { get; set; }
        public string? FromtoDate { get; set; }
        public int? Price { get; set; }
    }
}
