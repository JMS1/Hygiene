namespace Hygiene.Migrations
{
    using Hygiene.Models;
    using Hygiene.Utility;
    using HygieneBO;
    using System;
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
            //XDocument xmlDocu = XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS501en-GB.xml");
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS502en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS503en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS504en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS505en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS506en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS508en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS507en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS509en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS510en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS511en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS512en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS513en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS514en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS515en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS516en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS517en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS518en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS519en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS520en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS521en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS522en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS523en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS524en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS525en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS526en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS527en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS528en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS529en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS530en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS531en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS532en-GB.xml").Root.Elements());
            //xmlDocu.Root.Add(XDocument.Load("http://ratings.food.gov.uk/OpenDataFiles/FHRS533en-GB.xml").Root.Elements());


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


                                  
            //                  };
            
            //        HygieneContext db = new HygieneContext();
            //        db.Restaurants.AddRange(restaurants);
            //        db.SaveChanges();
        }
    }
}
