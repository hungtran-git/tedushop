using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;


namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag : Auditable
    {
        [Key]
        [Required]
        public int ProductId { get;set;}
        [Key]
        [Required]
        [MaxLength(50)]
        public string TagId   {get;set;}
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}
