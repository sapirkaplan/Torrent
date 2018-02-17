using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Dal
{
    public class Class1
    {

        public void bla()
        {
            try
            {
                string bla = Dal.Properties.Settings.Default.MiniTorrentDB;
                SqlConnection conn = new SqlConnection(bla);
                conn.Open();
                string insertUser = "Insert into Users (User_Name,Password) values (@uName,@pass)";
                SqlCommand com = new SqlCommand(insertUser, conn);
                Console.WriteLine("Enter user name :");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter password  :");
                string password = Console.ReadLine();
                com.Parameters.AddWithValue("@uName", userName);
                com.Parameters.AddWithValue("@pass", password);
                com.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
