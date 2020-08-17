using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic : Auditable
    {
        [Key]
        public Guid Id { get; set; }//uniqueidentifier    Unchecked

        public DateTime VisitedDate { get; set; }//datetime Checked

        [MaxLength(50)]
        public string IpAddress { get; set; }//varchar(50) Checked
    }
}