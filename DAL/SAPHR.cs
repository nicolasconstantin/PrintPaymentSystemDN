using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SAPHR
    {
        public static String getUsernameByUid(String uid)
        {
            String account = "";

            string connectionString = ConfigurationManager.ConnectionStrings["db_API"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [SAPHR] WHERE  " +
                        " userId = @uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@uid", uid);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            account = (String)dr["username"];
                        }
                        else
                        {
                            account = "";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return account;
        }
    }
}
