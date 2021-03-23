using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ChatApp_v1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FNV858E;Initial Catalog=ChatApp;User ID=Kavin;Password=1234");
      static SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Session["User"] = Convert.ToString(LoginID.Text);
          
            cmd  = new SqlCommand("select * from LoginDetail where UserID='" + LoginID.Text+"' and Password='"+Password.Text+"'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while(reader.Read())
            {
                count++;
            }
            
            conn.Close();
            if(count==1)
            {
                Response.Redirect("Inbet.aspx");
            }
            else
            {
                Response.Write("Value is Wrong");
            }
        }
    }
}