using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Hygiene.Utility
{
    public static class EmailInfo
    {
        public static MailAddress emailAddress = new MailAddress("JamesTest1982@gmail.com");
        public static string password = "Hola9000";
        public static string subject = "Database Updates for " + DateTime.Now;
    }
}