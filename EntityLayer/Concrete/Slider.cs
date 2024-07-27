using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
     public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte SliderID { get; set; }
        [MaxLength(100)]
        public required string SliderTitle { get; set; }
        [MaxLength(250)]
        public required string SliderURL { get; set; }
    }
}