using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Hygiene.Utility
{
    public static class UtilityFunctions
    {
        public static int GetFHRSIDValue(XElement n)
        {
            int outputValue = 0;
            if (n.Element("FHRSID") != null)
                outputValue = (int)n.Element("FHRSID");
            return outputValue;
        }
        public static string Addr1(XElement n)
        {
            string addre1 = "";
            if (n.Element("AddressLine1") != null)
                addre1 = (string)n.Element("AddressLine1");
            return addre1;
        }
        public static string Addr2(XElement n)
        {
            string addre2 = "";
            if (n.Element("AddressLine2") != null)
                addre2 = (string)n.Element("AddressLine2");
            return addre2;
        }
        public static string Addr3(XElement n)
        {
            string addre3 = "";
            if (n.Element("AddressLine3") != null)
                addre3 = (string)n.Element("AddressLine3");
            return addre3;
        }
        public static string Addr4(XElement n)
        {
            string addre4 = "";
            if (n.Element("AddressLine4") != null)
                addre4 = (string)n.Element("AddressLine4");
            return addre4;
        }
        public static string PstCde(XElement n)
        {
            string postC = "";
            if (n.Element("PostCode") != null)
                postC = (string)n.Element("PostCode");
            return postC;
        }
        public static int GetRatingValue(XElement n)
        {
            int number;
            int rating;
            bool result = false;
            result = Int32.TryParse(n.Element("RatingValue").Value, out number);
            if (result == true)
            {
                rating = number;
            }
            return result ? number : 0;
        }
        public static string GetBusinessName(XElement n)
        {
            string outputValue = "";
            if (n.Element("BusinessName") != null)
                outputValue = (string)n.Element("BusinessName");
            return outputValue;
        }
        public static string GetRatingDate(XElement n)
        {
            string outputValue = "";
            if (n.Element("RatingDate") != null)
                outputValue = (string)n.Element("RatingDate");
            return outputValue;
        }
        public static double GetLongitude(XElement n)
        {
            double outputValue = 0.000000;
            if (n.Element("Geocode").Element("Longitude") != null)
                outputValue = (double)n.Element("Geocode").Element("Longitude");
            return outputValue;
        }
        public static double GetLatitude(XElement n)
        {
            double outputValue = 0.0000000;
            if (n.Element("Geocode").Element("Latitude") != null)
                outputValue = (double)n.Element("Geocode").Element("Latitude");
            return outputValue;
        }
        public static string Image(XElement n)
        {
            string imagePath = "";
            string im = "";
            if (n.Element("RatingKey") != null)
                im = (string)n.Element("RatingKey");

            switch (im)
            {
                case "fhrs_0_en-GB":
                    imagePath = "~/Images/fhrs_0_en-gb.jpg";
                    break;
                case "fhrs_1_en-GB":
                    imagePath = "~/Images/fhrs_1_en-gb.jpg";
                    break;
                case "fhrs_2_en-GB":
                    imagePath = "~/Images/fhrs_2_en-gb.jpg";
                    break;
                case "fhrs_3_en-GB":
                    imagePath = "~/Images/fhrs_3_en-gb.jpg";
                    break;
                case "fhrs_4_en-GB":
                    imagePath = "~/Images/fhrs_4_en-gb.jpg";
                    break;
                case "fhrs_5_en-GB":
                    imagePath = "~/Images/fhrs_5_en-gb.jpg";
                    break;
                case "fhrs_awaitinginspection_en-GB":
                    imagePath = "~/Images/fhrs_awaitinginspection_en-gb.jpg";
                    break;
                case "fhrs_awaitingpublication_en-GB":
                    imagePath = "~/Images/fhrs_awaitingpublication_en-gb.jpg";
                    break;
                case "fhrs_exempt_en-GB":
                    imagePath = "~/Images/fhrs_exempt_en-gb.jpg";
                    break;
                case "fhis_pass_and_eat_safe_en-GB":
                    imagePath = "~/Images/fhis_pass_and_eat_safe_en-gb.jpg";
                    break;
                case "fhis_pass":
                    imagePath = "~/Images/fhis_pass_en-gb.jpg";
                    break;
                case "fhis_improvement_required_en-GB":
                    imagePath = "~/Images/improvement_required_en-gb.jpg";
                    break;
                case "fhis_exempt_en-GB":
                    imagePath = "~/Images/exempt_en-gb.jpg";
                    break;
                case "fhis_awaiting_publication_en-GB":
                    imagePath = "~/Images/awaiting_publication_en-gb.jpg";
                    break;
                case "fhis_awaiting_inspection_en-GB":
                    imagePath = "~/Images/awaiting_inspection_en-gb.jpg";
                    break;
                default:
                    imagePath = "No image found!!!";
                    break;
            }
        return imagePath;
        }
        public static int SetDistrictId(XElement n)
        {
            int districtId = 0;
            string authorityName = "";

            if (n.Element("LocalAuthorityName") != null)
                authorityName = (string)n.Element("LocalAuthorityName");

            switch (authorityName)
            {
                case "Barking and Dagenham":
                    districtId = 1;
                    break;
                case "Barnet":
                    districtId = 2;
                    break;
                case "Bexley":
                    districtId = 3;
                    break;
                case "Brent":
                    districtId = 4;
                    break;
                case "Bromley":
                    districtId = 5;
                    break;
                case "Camden":
                    districtId = 6;
                    break;
                case "City of London Corporation":
                    districtId = 7;
                    break;
                case "Croydon":
                    districtId = 8;
                    break;
                case "Ealing":
                    districtId = 9;
                    break;
                case "Enfield":
                    districtId = 10;
                    break;
                case "Greenwich":
                    districtId = 11;
                    break;
                case "Hackney":
                    districtId = 12;
                    break;
                case "Hammersmith and Fulham":
                    districtId = 13;
                    break;
                case "Haringey":
                    districtId = 14;
                    break;
                case "Harrow":
                    districtId = 15;
                    break;
                case "Havering":
                    districtId = 16;
                    break;
                case "Hillingdon":
                    districtId = 17;
                    break;
                case "Hounslow":
                    districtId = 18;
                    break;
                case "Islington":
                    districtId = 19;
                    break;
                case "Kensington and Chelsea":
                    districtId = 20;
                    break;
                case "Kingston-Upon-Thames":
                    districtId = 21;
                    break;
                case "Lambeth":
                    districtId = 22;
                    break;
                case "Lewisham":
                    districtId = 23;
                    break;
                case "Merton":
                    districtId = 24;
                    break;
                case "Newham":
                    districtId = 25;
                    break;
                case "Redbridge":
                    districtId = 26;
                    break;
                case "Richmond-Upon-Thames":
                    districtId = 27;
                    break;
                case "Southwark":
                    districtId = 28;
                    break;
                case "Sutton":
                    districtId = 29;
                    break;
                case "Tower Hamlets":
                    districtId = 30;
                    break;
                case "Waltham Forest":
                    districtId = 31;
                    break;
                case "Wandsworth":
                    districtId = 32;
                    break;
                case "Westminster":
                    districtId = 33;
                    break;
                default:
                    districtId = 0;
                    break;
            }
            return districtId;
        }
        public static string GetRatingKey(XElement n)
        {
            string outputValue = "";
            if (n.Element("RatingKey") != null)
                outputValue = (string)n.Element("RatingKey");
            return outputValue;
        }
    }
}