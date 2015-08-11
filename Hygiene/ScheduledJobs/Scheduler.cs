﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Quartz.Impl;
using Hygiene.Utility;


namespace Hygiene.ScheduledJobs
{
    public class Scheduler
    {
        public static void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

            scheduler.Start();

            IJobDetail job = JobBuilder.Create<ScheduledCheckSumCheck>().Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithDailyTimeIntervalSchedule
                (s =>
                s.WithIntervalInHours(24)
                .OnEveryDay()
                .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(0, 0))
                )
                .Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}