using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer: Auditable
    {
        [Key]
        [MaxLength(50)]
        public string Id { get; set; }
        [Required]
        public string Content { get; set; }
    }
}