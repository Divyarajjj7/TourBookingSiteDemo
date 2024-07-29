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
    public partial class Purchase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from cart where status12='" + Session["user"] + "' and status=1 ";
            SqlDataAdapter da = new SqlDataAdapter(sql, DBClass.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();



            if (dt.Rows.Count >= 1)
            {
             
            }
            else
            {
                Response.Write("Your cart is empty");
            }
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

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void home_Click(object sender, EventArgs e)
        {
            string sql = "delete from cart where status12='" + Session["user"] + "'";
            SqlDataAdapter dad = new SqlDataAdapter(sql,DBClass.cn);
            DataTable dtd = new DataTable();
            dad.Fill(dtd);
        }
    }
}