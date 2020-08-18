using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag : Auditable
    {
        [Key]
        [Column(Order = 1)]
        public int PostId { get; set; }

        [Key]
        [Column(TypeName ="varchar", Order = 2)]
        [MaxLength(50)]
        public string TagId { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}