using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_pageExample
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Write("<script>alert('No Session')</script>");
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                Label1.Text = Label1.Text + Session["user"].ToString();
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();


        }
    }
}