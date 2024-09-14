using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Online_Grocery.Models
{
    public class Functions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable  dt;
        private SqlDataAdapter sda;
        private String ConnectionString;


        public Functions() {
            ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mehul\\Documents\\GroceryAspDb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection();
            Con.ConnectionString = WebConfigurationManager.ConnectionStrings["GroceryCon"].ConnectionString;
            cmd = new SqlCommand();
            cmd.Connection = Con;        
        }

        public DataTable getData(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query,ConnectionString);
            sda.Fill(dt);
            return dt;         
        }
        public int SetData(String Query)
        {
            try
            {
                int count;
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                cmd.CommandText = Query;
                count = cmd.ExecuteNonQuery();
                Con.Close();
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }


    }
}