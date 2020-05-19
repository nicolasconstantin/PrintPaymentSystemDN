using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaymentDB
    {
        public static decimal getAllPaymentByUsername(String username)
        {
            // Creation of a list
            List<decimal> results = null;

            // Connexion to the database
            string connectionString = ConfigurationManager.ConnectionStrings["db_API"].ConnectionString;

            try
            {
                // object to connect the database
                using (SqlConnection cn = new SqlConnection(connectionString))
                {

                    // Query
                    string query = "Select * from Payment WHERE userId = @username";

                    // Save command
                    SqlCommand cmd = new SqlCommand(query, cn);


                    cmd.Parameters.AddWithValue("@username", username); // Against Insertion 


                    // Opening of the command
                    cn.Open();


                    // Execute the Reader
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Listening / Reading of the result
                        while (dr.Read())
                        {
                            // Result of the query
                            if (results == null)
                                results = new List<decimal>();



                            results.Add((decimal)dr["quota"]);

                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            decimal amount = 0;

            foreach (decimal p in results)
            {
                amount = amount + p;
            }


            // return a list of booking
            return amount;
        }

        public static int AddQuotaById(string uid, decimal quotas)
        {
            int result = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["db_API"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    // Query -> Insert
                    string query = "Insert into Payment(quota, userId) values(@quotas, @username)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@quotas", quotas); // Against Insertion 
                    cmd.Parameters.AddWithValue("@username", uid); // Against Insertion 

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            // return the stat
            return result;
        }

        public static int AddQuotaByUsername(string username, decimal quotas)
        {
            int result = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["db_API"].ConnectionString;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    // Query -> Insert
                    string query = "Insert into Payment(quota, userId) values(@quotas, @username)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@quotas", quotas); // Against Insertion 
                    cmd.Parameters.AddWithValue("@username", username); // Against Insertion 

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            // return the stat
            return result;
        }
    }
}
