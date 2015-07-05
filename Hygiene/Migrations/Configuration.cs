namespace Hygiene.Migrations
{
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

            foreach (XElement xe in xmlDoc.Descendants("EstablishmentDetail")) {
                context.Restaurants.AddOrUpdate(r => r.BusinessName, 
                    new Restaurant {
                    FHRSID = (int)xe.Element("FHRSID"),
                    BusinessName = xe.Element("BusinessName").Value,
                    AddressLine1 = UtilityFunctions.Addr1(xe),
                    AddressLine2 = UtilityFunctions.Addr2(xe),
                    PostCode = UtilityFunctions.PstCde(xe),
                    LocalAuthorityName = UtilityFunctions.AuthName(xe),
                    ImagePath = UtilityFunctions.Image(xe)
                    
                    },

                    )

            }

            context.Restaurants.AddOrUpdate(r => r.BusinessName,
                new Restaurant {},
                )

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
