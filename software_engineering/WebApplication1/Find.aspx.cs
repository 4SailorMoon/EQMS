using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Find : System.Web.UI.Page
    {
        DataClasses1DataContext linq;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Userinfo"] != null)
            {
                string name = Request.Cookies["Userinfo"]["UserName"];
                string ca = Request.Cookies["Userinfo"]["ca"];
            }
            else Response.Redirect("Login.aspx");
            string connStr1 = @"Data Source=.\SQLEXPRESS;Initial Catalog=Engineer;uid=sa;pwd=123456";
            linq = new DataClasses1DataContext(connStr1);
            var result = from item in linq.Eng_info
                         select new
                         {
                             姓名 = item.name,
                             编号 = item.no,
                             性别 = item.sex,
                             地址 = item.address,
                             电话 = item.telephone,
                             工龄 = item.working_age,
                             薪水 = item.basic_salary,
                             生日 = item.birthday,
                             学历 = item.education,
                         };
            GridView1.DataSource = result;

            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var result = from item in linq.Eng_info
                         where item.name==TextBox1.Text ||
                         item.no == TextBox1.Text ||
                         item.sex == TextBox1.Text ||
                         item.address == TextBox1.Text ||
                         item.telephone == TextBox1.Text ||
                         item.basic_salary == TextBox1.Text ||
                         item.education == TextBox1.Text 
                         select new
                         {
                             姓名 = item.name,
                             编号 = item.no,
                             性别 = item.sex,
                             地址 = item.address,
                             电话 = item.telephone,
                             工龄 = item.working_age,
                             基本薪水 = item.basic_salary,
                             生日 = item.birthday,
                             学历 = item.education
                         };
            GridView1.DataSource = result;

            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            var result = from item in linq.Eng_info
                         select new
                         {
                             姓名 = item.name,
                             编号 = item.no,
                             性别 = item.sex,
                             地址 = item.address,
                             电话 = item.telephone,
                             工龄 = item.working_age,
                             基本薪水 = item.basic_salary,
                             生日 = item.birthday,
                             学历 = item.education
                         };
            GridView1.DataSource = result;

            GridView1.DataBind();
        }
    }
}