using Online_Grocery.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Grocery.View
{
    public partial class Login : System.Web.UI.Page
    {

        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
             Con  = new Models.Functions(); 
        }
        public static String Sname;
        public static int Skey;
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AdminRadio.Checked)
                {
                    if (EmailId.Value == "admin@gmail.com" && UserPasswordTb.Value == "Admin")
                    {
                        Response.Redirect("Admin/Sellers.aspx");
                    }
                    else
                    {
                        infomsg.Text = "Invalid Admin!!!";
                    }
                }
                else
                {
                    string query = "select SelId,SelName,SelEmail,SelPassword from SellerTbl where SelEmail='{0}' and SelPassword='{1}'";
                    query = string.Format(query, EmailId.Value, UserPasswordTb.Value);
                    DataTable dt = Con.getData(query);
                    if (dt.Rows.Count == 0)
                    {
                        infomsg.Text = "Invalid User!!!";
                    }
                    else
                    {
                        Sname = EmailId.Value;
                        Skey = Convert.ToInt32(dt.Rows[0]["SelId"].ToString());
                        Response.Redirect("Seller/Billing.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                infomsg.Text = "Error: " + ex.Message;
            }
        }

    }
}