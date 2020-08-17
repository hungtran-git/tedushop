using System;

namespace TeduShop.Model.Abtract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }// datetime Checked
        string CreatedBy { get; set; }// nvarchar(50)    Checked
        DateTime? UpdatedDate { get; set; }// datetime Checked
        string UpdatedBy { get; set; }// nvarchar(50)    Checked

        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }                    // bit Unchecked
    }
}