using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Grocery.View.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowCategories();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        protected void ShowCategories()
        {
            String Query = "select * from CategoryTbl";
            CategoryGV.DataSource = Con.getData(Query);
            CategoryGV.DataBind();

        }

        protected void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || CatRemarkTb.Value=="")
                {
                    ErrorMsg.Text = "Missing Data...";
                }
                else
                {
                    String CatName = CatNameTb.Value;
                    String CatDescription = CatRemarkTb.Value;
                  
                    String Query = "update CategoryTbl set CatName='{0}',CatDescription='{1}'  where CatId='{2}'";
                    Query = String.Format(Query,CatName,CatDescription,CategoryGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrorMsg.Text = "Category Updated!";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }

        }

        protected void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || CatRemarkTb.Value =="")
                {
                    ErrorMsg.Text = "Missing Data...";
                }
                else
                {
                    String CatName = CatNameTb.Value;
                    String CatDescription = CatRemarkTb.Value;
                  
                    String Query = "insert into CategoryTbl values('{0}','{1}')";
                    Query = String.Format(Query,CatName,CatDescription);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrorMsg.Text = "Category Added";
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
                if (CatNameTb.Value == "")
                {
                    ErrorMsg.Text = "Missing Data...";
                }
                else
                {

                    String CatName = CatNameTb.Value;
                    String Query = "delete from CategoryTbl  where CatId ='{0}' ";
                    Query = String.Format(Query, CategoryGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrorMsg.Text = "Category Deleted!";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }

        }

        int key = 0;
        protected void CategoryGv_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatNameTb.Value = CategoryGV.SelectedRow.Cells[2].Text;
            CatRemarkTb.Value = CategoryGV.SelectedRow.Cells[3].Text;
     
            ErrorMsg.Text = "Category Selected";

            if (CatNameTb.Value == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CategoryGV.SelectedRow.Cells[1].Text);
            }

        }
    }
}