using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TourBookingSiteDemo
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["register_start"] = "register";
            if (Session["register_start"].ToString() == "register")
            {
                Button button = (Button)Master.FindControl("btnregister");
                button.Visible = false;
                rgmessage.Visible = false;
                rgmessage2.Visible = false;
                rgmessage3.Visible = false;
                rgmsgemail.Visible = false;

            }
        }

        protected void rgbtnregister_Click(object sender, EventArgs e)
        {
            string sql = "select rgusername from reg_user where rgusername='" + rgusername.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, DBClass.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string sql1 = "select rgemail from reg_user where rgemail='" + rgemail.Text + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, DBClass.cn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt.Rows.Count >= 1)
            {
                rgmessage3.Visible = true;


            }
            if (dt1.Rows.Count >= 1)
            {
                rgmsgemail.Visible = true;


            }
            else
            {
                rgmessage3.Visible = false;
                rgmsgemail.Visible = false;

                string sql2 = "insert into reg_user values('" + rgusername.Text + "','" + rgemail.Text + "','" + rgpassword.Text + "')";
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, DBClass.cn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if (!da2.Equals(null))
                {
                    rgmessage.Visible = true;
                    Response.Redirect("login.aspx");
                }
                else
                {
                    rgmessage2.Visible = true;
                }
            }
        }

        protected void rgbtnClear_Click(object sender, EventArgs e)
        {
            rgemail.Text = rgpassword.Text = rgusername.Text = rgretypepassword.Text = "";
            rgusername.Focus();
        }

        protected void login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}