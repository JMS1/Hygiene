using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HygieneMVC.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        public virtual int? DistrictId { get; set; }

        public int FHRSID { get; set; }
        public string BusinessName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string PostCode { get; set; }
        public string RatingKey { get; set; }
        public int? RatingValue { get; set; }
        public string RatingDate { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string ImagePath { get; set; }
    }
}
