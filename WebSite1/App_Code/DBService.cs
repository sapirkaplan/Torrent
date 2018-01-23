using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DBService" in code, svc and config file together.
public class DBService : IDBService
{
    SqlConnection conn;
    SqlCommand comm;
    SqlConnectionStringBuilder connStringBuilder;

    public DBService() { }

    public void DoWork() { }

    public bool checkAuthentication(string userName, string password)
    {
        try
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBTorrent"].ConnectionString);
            conn.Open();
            string checkUser = "Select * from Users where User_Name like @userName and Password like @password";
            comm = new SqlCommand(checkUser,conn);
            comm.Parameters.AddWithValue("userName", userName);
            comm.Parameters.AddWithValue("password", password);

            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        finally
        {
            conn.Close();
        }
        
        

    }

    public void addUserToOnlineUsersTable(string userName, int port, string ip)
    {
        conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBTorrent"].ConnectionString);
        conn.Open();
        string insertUser = "Insert into Online_Users (User_Name,Ip,Port) values (@uName,@ip,@port)";
        SqlCommand com = new SqlCommand(insertUser, conn);
        com.Parameters.AddWithValue("uName", userName);
        com.Parameters.AddWithValue("ip", ip);
        com.Parameters.AddWithValue("port", port);
        com.ExecuteNonQuery();
        conn.Close();
    }
}
