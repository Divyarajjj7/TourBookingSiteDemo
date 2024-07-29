using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web.UI.WebControls;

namespace TourBookingSiteDemo
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["logedin"] == "loged_in")
            {
                string user = (string)Session["user"];
                string sql = "select * from cart where status12='" + Session["user"] + "' and status=1  ";
                SqlDataAdapter da = new SqlDataAdapter(sql, DBClass.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else
                {
                    cart.Visible = false;
                    msgcart1.Visible = true;

                }
            }
            else
            {
                msgcart.Visible = true;
            }


        }

        protected void purchase_Click(object sender, EventArgs e)
        {
            Response.Redirect("purchase.aspx");
        }
        public string sum()
        {
            string sql = "select SUM(price) from cart where status12='" + Session["user"] + "' and status=1 ";
            SqlCommand cmd = new SqlCommand(sql, DBClass.cn);
            DBClass.cn.Open();
            int sum = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            DBClass.cn.Close();
            cmd.Dispose();

            return Convert.ToString(sum);
        }

    }
}