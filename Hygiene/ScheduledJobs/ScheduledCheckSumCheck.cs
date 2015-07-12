using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Hygiene.Models;
using HygieneBO;
using System.Xml.Linq;

namespace Hygiene.Utility
{
    public class ScheduledCheckSumCheck : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //declare a bool, if something is updated change bool to true, at the end of class build a string with details
            HygieneContext db = new HygieneContext();

            var xmlDocu = UtilityFunctions.BuildXDoc();

            //public static XDocument GetLiveXML(string districtName){
            //    XDocument liveXml = new XDocument();

            //    if (db.)
            //}
            var newCheckSums = new List<CheckSumVersion>();

            foreach (District d in db.Districts)
            {

                XDocument xmlDoc = XDocument.Load(d.FileLocation);
                var xmlDocString = xmlDoc.ToString();
                var liveCheckSum = UtilityFunctions.GenerateCheckSum(xmlDocString);




                foreach (CheckSumVersion v in db.Versions)
                {

                    if (v.CheckSum != liveCheckSum)
                    {
                        foreach (District e in db.Districts)
                        {
                                e.CheckSumVersionId = 
                        }


                        var versionQuery = from restaurant in db.Restaurants
                                           join version in db.Versions
                                           on restaurant.VersionId equals version.CheckSumVersionId
                                           select restaurant;

                       

                        //create a list of changed 
                        CheckSumVersion newVersion = new CheckSumVersion();
                        newVersion.CheckSum = liveCheckSum;
                        newVersion.DateChanged = DateTime.Now;
                        newCheckSums.Add(newVersion);
                        db.Versions.AddRange(newCheckSums);

                        using (db)
                        {
                            db.Restaurants
                                //.Where()
                                .ToList()
                                .ForEach(r =>
                                            {
                                                r.VersionId = newVersion.CheckSumVersionId;
                                            });
                        }


                    }
                    else
                    { }
                }
            }
            
            db.SaveChanges();

        }

    }
}
//create a list of change checksums inner join to customer 
//add newversion.id to change in database

