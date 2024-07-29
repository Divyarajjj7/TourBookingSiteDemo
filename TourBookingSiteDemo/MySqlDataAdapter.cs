using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TourBookingSiteDemo
{
    class MySqlDataAdapter
    {
        private string sel;
        private System.Data.SqlClient.SqlConnection sqlConnection;

        public MySqlDataAdapter(string sel, System.Data.SqlClient.SqlConnection sqlConnection)
        {
            // TODO: Complete member initialization
            this.sel = sel;
            this.sqlConnection = sqlConnection;
        }

        internal void Fill(System.Data.DataTable dts)
        {
            throw new NotImplementedException();
        }
    }
}
