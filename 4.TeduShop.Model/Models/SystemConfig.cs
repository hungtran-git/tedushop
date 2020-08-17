using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id          {get;set;}//nt Unchecked
        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string Code        {get;set;}//archar(50) Checked
        [MaxLength(250)]
        public string ValueString {get;set;}//archar(250)    Checked
        public int ValueInt    { get; set; }//int Checked
    }
}
