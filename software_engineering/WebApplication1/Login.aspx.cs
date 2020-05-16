using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataClasses1DataContext linq;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr1 = @"Data Source=.\SQLEXPRESS;Initial Catalog=Engineer;uid=sa;pwd=123456";
            linq = new DataClasses1DataContext(connStr1);
            

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            e.Authenticated = false;
            // t_user user = new t_user();
            var result = from item in linq.t_user
                          where item.account == Login1.UserName && item.password == Login1.Password
                          select item.category;
            if(result.Count()!=0)
            {
                e.Authenticated = true;
                
                if(result.First()==1)
                {

                    Response.Cookies["Userinfo"]["UserName"] = Login1.UserName;
                    Response.Cookies["Userinfo"]["ca"] = "1";
                    Response.Cookies["Userinfo"].Expires = DateTime.Now.AddDays(1d);
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Response.Cookies["Userinfo"]["UserName"] = Login1.UserName;
                    Response.Cookies["Userinfo"]["ca"] = "2";
                    Response.Cookies["Userinfo"].Expires = DateTime.Now.AddDays(1d);
                    Response.Redirect("Default.aspx");
                }

                //Response.Redirect("Default.aspx");
            }
            else
            {

                //Label1.Text = user.password;
                e.Authenticated = false;
            }

        }
    }
}