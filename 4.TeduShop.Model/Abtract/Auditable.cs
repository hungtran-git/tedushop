using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abtract
{
    public class Auditable
    {
        [Required]
        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

    }
}