﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Url { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public int MenuGroupId { get; set; }

        [MaxLength(10)]
        public string Target { get; set; }

        public bool Status { get; set; }

        [ForeignKey("MenuGroupId")]
        public virtual MenuGroup MenuGroup { get; set; }
    }
}