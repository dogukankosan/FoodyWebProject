using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort ProductID { get; set; }
        [MaxLength(70)]
        public required string ProductName { get; set; }
        [MaxLength(200)]
        public required string ProductDesc { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        [MaxLength(300)]
        public required string ProductImageURL { get; set; }
        public bool ProductStatus { get; set; } = false;
        public DateTime CreateDate { get; } = DateTime.Now;
    }
}