using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte SocialMediaID { get; set; }
        [MaxLength(100)]
        public required string SocialMediaTitle { get; set; }
        [MaxLength(250)]
        public required string SocialMediaURL { get; set; }
        [MaxLength(250)]
        public required string SocialMediaIcon { get; set; }
    }
}