using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Manage : System.Web.UI.Page
    {

        DataClasses1DataContext linq;
        static string temp;
        public void dataload()
        {

            string connStr1 = @"Data Source=.\SQLEXPRESS;Initial Catalog=Engineer;uid=sa;pwd=123456";
            linq = new DataClasses1DataContext(connStr1);
            var result = from item in linq.Eng_info
                         select new
                         {
                             姓名 = item.name,
                             编号 = item.no,
                             学历 = item.education,
                             工龄 = item.working_age,
                             薪水 = item.basic_salary,
                             电话 = item.telephone,
                             地址 = item.address,
                             性别 = item.sex,
                             生日 = item.birthday,
                             
                         };
            GridView1.DataSource = result;

            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Request.Cookies["Userinfo"] != null)
            {
                string name = Request.Cookies["Userinfo"]["UserName"];
                string ca = Request.Cookies["Userinfo"]["ca"];
                if (ca == "1")
                {
                    dataload();

                }
                else
                {
                    Response.Redirect("Perror.aspx");
                }
            }
            else Response.Redirect("Login.aspx");
            if (!IsPostBack)
            {
                Button5.Enabled = false;


                Label_at.Text = "Select first, then operate";

            }
        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanging1(object sender, GridViewSelectEventArgs e)
        {
            TextBox1.Text = GridView1.Rows[e.NewSelectedIndex].Cells[1].Text.Trim();
            TextBox2.Text = GridView1.Rows[e.NewSelectedIndex].Cells[2].Text.Trim();
            TextBox3.Text = GridView1.Rows[e.NewSelectedIndex].Cells[3].Text.Trim();
            TextBox4.Text = GridView1.Rows[e.NewSelectedIndex].Cells[4].Text.Trim();
            TextBox5.Text = GridView1.Rows[e.NewSelectedIndex].Cells[5].Text.Trim();
            TextBox6.Text = GridView1.Rows[e.NewSelectedIndex].Cells[6].Text.Trim();
            TextBox7.Text = GridView1.Rows[e.NewSelectedIndex].Cells[7].Text.Trim();
            TextBox8.Text = GridView1.Rows[e.NewSelectedIndex].Cells[8].Text.Trim();
            TextBox9.Text = GridView1.Rows[e.NewSelectedIndex].Cells[9].Text.Trim();
            temp = GridView1.Rows[e.NewSelectedIndex].Cells[2].Text.Trim();
            Button5.Enabled = true;
            Button4.Enabled = true;
            Button3.Enabled = true;
            Label_at.Text = "please operate";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int flag = 1;
            Eng_info ef = new Eng_info();
            ef.name = TextBox1.Text.Trim();
            ef.no = TextBox2.Text.Trim();
            if (TextBox3.Text.Trim() == "男" || TextBox3.Text.Trim() == "女")
            {
                ef.sex = TextBox3.Text.Trim();
            }
            else
            {
                flag = 0;
                Label_st.Text = "Add->ERROR，性别只能为男或女";
            }

            ef.address = TextBox4.Text.Trim();
            ef.telephone = TextBox5.Text.Trim();
            try
            {
                ef.working_age = Convert.ToInt32(TextBox6.Text.Trim());
            }
            catch (Exception error)
            {
                Label_st.Text = "Add->ERROR，工龄不是整数型";
                flag = 0;
            }
            ef.basic_salary = TextBox7.Text;
            try
            {
                ef.birthday = Convert.ToDateTime(TextBox8.Text.Trim());
            }
            catch (Exception error)
            {
                Label_st.Text = "Add->ERROR，生日不是日期型 格式为：YYYY-MM-DD";
                flag = 0;
            }
            ef.education = TextBox9.Text.Trim();
            var jugle = from item in linq.Eng_info
                        where item.no == ef.no
                        select item;
            if (jugle.Count() == 0 && flag == 1 && TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "")
            {
                linq.Eng_info.InsertOnSubmit(ef);
                linq.SubmitChanges();
                dataload();
                Label_st.Text = "Add->succeed！";
                Button5.Enabled = false;


                Label_at.Text = "Select first, then operate";
            }
            else if (jugle.Count() != 0 && flag == 1)
            {
                Label_st.Text = "Add->ERROR,编号重复！";
            }
            else if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == "")
            {
                Label_st.Text = "Add->ERROR,有内容为空！";
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var del = from item in linq.Eng_info
                      where item.no == TextBox2.Text
                      select item;
            if (del.Count() != 0)
            {
                linq.Eng_info.DeleteAllOnSubmit(del);
                linq.SubmitChanges();
                dataload();
                Label_st.Text = "Delete->succeed";
                Button5.Enabled = false;


                Label_at.Text = "Select first, then operate";
            }
            else Label_st.Text = "Delete->ERROR,编号为空或者不存在";

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            int flag = 1;
            var up = from item in linq.Eng_info
                     where item.no == TextBox2.Text
                     select item;
            if (up.Count() != 0)
            {
                foreach (Eng_info ef in up)
                {
                    ef.name = TextBox1.Text.Trim();
                    ef.no = TextBox2.Text.Trim();
                    if (TextBox3.Text.Trim() == "男" || TextBox3.Text.Trim() == "女")
                    {
                        ef.sex = TextBox3.Text.Trim();
                    }
                    else
                    {
                        flag = 0;
                        Label_st.Text = "Alter->ERROR，性别只能为男或女";
                    }
                    ef.address = TextBox4.Text.Trim();
                    ef.telephone = TextBox5.Text.Trim();
                    try
                    {
                        ef.working_age = Convert.ToInt32(TextBox6.Text.Trim());
                    }
                    catch (Exception error)
                    {
                        Label_st.Text = "Alter->ERROR，工龄不是整数型";
                        flag = 0;
                    }

                    ef.basic_salary = TextBox7.Text.Trim();
                    try
                    {
                        ef.birthday = Convert.ToDateTime(TextBox8.Text.Trim());
                    }
                    catch (Exception error)
                    {
                        Label_st.Text = "Alter->ERROR，生日不是日期型 格式为：YYYY-MM-DD";
                        flag = 0;
                    }
                    ef.education = TextBox9.Text;
                    if (flag == 1 && TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "")
                    {
                        if (TextBox2.Text != temp)
                        {
                            var del = from item in linq.Eng_info
                                      where item.no == temp
                                      select item;

                            linq.Eng_info.DeleteAllOnSubmit(del);
                        }



                        linq.SubmitChanges();
                    }

                }
                if (flag == 1 && TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "")
                {
                    dataload();
                    Label_st.Text = "Alter->Succeed";
                    Button5.Enabled = false;


                    Label_at.Text = "Select first, then operate";
                }
                else if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == "")
                {
                    Label_st.Text = "Alter->ERROR,有内容为空！";
                }
            }
            else
            {
                Eng_info ef = new Eng_info();
                ef.name = TextBox1.Text.Trim();
                ef.no = TextBox2.Text.Trim();
                ef.sex = TextBox3.Text.Trim();
                ef.address = TextBox4.Text.Trim();
                ef.telephone = TextBox5.Text.Trim();
                try
                {
                    ef.working_age = Convert.ToInt32(TextBox6.Text.Trim());
                }
                catch (Exception error)
                {
                    Label_st.Text = "Alter->ERROR，工龄不是整数型";
                    flag = 0;
                }

                ef.basic_salary = TextBox7.Text.Trim();
                try
                {
                    ef.birthday = Convert.ToDateTime(TextBox8.Text.Trim());
                }
                catch (Exception error)
                {
                    Label_st.Text = "Alter->ERROR，生日不是日期型 格式为：YYYY-MM-DD";
                    flag = 0;
                }
                ef.education = TextBox9.Text;
                if (flag == 1 && TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "")
                {
                    var del = from item in linq.Eng_info
                              where item.no == temp
                              select item;

                    linq.Eng_info.DeleteAllOnSubmit(del);
                    linq.Eng_info.InsertOnSubmit(ef);
                    linq.SubmitChanges();
                    dataload();
                    Label_st.Text = "Alter->Succeed";
                    Button5.Enabled = false;


                    Label_at.Text = "Select first, then operate";

                }
                else if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == "")
                {
                    Label_st.Text = "Alter->ERROR,有内容为空！";
                }

            }




        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}