using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SAPHRDB
    {
        public static int GetIdByUsername(string username)
        {

            string connectionString = "Data Source = 153.109.124.35; Initial Catalog = PrinterDN; Persist Security Info = True; User ID = 6231db; Password = Pwd46231.; Pooling = False";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [SAPHR] WHERE  " +
                        " username = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return (int)dr["userId"];
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        public static void CreateSAPHR(int userID, string username)
        {
            string connectionString = "Data Source = 153.109.124.35; Initial Catalog = PrinterDN; Persist Security Info = True; User ID = 6231db; Password = Pwd46231.; Pooling = False";

            try
            {
                // Connexion to the Database
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    // The query
                    string query = "INSERT INTO SAPHR(userId,username) values(@userID,@username); SELECT SCOPE_IDENTITY()";

                    // Save the command
                    SqlCommand cmd = new SqlCommand(query, cn);


                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@username", username);


                    // Open the command
                    cn.Open();

                    // Execute the command
                    cmd.ExecuteScalar();


                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
