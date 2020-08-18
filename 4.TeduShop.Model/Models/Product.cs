using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Product")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }//    int Unchecked

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }//    nvarchar(250)   Unchecked

        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string Alias { get; set; }//    nvarchar(50)    Unchecked

        [Required]
        public int CategoryId { get; set; }//    int Unchecked

        [Required]
        [MaxLength(250)]
        public string Image { get; set; }//    nvarchar(500)   Unchecked
        [Column(TypeName ="xml")]
        public string MoreImages { get; set; }//    xml Checked
        public decimal Price { get; set; }//    decimal (18, 2)	Unchecked
        public decimal? Promotion { get; set; }//    decimal (18, 2)	Checked
        public int? Warranty { get; set; }//    int Checked

        [MaxLength(500)]
        public string Description { get; set; }//nchar(500)  Checked

        public string Content { get; set; }//nvarchar(MAX)   Checked

        [MaxLength(250)]
        public string MetaKeyword { get; set; }//nvarchar(250)   Checked

        [MaxLength(250)]
        public string MetaDescription { get; set; }//nvarchar(250)   Checked

        public bool Status { get; set; }//bit Unchecked
        public bool HomeFlag { get; set; }//bit Unchecked
        public bool HotFlag { get; set; }//bit Checked
        public int ViewCount { get; set; }//int Checked

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}