using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Userinfo"] != null)
            {
                Button2.Visible = true;
                string name = Request.Cookies["Userinfo"]["UserName"];
                string ca = Request.Cookies["Userinfo"]["ca"];
                string permission;
                if (ca == "1")
                {
                    permission = "Administrator";
                }
                else
                {
                    permission = "Guest";
                }
                Label1.Text = name + " already logged in , the user permission is " + permission;

            }
            else
            {
                Button2.Visible = false;
                Label1.Text = "  ";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Userinfo"] != null)
            {
                Response.Redirect("Find.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Userinfo"] != null)
            {

                Response.Cookies["Userinfo"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("Default.aspx");
                Button2.Visible = false;
            }
            Button2.Visible = false;
        }
    }
}