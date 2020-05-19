using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ADDB
    {
        public static String getUserAccount(String username)
        {
            String account = "";

            string connectionString = ConfigurationManager.ConnectionStrings["db_API"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [AD] WHERE userId = @username";
                    // Save command
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            account = (string)dr["userId"];
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
