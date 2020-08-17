using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline : Auditable
    {
        [Key]
        public int Id { get; set; }//int Unchecked

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }//nvarchar(250)   Checked

        [MaxLength(50)]
        public string Department { get; set; }//nvarchar(250)   Checked
        [MaxLength(50)]
        public string Skype { get; set; }//nvarchar(250)   Checked

        [Required]
        [MaxLength(50)]
        public string Mobile { get; set; }//nvarchar(250)   Checked

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }//nvarchar(250)   Checked

        [MaxLength(50)]
        public string Yahoo { get; set; }//nvarchar(250)   Checked
        [MaxLength(50)]
        public string Facebook { get; set; }//nvarchar(250)   Checked
        public bool Status { get; set; }//bit Checked
    }
}