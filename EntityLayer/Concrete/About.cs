using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte AboutID { get; set; }
        [MaxLength(200)]
        public required string AboutTitle { get; set; }
        [MaxLength(200)]
        public required string AboutDesc { get; set; }
    }
}