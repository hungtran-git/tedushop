using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Abtract
{
    public interface IMetaInformation
    {
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
    }
}
