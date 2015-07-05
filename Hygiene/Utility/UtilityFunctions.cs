using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Hygiene.Utility
{
    public static class UtilityFunctions
    {

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
        public static XDocument BuildXDoc()
        {
            var xmlDocument = new XDocument();
            xmlDocument = XDocument.Load(HttpContext.Current.Server.MapPath("~/Xml/FHRS501en-GB.xml"));

            return xmlDocument;
        }

    }
}