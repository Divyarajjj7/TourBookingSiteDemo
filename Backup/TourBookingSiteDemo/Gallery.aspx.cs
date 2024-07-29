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
    public partial class Gallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string place_name = (string)Request.QueryString["galname"];
            if ((string)Session["logedin"] == "loged_in")
            {
                string sql = "select * from gallery where gallery_image_name='" + place_name + "' ";
                SqlDataAdapter da = new SqlDataAdapter(sql, DBClass.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (!IsPostBack)
                {
                    placename.Text = (string)dt.Rows[0]["gallery_image_name"];
                    place_image.ImageUrl = (string)dt.Rows[0]["gallery_imgpath"];
                    price.Text = dt.Rows[0]["Price"].ToString();
           
                }

            }
            else
            {
                msg1.Text = "You are not login";
                home.Visible = true;
                galbook.Visible = false;
            }
        }







        protected void book_Click(object sender, EventArgs e)
        {
            string place_name = (string)Request.QueryString["galname"];
            string sql = "select * from gallery where gallery_image_name='" + place_name + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, DBClass.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string sql1 = "insert into cart values('" + placename.Text + "','" + dt.Rows[0]["gallery_imgpath"] + "' , '" + dt.Rows[0]["price"] + "' , '" + Session["user"] + "' , 1 ,  '"+bookingid+"')";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, DBClass.cn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            Response.Redirect("cart.aspx");

        }

        protected void cancel_Click(object sender, EventArgs e)
        {

        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        public void findbookingid()
        {
            string pass = "0123456789";
            Random r = new Random();
            char[] mypass = new char[5];
            for (int i = 0; i < 5; i++)
            {
                mypass[i] = pass[(int)(35 * r.NextDouble())];
            }
            string orderid;
            orderid =  new string(mypass);
            bookingid = orderid;
        }
        protected void book_Click1(object sender, EventArgs e)
        {
            
            string place_name = (string)Request.QueryString["galname"];
            string sql = "select * from gallery where gallery_image_name='" + place_name + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, DBClass.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string sql1 = "insert into cart values('" + placename.Text + "','" + dt.Rows[0]["gallery_imgpath"] + "' , '" + dt.Rows[0]["price"] + "' , '" + Session["user"] + "' , 1,0)";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, DBClass.cn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            Response.Redirect("cart.aspx");
        }

        public string bookingid { get; set; }

        protected void home_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");  
        }

        protected void cancel_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Gallery.aspx");
        }
    }
}