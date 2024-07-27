using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ReviewID { get; set; }
        [MaxLength(50)]
        public required string CustomerName { get; set; }
        [MaxLength(100)]
        public required string CustomerTitle { get; set; }
        [MaxLength(250)]
        public required string Comment { get; set; }
        [MaxLength(250)]
        public required string ImageURL { get; set; }
        public DateTime CreateDate { get; } = DateTime.Now;
    }
}