using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }// int Unchecked

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }// nvarchar(250)   Unchecked

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }// nvarchar(50)    Unchecked

        [Required]
        public int CategoryId { get; set; }// int Unchecked

        [Required]
        [MaxLength(500)]
        public string Image { get; set; }// nvarchar(500)   Checked

        public string Description { get; set; }// nvarchar(500)   Checked

        [Required]
        public string Content { get; set; }// nvarchar(MAX)   Checked

        [Required]
        [MaxLength(250)]
        public string MetaKeyword { get; set; }// nvarchar(250)   Checked

        [Required]
        [MaxLength(250)]
        public string MetaDescription { get; set; }// nvarchar(250)   Checked

        public bool Status { get; set; }// bit Unchecked
        public bool HomeFlag { get; set; }// bit Unchecked
        public bool HotFlag { get; set; }// bit Checked
        public int ViewCount { get; set; }// int Checked

        [ForeignKey("CategoryId")]
        public virtual PostCategory PostCategory { get; set; }
        public virtual IEnumerable<PostTag> PostTages { get; set; }
    }
}