using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ADDB
    {
        public static string GetUserAccount(string username)
        {
            string account = "";

            string connectionString = "Data Source = 153.109.124.35; Initial Catalog = PrinterDN; Persist Security Info = True; User ID = 6231db; Password = Pwd46231.; Pooling = False";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [AD] WHERE username = @username";
                    // Save command
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            account = (string)dr["username"] + (string)dr["password"];
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

        public static AD CreateUser(AD User)
        {
            string connectionString = "Data Source = 153.109.124.35; Initial Catalog = PrinterDN; Persist Security Info = True; User ID = 6231db; Password = Pwd46231.; Pooling = False";

            try
            {
                // Connexion to the Database
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    // The query
                    string query = "INSERT INTO AD(firstname,lastname,password,username) values(@Firstname,@Lastname,@password,@username); SELECT SCOPE_IDENTITY()";

                    // Save the command
                    SqlCommand cmd = new SqlCommand(query, cn);


                    cmd.Parameters.AddWithValue("@Firstname", User.Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", User.Lastname);
                    cmd.Parameters.AddWithValue("@password", User.Password);
                    cmd.Parameters.AddWithValue("@username", User.Username);


                    // Open the command
                    cn.Open();

                    // Execute the command
                    User.UserId = Convert.ToInt32(cmd.ExecuteScalar());


                }
            }
            catch (Exception e)
            {
                throw e;
            }
            // Return the customer
            return User;
        }

    }
}
