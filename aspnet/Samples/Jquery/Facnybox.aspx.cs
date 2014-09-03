using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace aspnet.Samples.Jquery
{
    public partial class Facnybox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]

        public static string GetLocation(int cityId)
        {

            List<Location> list = new List<Location>(){
             new Location(){cityId=1000,cityName="city01"},
             new Location(){cityId=1002,cityName="city01"},
               new Location(){cityId=1001,cityName="city01"},
                 new Location(){cityId=1003,cityName="city01"},
                   new Location(){cityId=1004,cityName="city01"}
            };
           list= list.Where(c => c.cityId == cityId).ToList<Location>();

           return JsonConvert.SerializeObject(list);
        }

    }
    public class Location
    {
        public int cityId { get; set; }
        public string cityName { get; set; }
    }
}