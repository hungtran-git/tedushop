using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model
{
    [Table("Sliders")]
    public class Slider : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }// int Unchecked

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }// nvarchar(250)   Checked

        [MaxLength(250)]
        public string Description { get; set; }// nvarchar(250)   Checked

        [MaxLength(500)]
        public string Image { get; set; }// nvarchar(500)   Checked

        [MaxLength(500)]
        public string Url { get; set; }// nvarchar(500)   Checked

        public int DisplayOrder { get; set; }// int Checked
        public bool Status { get; set; }// bit Checked
    }
}