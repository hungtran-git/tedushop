using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag:Auditable
    {
        [Key]
        [MaxLength(50)]
        public string Id        {get;set;}
        [Required]
        [MaxLength(50)]
        public string Name   {get;set;}
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        public virtual IEnumerable<PostTag> PostTags { get; set; }
        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}
