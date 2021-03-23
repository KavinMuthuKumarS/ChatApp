using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ChatApp_v1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String user = Convert.ToString(Session["User"]);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FNV858E;Initial Catalog=ChatApp;User ID=Kavin;Password=1234");
            SqlCommand cmd;
            cmd = new SqlCommand("select * from LoginDetail where UserID='"+ TextBox1.Text +"'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }

            conn.Close();
            if (count == 1)
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Insert into ChatMessage values('"+user+ "','" + TextBox1.Text + "','" + TextBox2.Text + "','Unread')",conn);
                cmd1.ExecuteNonQuery();
                conn.Close();
                Response.Write("Message Delivered");
            }
            else
            {
                Response.Write(" is Wrong");
            }
        }
    }
}