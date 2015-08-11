using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Hygiene.Models;
using HygieneBO;
using System.Xml.Linq;
using System.Net.Mail;
using System.Net;
using Hygiene.Utility;

namespace Hygiene.Utility
{
    public class ScheduledCheckSumCheck : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            string updatedRestaurantsemailBody = "Updated Restaurants" + Environment.NewLine;
            string newRestaurantsemailBody = "New Restaurants" + Environment.NewLine;
            HygieneContext db = new HygieneContext();

            foreach (District d in db.Districts)
            {

                XDocument xmlDoc = XDocument.Load(d.FileLocation);
                var xmlDocString = xmlDoc.ToString();
                var liveCheckSum = UtilityFunctions.GenerateCheckSum(xmlDocString);

                if (d.CheckSum != liveCheckSum)
                {
                    d.CheckSum = liveCheckSum;
                    d.CheckSumChanged = DateTime.Now;

                    var xmlRestaurants = from x in xmlDoc.Descendants("EstablishmentDetail")
                                         where UtilityFunctions.AuthName(x) == d.Name
                                         select new
                                         {
                                             FHRSID = UtilityFunctions.Id(x),
                                             BusinessName = UtilityFunctions.GetBusinessName(x),
                                             RatingValue = UtilityFunctions.GetRatingValue(x),
                                             AddressLine1 = UtilityFunctions.Addr1(x),
                                             AddressLine2 = UtilityFunctions.Addr2(x),
                                             AddressLine3 = UtilityFunctions.Addr3(x),
                                             AddressLine4 = UtilityFunctions.Addr4(x),
                                             PostCode = UtilityFunctions.PstCde(x),
                                             RatingDate = UtilityFunctions.GetRatingDate(x),
                                             LocalAuthorityName = UtilityFunctions.AuthName(x),
                                             Longitude = UtilityFunctions.GetLongitude(x),
                                             Latitude = UtilityFunctions.GetLatitude(x),
                                             ImagePath = UtilityFunctions.Image(x)
                                         };
                    foreach (var xmlRestaurant in xmlRestaurants)
                    {
                        bool restaurantExists;
                        try
                        {
                            restaurantExists = db.Restaurants.Any(re => re.FHRSID.Equals((int)xmlRestaurant.FHRSID));
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("message", ex);
                        }

                        if (restaurantExists)
                        {
                            int xmlDistrictId = UtilityFunctions.SetDistrictIdFromString(xmlRestaurant.LocalAuthorityName);

                            var restaurant = db.Restaurants.Single(r => r.FHRSID == xmlRestaurant.FHRSID);
                            restaurant.RatingValue = xmlRestaurant.RatingValue;
                            restaurant.RatingDate = xmlRestaurant.RatingDate;

                            var district = db.Districts.Single(di => di.DistrictId == xmlDistrictId);
                            district.CheckSum = liveCheckSum;
                            district.CheckSumChanged = DateTime.Now;

                            updatedRestaurantsemailBody += restaurant.BusinessName + "  " + restaurant.FHRSID + "  " + restaurant.DistrictId + Environment.NewLine;

                        }
                        else
                        {
                            //create new restaurant
                            var restaurant = new Restaurant();
                            restaurant.FHRSID = (int)xmlRestaurant.FHRSID;
                            restaurant.BusinessName = xmlRestaurant.BusinessName;
                            restaurant.RatingValue = (int)xmlRestaurant.RatingValue;
                            restaurant.AddressLine1 = xmlRestaurant.AddressLine1;
                            restaurant.AddressLine2 = xmlRestaurant.AddressLine2;
                            restaurant.AddressLine3 = xmlRestaurant.AddressLine3;
                            restaurant.AddressLine4 = xmlRestaurant.AddressLine4;
                            restaurant.PostCode = xmlRestaurant.PostCode;
                            restaurant.RatingDate = xmlRestaurant.RatingDate;
                            restaurant.DistrictId = UtilityFunctions.SetDistrictIdFromString(xmlRestaurant.LocalAuthorityName);
                            restaurant.Longitude = xmlRestaurant.Longitude;
                            restaurant.Latitude = xmlRestaurant.Latitude;
                            restaurant.ImagePath = xmlRestaurant.ImagePath;
                            db.Restaurants.Add(restaurant);

                            newRestaurantsemailBody += restaurant.BusinessName + "  " + restaurant.FHRSID + "  " + restaurant.DistrictId + Environment.NewLine; 
                        }
                    }
                }
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("message", ex);
            }

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(EmailInfo.emailAddress.Address, EmailInfo.password),
                Timeout = 20000
            };

            using (var message = new MailMessage(EmailInfo.emailAddress, EmailInfo.emailAddress)
            {
                Subject = EmailInfo.subject,
                Body = newRestaurantsemailBody + Environment.NewLine + updatedRestaurantsemailBody

            })
            {
                smtp.Send(message);
            }
        }
    }
}

