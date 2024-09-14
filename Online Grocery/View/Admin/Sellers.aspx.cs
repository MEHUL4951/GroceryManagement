using Online_Grocery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Online_Grocery.View.Admin
{
    public partial class Sellers : System.Web.UI.Page
    {
        Models.Functions Con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowSellers();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
       
        protected void ShowSellers()
        {
            String Query = "select * from SellerTbl";
            SellerGv.DataSource = Con.getData(Query);
            SellerGv.DataBind();

        }
  
        protected void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerPassTb.Value == "" || SEmailTb.Value == "" || SNameTb.Value == "" || SellerPhoneTb.Value=="" || SellerAddressTb.Value == "")
                {
                    ErrorMsg.Text = "Missing Data...";
                }
                else
                {
                    String SName = SNameTb.Value;
                    String SEmail = SEmailTb.Value;
                    String password = SellerPassTb.Value;
                    String Phone = SellerPhoneTb.Value;
                    String Address = SellerAddressTb.Value;
                    String Query = "insert into SellerTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = String.Format(Query,SName, SEmail,password, Phone, Address);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrorMsg.Text = "Seller Added";
                    SNameTb.Value = "";
                    SEmailTb.Value = "";
                    SellerPassTb.Value = "";
                    SellerAddressTb.Value = "";
                    SellerPhoneTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }
        }


        int key = 0;
        protected void SellerGv_SelectedIndexChanged(object sender, EventArgs e)
        {
              SNameTb.Value = SellerGv.SelectedRow.Cells[2].Text;
              SEmailTb.Value = SellerGv.SelectedRow.Cells[3].Text;
              SellerPassTb.Value = SellerGv.SelectedRow.Cells[4].Text;
              SellerPhoneTb.Value = SellerGv.SelectedRow.Cells[5].Text;
              SellerAddressTb.Value = SellerGv.SelectedRow.Cells[6].Text;
              ErrorMsg.Text = " ";

              if(SNameTb.Value ==" ")
            {
                key = 0;
            }
            else
            {
                 key = Convert.ToInt32(SellerGv.SelectedRow.Cells[1].Text);
            }

        }

        protected void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerPassTb.Value == "" || SEmailTb.Value == "" || SNameTb.Value == "" || SellerPhoneTb.Value == "" || SellerAddressTb.Value == "")
                {
                    ErrorMsg.Text = "Missing Data...";
                }
                else
                {
                    String SelName = SNameTb.Value;
                    String SelEmail = SEmailTb.Value;
                    String Selpassword = SellerPassTb.Value;
                    String SelPhone = SellerPhoneTb.Value;
                    String SelAddress = SellerAddressTb.Value;

                    String Query = "update SellerTbl set SelName='{0}',SelEmail='{1}',Selpassword='{2}',SelPhone='{3}',SelAddress='{4}' where SelId='{5}'";
                    Query = String.Format(Query, SelName, SelEmail, Selpassword, SelPhone, SelAddress, SellerGv.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrorMsg.Text = "Seller Updated!";
                    SNameTb.Value = "";
                    SEmailTb.Value = "";
                    SellerPassTb.Value = "";
                    SellerAddressTb.Value = "";
                    SellerPhoneTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }

        }

        protected void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerPassTb.Value == "")
                {
                    ErrorMsg.Text = "Missing Data...";
                }
                else
                {

                    String SelName = SNameTb.Value; 
                    String Query = "delete from SellerTbl where SelId ='{0}' ";
                    Query = String.Format(Query, SellerGv.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrorMsg.Text = "Seller Deleted!";
                    SNameTb.Value = "";
                    SEmailTb.Value = "";
                    SellerPassTb.Value = "";
                    SellerAddressTb.Value = "";
                    SellerPhoneTb.Value = "";

                }
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }
        }
    }
}