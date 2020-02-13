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
    
    public partial class FreightHeadService
    {
        public int FreightHeadServicesID { get; set; }
        public int FreightHeadID { get; set; }
        public string FreightContainerType { get; set; }
        public int NumberOfContainers { get; set; }
        public string FreightPackingType { get; set; }
        public double NetWeight { get; set; }
        public double GrossWeight { get; set; }
        public string FreeTimePeriod { get; set; }
        public string BLClauses { get; set; }
        public string ShippingCertificate { get; set; }
        public string Remarks { get; set; }
        public string LastUpdatedBy { get; set; }
        public System.DateTime LastUpdatedOn { get; set; }
    
        public virtual FreightHead FreightHead { get; set; }
    }
}