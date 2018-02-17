using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class regrestion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniTorrentDBConnectionString"].ConnectionString);
            conn.Open();
            conn.Close();

        }
    }

    protected void signIn_Click(object sender, EventArgs e)
    {
        try
        {
            //string connectionString = "Server=./SQLEXPRESS;Database=DBTorrent;";
            ////string connectionString = "Data Source=localhost;Initial Catalog=DBTorrent;";
            //SqlConnection conn = new SqlConnection(connectionString);
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniTorrentDBConnectionString"].ConnectionString);
            conn.Open();
            string insertUser = "Insert into Users (User_Name,Password) values (@uName,@pass)";
            SqlCommand com = new SqlCommand(insertUser, conn);
            com.Parameters.AddWithValue("@uName", TextBoxUserName.Text);
            com.Parameters.AddWithValue("@pass", TextBoxPassword.Text);
            com.ExecuteNonQuery();
            Response.Write("Succseful !");
            conn.Close();
        }
        catch(Exception ex)
        {
            Response.Write("Eroor :" + ex.ToString());
        }
    }

    public void alert()
    {
        Response.Write("<script>alert('login successful');</script>");
    }
}