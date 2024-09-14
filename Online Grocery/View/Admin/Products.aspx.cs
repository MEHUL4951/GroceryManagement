using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Grocery.View.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
           Con = new Models.Functions();
            GetCategories(); 
            ShowProducts();
        }
        protected void GetCategories()
        {
           string query = "select * from CategoryTbl";
           CategoryCb.DataTextField = Con.getData(query).Columns["CatName"].ToString();
           CategoryCb.DataValueField = Con.getData(query).Columns["CatId"].ToString();
           CategoryCb.DataSource = Con.getData(query);
           CategoryCb.DataBind(); 
        }
        protected void ShowProducts()
        {
            String Query = "select * from ProductTable";
            ProductGv.DataSource = Con.getData(Query);
            ProductGv.DataBind();

        }


        int key = 0;
        protected void ProductGv_SelectedIndexChanged(object sender, EventArgs e)
        {
            PnameTb.Value = ProductGv.SelectedRow.Cells[2].Text;
            CategoryCb.DataTextField = ProductGv.SelectedRow.Cells[3].Text;
            PriceTb.Value = ProductGv.SelectedRow.Cells[4].Text;
            ProdQtyTb.Value = ProductGv.SelectedRow.Cells[5].Text;
            ExpDate.Value = ProductGv.SelectedRow.Cells[6].Text;
            ErrorMsg.Text = " ";

            if (PnameTb.Value == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ProductGv.SelectedRow.Cells[1].Text);
            }

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnameTb.Value == "" || PriceTb.Value == "" || ProdQtyTb.Value == "" || ExpDate.Value == "" || CategoryCb.DataTextField == "")
                {
                    ErrorMsg.Text = "Missing Data...";
                }
                else
                {
                    String ProductName = PnameTb.Value;
                    String Price = PriceTb.Value;
                    String Quantity = ProdQtyTb.Value;
                    String Expiry = ExpDate.Value;
                    String Cateogory = CategoryCb.SelectedValue;
                    String Query = "insert into ProductTable values('{0}','{1}','{2}','{3}','{4}')";
                    Query = String.Format(Query,ProductName,Cateogory,Price,Quantity,Expiry);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrorMsg.Text = "Product Added";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnameTb.Value == "" || PriceTb.Value == "" || ProdQtyTb.Value == "" || ExpDate.Value == "" || CategoryCb.DataTextField == "")
                {
                    ErrorMsg.Text = "Missing Data...";
                }
                else
                {
                    String PrName= PnameTb.Value;
                    String PrPrice = PriceTb.Value;
                    String PrQty = ProdQtyTb.Value;
                    String PrExpDate= ExpDate.Value;
                    String PrCat = CategoryCb.SelectedValue;

                    String Query = "update ProductTable set PrName='{0}',PrCat='{1}',PrPrice='{2}',PrQty='{3}',PrExpDate='{4}' where Id='{5}'";
                    Query = String.Format(Query, PrName,PrCat,PrPrice,PrQty,PrExpDate,ProductGv.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrorMsg.Text = "Product Updated!";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnameTb.Value == "")
                {
                    ErrorMsg.Text = "Missing Data...";
                }
                else
                {

                    String SelName = PnameTb.Value;
                    String Query = "delete from ProductTable where Id ='{0}' ";
                    Query = String.Format(Query, ProductGv.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrorMsg.Text = "Product Deleted!";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }
        }
    }
}