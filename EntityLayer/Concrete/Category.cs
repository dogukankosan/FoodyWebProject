using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CategoryID { get; set; }
        [MaxLength(50)]
        public required string CategoryName { get; set; }
        public bool CategoryStatus { get; set; } = false;
    }
}