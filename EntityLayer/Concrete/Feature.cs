using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte FeatureID { get; set; }
        [MaxLength(100)]
        public required string FeatureTitle { get; set; }
        [MaxLength(200)]
        public required string FeatureDesc { get; set; }
        public required bool FeatureStatus { get; set; } = false;
    }
}