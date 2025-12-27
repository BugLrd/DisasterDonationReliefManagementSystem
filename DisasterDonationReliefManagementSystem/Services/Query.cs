using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DisasterDonationReliefManagementSystem.Services
{
    internal class Query
    {
        static SqlConnection con = new SqlConnection(@"Data Source=SHAYON\SQLEXPRESS;Initial Catalog=DisasterReliefDB;Integrated Security=True;Trust Server Certificate=True");

        public static SqlConnection GetConnection()
        {
            return con;
        }

        public static void Dispose()
        {
            con.Close();
        }
    }
}
