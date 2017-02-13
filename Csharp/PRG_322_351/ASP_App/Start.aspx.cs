using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Week1_prg;
using Serializer;

namespace ASP_App
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        printStudent s;
        Student x;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            x = new Student("Anthony", 28,"Blonde", "Searles");
            s = new printStudent();
            Response.Redirect("printStudent.aspx");
        }
    }
}