using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable, IMetaInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }// int Unchecked

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }// nvarchar(250)   Checked

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }//    nvarchar(50)    Unchecked

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }// nvarchar(500)   Checked

        [MaxLength(250)]
        public string MetaKeyword { get; set; }// nvarchar(250)   Checked

        [MaxLength(250)]
        public string MetaDescription { get; set; }// nvarchar(250)   Checked

        public bool Status { get; set; }// bit Checked
    }
}