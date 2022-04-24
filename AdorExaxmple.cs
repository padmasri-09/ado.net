using System;
using System.Data.SqlClient;
namespace Ado.netrexample
{
    class AdorExaxmple
    {
        static void Main(string[] args)
        {
            new AdorExaxmple().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=customer; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from customer_details", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}  
        
