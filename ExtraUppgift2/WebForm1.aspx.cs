using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace ExtraUppgift2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlDataReader oreader;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=DurgamsDB;Integrated Security = true");
            SqlCommand cmd = new SqlCommand("insert into [Table_1] values(@Name, @city)", con);
            try
            {

                con.Open();

                cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@city", TextBox2.Text);

                cmd.ExecuteNonQuery();

                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "insert into [Table_1] value('" + TextBox1.Text + "','" + TextBox2.Text + "')";
                //cmd.ExecuteNonQuery();
                //cmd.ExecuteReader();
                //con.Close();

                //Response.Redirect("WebForm1.aspx");
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
                Label1.Visible = true;
                //con.Close();
                //con.Dispose();
                //cmd.Dispose();
            }
            finally
            {

                //oreader.Close();
                //oreader.Dispose();
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=AdventureWorks2012;Integrated Security = True");
        //    string sqlQuery = "SELECT * FROM Production.ProductCategory";
        //    SqlCommand cmd = new SqlCommand(sqlQuery, con);

        //    try
        //    {
        //        ListItem newItem = new ListItem();
        //        newItem.Text = "Select";
        //        newItem.Value = "0";
        //        DropDownList1.Items.Add(newItem);
        //        con.Open();
        //        oreader = cmd.ExecuteReader();
        //        while (oreader.Read())
        //        {
        //            ListItem listItem1 = new ListItem();
        //            listItem1.Text = oreader["Name"].ToString();
        //            listItem1.Value = oreader["ProductCategoryID"].ToString();
        //            DropDownList1.Items.Add(listItem1);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        //Label1.Text = ex.Message;
        //        //Label1.Visible = true;
        //    }

        //    finally {
        //        oreader.Close();
        //        oreader.Dispose();
        //        con.Close();
        //        con.Dispose();
        //        cmd.Dispose();
        //    }

        //}
    }
}