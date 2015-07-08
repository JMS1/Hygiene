namespace Hygiene.Migrations
{
    using Hygiene.Models;
    using Hygiene.Utility;
    using HygieneBO;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
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
            XDocument xmlDoc = UtilityFunctions.BuildXDoc();

            var seedRestaurants = from r in xmlDoc.Descendants("EstablishmentDetail")
                                  select new Restaurant
                                  {
                                      FHRSID = (int)r.Element("FHRSID"),
                                      BusinessName = r.Element("BusinessName").Value,
                                      AddressLine1 = r.Element("AddressLine1").Value,
                                      AddressLine2 = r.Element("AddressLine2").Value,
                                      AddressLine3 = r.Element("AddressLine3").Value,
                                      AddressLine4 = r.Element("AddressLine4").Value,
                                      PostCode = r.Element("PostCode").Value,
                                      RatingValue = (int)r.Element("RatingValue"),
                                      RatingDate = r.Element("RatingDate").Value,
                                      HygieneScore = (int)r.Element("Scores").Element("Hygiene"),
                                      Longitude = (double)r.Element("GeoCode").Element("Longitude"),
                                      Latitude = (double)r.Element("GeoCode").Element("Latitude"),
                                      //ImagePath = r.Element().Value

                                  };
            HygieneContext db = new HygieneContext();


            //foreach (XElement xe in xmlDoc.Descendants("EstablishmentDetail")) {
            //    context.Restaurants.AddOrUpdate(r =>  new Restaurant {
            //        FHRSID = (int)xe.Element("FHRSID"),
            //        BusinessName = xe.Element("BusinessName").Value,
            //        AddressLine1 = UtilityFunctions.Addr1(xe),
            //        AddressLine2 = UtilityFunctions.Addr2(xe),
            //        PostCode = UtilityFunctions.PstCde(xe),
            //        D = UtilityFunctions.AuthName(xe),
            //        ImagePath = UtilityFunctions.Image(xe)
                    
            //        },

            //        )

            //}

            //context.Restaurants.AddOrUpdate(r => r.BusinessName,
            //    new Restaurant {},
            //    )

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
