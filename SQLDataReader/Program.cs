using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace SQL_DataReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cs = ConfigurationManager.ConnectionStrings["SQL_DR"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Student";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())  
            {
                Console.WriteLine("ID: " + dr["ID"] + " FName: " + dr["FName"] + " LName: " + dr["LName"] + " Marks: " + dr["Marks"] + " City: " + dr["City"]);

            }
            con.Close();

            Console.ReadLine();


        }
    }
}
