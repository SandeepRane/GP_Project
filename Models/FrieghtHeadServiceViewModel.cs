using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP.Models
{
    public class FrieghtHeadServiceViewModel
    {
        public int FreightHeadID { get; set; }
        public string FHNumber { get; set; }
        public System.DateTime RequestDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public int RequestedByUser { get; set; }

        [Display(Name = "Company Name")]
        public Nullable<int> Company { get; set; }

        [Display(Name = "Freight Type")]
        public FreightTypeEnum FreightType { get; set; }
        public string IncoTerm { get; set; }
        public string Customer { get; set; }
        public string PickUpLocation { get; set; }
        public string LoadingPort { get; set; }
        public string DischargePort { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string Commodity { get; set; }
        public string FreightCargoType { get; set; }
        public string TraderName { get; set; }
        public string Deparment { get; set; }
        public PriorityEnum Priority { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public int FreightHeadStatusID { get; set; }
        public string LastUpdatedBy { get; set; }
        public System.DateTime LastUpdatedOn { get; set; }

        //OTHR MODEL

        public string FreightContainerType { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public int NumberOfContainers { get; set; }
        public string FreightPackingType { get; set; }

        [Display(Name = "Net Weight:")]
        [Range(1, double.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public double NetWeight { get; set; }

        [Display(Name = "Gross Weight:")]
        [Required(ErrorMessage = "Gross Weight is required.")[Range(1, double.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public double GrossWeight { get; set; }
        public string FreeTimePeriod { get; set; }
        public string BLClauses { get; set; }
        public string ShippingCertificate { get; set; }
        public string Remarks { get; set; }
    }

    public enum FreightTypeEnum
    {
        Air,
        Ocean,
        Ground
    }

    public enum PriorityEnum
    {
        Immediate,
        High,
        Medium,
        Low
    }

}