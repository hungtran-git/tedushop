using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;


namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Required]
        public int PostId  {get;set;}
        [Key]
        [Required]
        [MaxLength(50)]
        public string TagId { get; set; }
        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}
