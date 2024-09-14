using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Grocery.View.Admin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        Models.Functions Con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            GetProducts();
            GetSeller();
            SumSell();
            GetCategories();
            GetSellers();

        }
        private void GetProducts()
        {
            string Query = "Select Count(*)  from ProductTable";
            PnumTb.InnerText = Con.getData(Query).Rows[0][0].ToString();
            PnumTb.DataBind();
        }
        protected void GetSeller()
        {
            string query = "select * from SellerTbl";
            SellerCb.DataTextField = Con.getData(query).Columns["SelName"].ToString();
            SellerCb.DataValueField = Con.getData(query).Columns["SelId"].ToString();
            SellerCb.DataSource = Con.getData(query);
            SellerCb.DataBind();
            lbl.Text = SellerCb.DataValueField;
        }
        private void GetCategories()
        {
            string Query = "Select Count(*)  from CategoryTbl";
            CatNumTb.InnerText = Con.getData(Query).Rows[0][0].ToString();
            CatNumTb.DataBind();
        }

        private void GetSellers()
        {
            string Query = "Select Count(*)  SellerTbl";
            SelNumTb.InnerText = Con.getData(Query).Rows[0][0].ToString();
            SelNumTb.DataBind();
        }

        private void SumSell() { 
        
            string Query = "Select Sum(Amount) from BillTbl";
            FinanceTb.InnerText = "Rs." + Con.getData(Query).Rows[0][0].ToString();
            FinanceTb.DataBind();
        }

        private void SumSellBySeller()
        {
           

            string Query = "Select Sum(Amount) from BillTbl where Seller = ' " + SellerCb.DataValueField + " ' ";
            TotalSellTb.InnerText = "Rs." + Con.getData(Query).Rows[0][0].ToString();
            TotalSellTb.DataBind();
            
        }

        protected void SellerCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SumSellBySeller();
        }
    }
}