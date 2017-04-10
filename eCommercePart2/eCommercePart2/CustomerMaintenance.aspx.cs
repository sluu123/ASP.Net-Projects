using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace eCommercePart2
{
    public partial class CustomerMaintenance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonNewCustomer_Click(object sender, EventArgs e)
        {
            string dbConnect = @"integrated security=true; data source = (localdb)\Projects; persist security info=False; initial catalog=Store";
            SqlDataAdapter sqlDataAdapter = null;
            DataSet ds = null;
            SqlConnection connectFill = null;
            SqlConnection connectCmd = null;
            SqlCommand cmd = null;
            SqlCommand scmd = null;

            connectCmd = new SqlConnection(dbConnect);
            connectCmd.Open();

            string sqlString = "INSERT INTO Customers(FirstName, LastName, Address, City, Province, PostalCode, Telephone, Email) VALUES (@FirstName, @LastName, @Address, @City, @Province, @PostalCode, @Telephone, @Email)";

            try
            {
                cmd = new SqlCommand(sqlString, connectCmd);
                cmd.Parameters.AddWithValue("@FirstName", TextFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", TextLastName.Text);
                cmd.Parameters.AddWithValue("@Address", TextAddress.Text);
                cmd.Parameters.AddWithValue("@City", TextCity.Text);
                cmd.Parameters.AddWithValue("@Province", TextProvince.Text);
                cmd.Parameters.AddWithValue("@PostalCode", TextPostalCode.Text);
                cmd.Parameters.AddWithValue("@Telephone", TextTelephone.Text);
                cmd.Parameters.AddWithValue("@Email", TextEmail.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
            }
            DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
            clear();
        }

        protected void ButtonUpdateCustomer_Click(object sender, EventArgs e)
        {
            string dbConnect = @"integrated security=true; data source = (localdb)\Projects; persist security info=False; initial catalog=Store";
            SqlDataAdapter sqlDataAdapter = null;
            DataSet ds = null;
            SqlConnection connectFill = null;
            SqlConnection connectCmd = null;
            SqlCommand cmd = null;
            SqlCommand scmd = null;

            connectCmd = new SqlConnection(dbConnect);
            connectCmd.Open();

            string sqlString = "UPDATE Customers SET FirstName=@FirstName, LastName=@LastName, Address=@Address, City=@City, Province=@Province, PostalCode=@PostalCode, Telephone=@Telephone, Email=@Email where CustomerID=@CustomerID";
            try
            {
                cmd = new SqlCommand(sqlString, connectCmd);
                cmd.Parameters.AddWithValue("@CustomerID", TextCustomerNumber.Text);
                cmd.Parameters.AddWithValue("@FirstName", TextFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", TextLastName.Text);
                cmd.Parameters.AddWithValue("@Address", TextAddress.Text);
                cmd.Parameters.AddWithValue("@City", TextCity.Text);
                cmd.Parameters.AddWithValue("@Province", TextProvince.Text);
                cmd.Parameters.AddWithValue("@PostalCode", TextPostalCode.Text);
                cmd.Parameters.AddWithValue("@Telephone", TextTelephone.Text);
                cmd.Parameters.AddWithValue("@Email", TextEmail.Text);
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
            }
            DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
            clear();
        }

        protected void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            string dbConnect = @"integrated security=true; data source = (localdb)\Projects; persist security info=False; initial catalog=Store";
            SqlDataAdapter sqlDataAdapter = null;
            DataSet ds = null;
            SqlConnection connectFill = null;
            SqlConnection connectCmd = null;
            SqlCommand cmd = null;
            SqlCommand scmd = null;

            connectCmd = new SqlConnection(dbConnect);
            connectCmd.Open();

            string sqlString = "DELETE FROM Customers WHERE CustomerID=@CustomerID";
            try
            {
                cmd = new SqlCommand(sqlString, connectCmd);
                cmd.Parameters.AddWithValue("@CustomerID", TextCustomerNumber.Text);
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
            }
            DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
            clear();
        }

        protected void ButtonFindCustomer_Click(object sender, EventArgs e)
        {
            string dbConnect = @"integrated security=true; data source = (localdb)\Projects; persist security info=False; initial catalog=Store";
            SqlDataAdapter sqlDataAdapter = null;
            DataSet ds = null;
            SqlConnection connectFill = null;
            SqlConnection connectCmd = null;
            SqlCommand cmd = null;
            SqlCommand scmd = null;

            connectCmd = new SqlConnection(dbConnect);
            connectCmd.Open();

            string sqlString = "";
            try
            {
                ds = new DataSet();
                connectFill = new SqlConnection(dbConnect);

                sqlString = "SELECT * From Customers WHERE CustomerID = @CustomerID";
                scmd = new SqlCommand(sqlString, connectFill);
                scmd.Parameters.AddWithValue("@CustomerID", TextCustomerNumber.Text);

                sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = scmd;
                sqlDataAdapter.Fill(ds, "Customers");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
            }
            if (ds.Tables["Customers"].Rows.Count == 1)
            {
                TextFirstName.Text = ds.Tables["Customers"].Rows[0]["FirstName"].ToString();
                TextLastName.Text = ds.Tables["Customers"].Rows[0]["LastName"].ToString();
                TextAddress.Text = ds.Tables["Customers"].Rows[0]["Address"].ToString();
                TextCity.Text = ds.Tables["Customers"].Rows[0]["City"].ToString();
                TextProvince.Text = ds.Tables["Customers"].Rows[0]["Province"].ToString();
                TextPostalCode.Text = ds.Tables["Customers"].Rows[0]["PostalCode"].ToString();
                TextTelephone.Text = ds.Tables["Customers"].Rows[0]["Telephone"].ToString();
                TextEmail.Text = ds.Tables["Customers"].Rows[0]["Email"].ToString();
            }
            DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
        }

        private static void DisposeResources(ref SqlDataAdapter sqlDataAdapter, ref DataSet ds, ref SqlConnection connectFill,
                                             ref SqlConnection connectCmd, ref SqlCommand cmd, ref SqlCommand scmd)
        {
            if (sqlDataAdapter != null)
            {
                sqlDataAdapter.Dispose();
            }
            if (ds != null)
            {
                ds.Dispose();
            }
            if (connectFill != null)
            {
                connectFill.Dispose();
            }
            if (connectCmd != null)
            {
                connectCmd.Dispose();
            }
            if (cmd != null)
            {
                cmd.Dispose();
            }
            if (scmd != null)
            {
                scmd.Dispose();
            }
        }

        private void clear()
        {
            TextFirstName.Text = "";
            TextLastName.Text = "";
            TextAddress.Text = "";
            TextCity.Text = "";
            TextProvince.Text = "";
            TextPostalCode.Text = "";
            TextTelephone.Text = "";
            TextEmail.Text = "";
        }
    }
}