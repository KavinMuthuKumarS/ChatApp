using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ChatApp_v1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String user = Convert.ToString(Session["User"]);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FNV858E;Initial Catalog=ChatApp;User ID=Kavin;Password=1234");
            SqlCommand cmd = new SqlCommand("Select from_ as From_Person , message as Message from ChatMessage where to_ like '"+user+"' and status like 'Unread'  ", conn);
            conn.Open();
            
            int count = 0;
            SqlDataReader obj = cmd.ExecuteReader();

            while (obj.Read()) 
            {
                count++;
            }
            if (count != 0)
            {
                obj.Close();
                obj = cmd.ExecuteReader();
                GridView1.DataSource = obj;
                GridView1.DataBind();
                obj.Close();
                SqlCommand cmd1 = new SqlCommand("update ChatMessage set status ='Read' where to_ like '" + user + "'", conn);
                cmd1.ExecuteNonQuery();

              
            }
            else
            {
                Response.Write("There is no Unread Message");

            }
            conn.Close();
        }

       
    }
}