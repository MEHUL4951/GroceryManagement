using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Grocery.View.Seller
{
   
    public partial class Billing : System.Web.UI.Page
    {
        Models.Functions Con;
        DataTable dt = new DataTable();
       int seller = Login.Skey;
      
        protected void Page_Load(object sender, EventArgs e)
        {
        
            Con = new Models.Functions();
            ShowProducts();

            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5] {
                new DataColumn("ID"),
                new DataColumn("Product"),
                new DataColumn("Price"),
                new DataColumn("Quantity"),
                new DataColumn("Total"),
                });
               ViewState["Bill"] = dt;
                this.BindGrid();
            }
        }
        protected void BindGrid()
        {
            BillGV.DataSource = (DataTable)ViewState["Bill"];
            BillGV.DataBind();

        }

      
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        public void InsertBill()
        {
            try
            {

                String Query = "insert into BillTbl values('{0}','{1}','{2}')";
                Query = String.Format(Query, System.DateTime.Today, seller, Amount);
                Con.SetData(Query);

            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }
        }


        protected void ShowProducts()
        {
            String Query = "select Id,PrName as Name,PrCat as Category,PrPrice as Price,PrQty as Quantity from ProductTable";
            ProductGv.DataSource = Con.getData(Query);
            ProductGv.DataBind();

        }
        int key = 0;
        int Stock;
        protected void ProductGv_SelectedIndexChanged(object sender, EventArgs e)
        {
            PnameTb.Value = ProductGv.SelectedRow.Cells[2].Text;
            PrPrice.Value = ProductGv.SelectedRow.Cells[4].Text;
            Stock =Convert.ToInt32(ProductGv.SelectedRow.Cells[5].Text);

            if (PnameTb.Value == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ProductGv.SelectedRow.Cells[1].Text);
            }
        }
         

        protected void UpdateStock()
        {
            int newQty;
            newQty = Convert.ToInt32(ProductGv.SelectedRow.Cells[5].Text) - Convert.ToInt32(PrQty.Value);
            string query = "UPDATE ProductTable SET PrQty = '{0}' WHERE Id = '{1}'";
            query = string.Format(query, newQty, ProductGv.SelectedRow.Cells[1].Text);
            Con.SetData(query);
            ShowProducts();
            ErrorMsg.Text = "Qunantity Updated";

        }


        public static int Amount;
         int GrdTotal = 0;
        protected void AddToBillBtn_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(PrQty.Value) * Convert.ToInt32(PrPrice.Value);
            DataTable dt = (DataTable)ViewState["Bill"];
            dt.Rows.Add(BillGV.Rows.Count + 1,
                PnameTb.Value.Trim(),
                PrPrice.Value.Trim(),
                PrQty.Value.Trim(),
                total
            );
            ViewState["Bill"] = dt;
            this.BindGrid();
            UpdateStock();
            GrdTotal = GrdTotal + total;
            Amount = GrdTotal;
            GridTotTb.InnerText = "Rs " + Convert.ToInt32(PrQty.Value) * Convert.ToInt32(PrPrice.Value);
            ErrorMsg.Text = "Bill Added";
          
        }

       


        protected void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                InsertBill();
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message;
            }

        }
    }
}