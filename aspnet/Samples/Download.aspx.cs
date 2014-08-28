using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnet.Samples
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(@"C:\Users\v-jayao\Desktop\aa.txt"); // "report.csv"
            Context.Response.Clear();
            Context.Response.ClearHeaders();
            Context.Response.ClearContent();
            Context.Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
            Context.Response.AddHeader("Content-Length", file.Length.ToString());
            Context.Response.ContentType = "text/csv";
            Context.Response.Flush();
            Context.Response.TransmitFile(@"C:\Users\v-jayao\Desktop\hh.txt");
            Context.Response.End();
        }
    }
}