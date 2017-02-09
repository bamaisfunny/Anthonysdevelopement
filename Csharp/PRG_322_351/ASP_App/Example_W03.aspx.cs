using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Week1_prg;

namespace ASP_App
{
    public partial class Example_W03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student s = new Student("Anthony", 28, "???", "Searles");
            Response.Write(s.LastName);
        }
    }
}