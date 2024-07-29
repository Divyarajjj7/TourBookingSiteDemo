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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["home_start"] = "home";
            lbuser.Visible = false;
            user.Visible = false;
            if (Session["home_start"].ToString() == "home")
            {
                LinkButton linkButton = (LinkButton)Master.FindControl("Home");
                linkButton.Visible = false;
            }
            if ((string)Session["logedin"] == "loged_in")
            {
                lbuser.Visible = true;
                sitename.Visible = false;
                user.Visible = true;
                user.Text = Session["user"].ToString();
                lbuser.Text += Session["user"].ToString();
            }
            string sql = "select category_img, category_name from category where status=1";
            SqlDataAdapter da = new SqlDataAdapter(sql, DBClass.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
      
            string sql2 = "select * from gallery where status=1";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, DBClass.cn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            Repeater2.DataSource = dt2;
            Repeater2.DataBind();

        }
    }
}