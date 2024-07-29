using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TourBookingSiteDemo
{
    public class DBClass
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Aatman\TourBookingSiteDemo\TourBookingSiteDemo\regs.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    }
}