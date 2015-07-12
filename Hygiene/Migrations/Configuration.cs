namespace Hygiene.Migrations
{
    using Hygiene.Models;
    using Hygiene.Utility;
    using HygieneBO;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;
    using System.Web;
    using System.Xml.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hygiene.Models.HygieneContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Hygiene.Models.HygieneContext context)
        {
            //Seed the database
            //HygieneContext db = new HygieneContext();
            //var xmlDocu = UtilityFunctions.BuildXDoc();

            //var restaurants = from r in xmlDocu.Descendants("EstablishmentDetail")
            //                  select new Restaurant
            //                  {
            //                      FHRSID = UtilityFunctions.GetFHRSIDValue(r),
            //                      BusinessName = UtilityFunctions.GetBusinessName(r),
            //                      AddressLine1 = UtilityFunctions.Addr1(r),
            //                      AddressLine2 = UtilityFunctions.Addr2(r),
            //                      AddressLine3 = UtilityFunctions.Addr3(r),
            //                      AddressLine4 = UtilityFunctions.Addr4(r),
            //                      PostCode = UtilityFunctions.PstCde(r),
            //                      RatingKey = UtilityFunctions.GetRatingKey(r),
            //                      RatingValue = UtilityFunctions.GetRatingValue(r),
            //                      RatingDate = UtilityFunctions.GetRatingDate(r),
            //                      Longitude = UtilityFunctions.GetLongitude(r),
            //                      Latitude = UtilityFunctions.GetLatitude(r),
            //                      DistrictId = UtilityFunctions.SetDistrictId(r),
            //                      ImagePath = UtilityFunctions.Image(r)
                                //};

            //db.Restaurants.AddRange(restaurants);
            //db.SaveChanges();

            //var districts = new List<District>
            //{
            //    new District {Name = "Barking and Dagenham", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS501en-GB.xml" },
            //    new District {Name = "Barnet", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS502en-GB.xml" },
            //    new District {Name = "Bexley", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS503en-GB.xml" },
            //    new District {Name = "Brent", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS504en-GB.xml" },
            //    new District {Name = "Bromley", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS505en-GB.xml" },
            //    new District {Name = "Camden", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS506en-GB.xml" },
            //    new District {Name = "City of London Corporation", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS508en-GB.xml" },
            //    new District {Name = "Croydon", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS507en-GB.xml" },
            //    new District {Name = "Ealing", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS509en-GB.xml" },
            //    new District {Name = "Enfield", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS510en-GB.xml" },
            //    new District {Name = "Greenwich", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS511en-GB.xml" },
            //    new District {Name = "Hackney", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS512en-GB.xml" },
            //    new District {Name = "Hammersmith and Fulham", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS513en-GB.xml" },
            //    new District {Name = "Haringey", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS514en-GB.xml" },
            //    new District {Name = "Harrow", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS515en-GB.xml" },
            //    new District {Name = "Havering", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS516en-GB.xml" },
            //    new District {Name = "Hillingdon", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS517en-GB.xml" },
            //    new District {Name = "Hounslow", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS518en-GB.xml" },
            //    new District {Name = "Islington", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS519en-GB.xml" },
            //    new District {Name = "Kensington and Chelsea", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS520en-GB.xml" },
            //    new District {Name = "Kingston-Upon-Thames", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS521en-GB.xml" },
            //    new District {Name = "Lambeth", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS522en-GB.xml" },
            //    new District {Name = "Lewisham", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS523en-GB.xml" },
            //    new District {Name = "Merton", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS524en-GB.xml" },
            //    new District {Name = "Newham", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS525en-GB.xml" },
            //    new District {Name = "Redbridge", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS526en-GB.xml" },
            //    new District {Name = "Richmond-Upon-Thames", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS527en-GB.xml" },
            //    new District {Name = "Southwark", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS528en-GB.xml" },
            //    new District {Name = "Sutton", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS529en-GB.xml" },
            //    new District {Name = "Tower Hamlets", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS530en-GB.xml" },
            //    new District {Name = "Waltham Forest", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS531en-GB.xml" },
            //    new District {Name = "Wandsworth", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS532en-GB.xml" },
            //    new District {Name = "Westminster", FileLocation = "http://ratings.food.gov.uk/OpenDataFiles/FHRS533en-GB.xml" },


            //};

            //districts.ForEach(d => db.Districts.AddOrUpdate(p => p.Name, d));
            //db.SaveChanges();
        }
    }
}
