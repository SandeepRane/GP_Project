//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class FreightHeadShipmentRate
    {
        public int FreightHeadShipmentRateID { get; set; }
        public int FreightHeadID { get; set; }
        public int FreightHeadShipmentTypeID { get; set; }
        public string FreightContainerType { get; set; }
        public string FreightPackingType { get; set; }

        [Display(Name = "Rate Offered To Traders:")]
        [Required(ErrorMessage = "Rate Offered To Traders is required.")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{10,2})$", ErrorMessage = "Valid Decimal number with maximum 2 decimal places.")]
        public double RateOfferedToTraders { get; set; }

        [Display(Name = "Rate Offered By ShippingLine:")]
        [Required(ErrorMessage = "Rate Offered By ShippingLine is required.")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{10,2})$", ErrorMessage = "Valid Decimal number with maximum 2 decimal places.")]
        public Nullable<double> RateOfferedByShippingLine { get; set; }

        [Display(Name = "Total Amout To Traders:")]
        [Required(ErrorMessage = "Total Amout To Traders is required.")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{10,2})$", ErrorMessage = "Valid Decimal number with maximum 2 decimal places.")]
        public double TotalAmoutToTraders { get; set; }

        [Display(Name = "Total Amount Of ShippingLine:")]
        [DataType(DataType.)]
        [Required(ErrorMessage = "Total Amount Of ShippingLine is required.")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{10,2})$", ErrorMessage = "Valid Decimal number with maximum 2 decimal places.")]
        public Nullable<double> TotalAmountOfShippingLine { get; set; }
        public string LastUpdatedBy { get; set; }
        public System.DateTime LastUpdatedOn { get; set; }
    
        public virtual FreightHead FreightHead { get; set; }
    }
}
