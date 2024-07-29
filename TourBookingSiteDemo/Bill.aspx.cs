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
    public partial class Bill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select * from bookinginfo where bookingid='" + Request.QueryString["bookingid"] + "'";
            MySqlDataAdapter das = new MySqlDataAdapter(sel, DBClass.cn);
            DataTable dts = new DataTable();
            das.Fill(dts);
            Panel1.Visible = true;
            lb_Bookingdate.Text = dts.Rows[0]["booking_date"].ToString();
        }
    }
}