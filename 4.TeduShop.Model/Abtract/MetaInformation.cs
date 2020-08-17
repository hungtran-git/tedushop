using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Abtract
{
    public class MetaInformation
    {
        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }
    }
}
