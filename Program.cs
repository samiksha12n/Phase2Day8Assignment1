using System;
using System.Data;
using System.Data.SqlClient;

namespace Day8AssignmentPart1
{
    internal class Program
    {
        static SqlDataReader SqlDataReader;


        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string constr = "server=DESKTOP-OBBRFUM\\MSSQLSERVER01;database=Day8Assignment;trusted_connection=true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select * from Products Order by PName Desc"

                };
                con.Open();
                reader = cmd.ExecuteReader();
                Console.WriteLine("*******Product Details as follows*********\n");
                while (reader.Read())
                {
                    Console.WriteLine("PId:\t" + reader["PId"]);
                    Console.WriteLine("Product Name:\t" + reader["PName"]);
                    Console.WriteLine("Product Price:\t" + reader["PPrice"]);
                    Console.WriteLine("Mfg Date:\t" + reader["mfgDate"]);
                    Console.WriteLine("Exp Date:\t" + reader["expDate"]);
                    Console.WriteLine("\n");
                    Console.WriteLine("--------------------------------------------------");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
