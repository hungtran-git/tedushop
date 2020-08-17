using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;
using TeduShop.Model.Models;

namespace TeduShop.Model
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }//t Unchecked

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }//archar(250)   Unchecked

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }//archar(250)   Unchecked

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }//har(500)  Checked

        public int? ParentId { get; set; }//t Checked
        public int? DisplayOrder { get; set; }//t Checked
        public string Image { get; set; }//archar(500)   Checked
        public bool Status { get; set; }//t Unchecked
        public bool HomeFlag { get; set; }//bit Unchecked

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}