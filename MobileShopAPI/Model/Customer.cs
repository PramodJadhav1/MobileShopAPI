using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MobileShopAPI.Model
{
    [Table("customer")]
    public class Customer
    {
        [Key]
      public int? Id { get; set; }
      public string? CName { get; set; }
      public string? Gender { get; set; }
      public string? Contact { get; set; }
      public string? CAddress { get; set; }
      public string? Email { get; set; }
      public string? Password { get; set; }
    }
    
}
