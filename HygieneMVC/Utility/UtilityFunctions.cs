using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HygieneMVC.Utility
{
    public static class UtilityFunctions
    {
        public static string test(int DistrictNumber){
               if (DistrictNumber != 99)
               {
                   return "Test";
               }
               else return "Testee";
            }

        public static MvcHtmlString Format(this HtmlHelper helper, int value)
        {
            string result = "";
            if (value != 99)
            {
               result = "Test";
            }
            else result = "Testee";
            return new MvcHtmlString(result);
        }

        public static string SetDistrictIdFromString(int n)
        {
           
            string authorityName;

            if (n == null)
                authorityName = "";

            switch (n)
            {
                case 1:
                    authorityName = "Barking and Dagenham";
                    break;
                case 2:
                    authorityName = "Barnet";
                    break;
                case 3:
                    authorityName = "Bexley";
                    break;
                case 4:
                    authorityName = "Brent";
                    break;
                case 5:
                    authorityName = "Bromley";
                    break;
                case 6:
                    authorityName = "Camden";
                    break;
                case 7:
                    authorityName = "City of London Corporation";
                    break;
                case 8:
                    authorityName = "Croydon";
                    break;
                case 9:
                    authorityName = "Ealing";
                    break;
                case 10:
                    authorityName = "Enfield";
                    break;
                case 11:
                    authorityName = "Greenwich";
                    break;
                case 12:
                    authorityName = "Hackney";
                    break;
                case 13:
                    authorityName = "Hammersmith and Fulham";
                    break;
                case 14:
                    authorityName = "Haringey";
                    break;
                case 15:
                    authorityName = "Harrow";
                    break;
                case 16:
                    authorityName = "Havering";
                    break;
                case 17:
                    authorityName = "Hillingdon";
                    break;
                case 18:
                    authorityName = "Hounslow";
                    break;
                case 19:
                    authorityName = "Islington";
                    break;
                case 20:
                    authorityName = "Kensington and Chelsea";
                    break;
                case 21:
                    authorityName = "Kingston-Upon-Thames";
                    break;
                case 22:
                    authorityName = "Lambeth";
                    break;
                case 23:
                    authorityName = "Lewisham";
                    break;
                case 24:
                    authorityName = "Merton";
                    break;
                case 25:
                    authorityName = "Newham";
                    break;
                case 26:
                    authorityName = "Redbridge";
                    break;
                case 27:
                    authorityName = "Richmond-Upon-Thames";
                    break;
                case 28:
                    authorityName = "Southwark";
                    break;
                case 29:
                    authorityName = "Sutton";
                    break;
                case 30:
                    authorityName = "Tower Hamlets";
                    break;
                case 31:
                    authorityName = "Waltham Forest";
                    break;
                case 32:
                    authorityName = "Wandsworth";
                    break;
                case 33:
                    authorityName = "Westminster";
                    break;
                default:
                    authorityName = "";
                    break;
            }
            return authorityName;
        }
    }
    
}