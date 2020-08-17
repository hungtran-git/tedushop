using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }//int Unchecked

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }//nvarchar(250)   Unchecked

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }//nvarchar(50)    Unchecked

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }//nchar(500)  Checked

        public int? ParentId { get; set; }//int Checked
        public int DisplayOrder { get; set; }//int Checked

        [MaxLength(500)]
        public string Image { get; set; }//nvarchar(500)   Checked

        [MaxLength(250)]
        public string MetaKeyword { get; set; }//nvarchar(250)   Checked

        [MaxLength(250)]
        public string MetaDescription { get; set; }//nvarchar(250)   Checked

        public bool Status { get; set; }//bit Unchecked
        public bool HomeFlag { get; set; }//bit Unchecked

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}