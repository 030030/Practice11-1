using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Practice11_1
{
    public partial class CRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_Conn = "Data Source=(localdb)\\ProjectsV13;" +
                "Initial Catalog=Test;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
                "User ID = sa; Password = 12345";
            SqlConnection o_Conn = new SqlConnection(s_Conn);
            try
            {

                o_Conn.Open();
                SqlCommand o_Com = new SqlCommand("Update Users set Birthday = '2021/5/18' where Name = N'狗狗旭'", o_Conn);
                o_Com.ExecuteNonQuery();
                o_Conn.Close();

            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }
        }
    }
}
