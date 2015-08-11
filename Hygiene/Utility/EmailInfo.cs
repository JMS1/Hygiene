using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Hygiene.Utility
{
    public static class EmailInfo
    {
        int test = 32;
        public readonly static MailAddress emailAddress = new MailAddress("JamesTest1982@gmail.com");
        public readonly static const string password = "Hola9000";
        public readonly static string subject = "Database Updates for " + DateTime.Now;
    }
}