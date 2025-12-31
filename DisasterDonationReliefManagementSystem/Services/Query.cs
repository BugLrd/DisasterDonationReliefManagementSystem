using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DisasterDonationReliefManagementSystem.Services
{
    internal class Query
    {
        static SqlConnection con = new SqlConnection(@"Data Source=shayon\SQLEXPRESS;Initial Catalog=DisasterDonationReliefDB;Integrated Security=True;Trust Server Certificate=True");

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
