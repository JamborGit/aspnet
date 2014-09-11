using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnet
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string calculateddate = "2014-09-05T23:39:57-04:00";
            var date = DateTime.Parse(calculateddate);
            var s = Convert.ToDateTime(calculateddate);
            string format = "ddd dd MMM yyyy h:mm tt zzz";
            string dateString = "15/06/2008 08:30";
            var provider = new CultureInfo("fr-FR");
           

            var dt = ToDateTimeFromUTCISO8601(@"2010-08-20T15:00:00Z");


          //  var utcDT = dt.Value.ToUniversalTime();

        }


        static DateTime? ToDateTimeFromUTCISO8601(string dateTimeString)
        {
            DateTime dt;
            var sucessed = DateTime.TryParseExact(dateTimeString, new string[] { @"yyyy-MM-dd\THH:mm:ss\Z", "o" }, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out dt);


            return sucessed ? new DateTime?(dt) : null;

        }


    }
}