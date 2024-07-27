using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte AddressID { get; set; }
        [MaxLength(100)]
        public required string AddressDetail { get; set; }
        [MaxLength(12)]
        public required string AddressPhoneNumber { get; set; }
        [MaxLength(50)]
        public required string AddressEmail { get; set; }
        [MaxLength(100)]
        public string? AddressDesc { get; set; }
    }
}