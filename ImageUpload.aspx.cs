using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace ImageUploader
{
    public partial class ImageUpload : System.Web.UI.Page
    {
        public static string dbConnect = @"integrated security=true; data source = (localdb)\Projects; persist security info=False; initial catalog=Store";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void DisplayMessage(string message)
        {
            Page page = HttpContext.Current.Handler as Page;
            if(page != null)
            {
                ScriptManager.RegisterStartupScript(page, page.GetType(), "err_mesg", "alert('" + message + "');", true);
            }
        }

        protected void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = Path.GetFileName(fileUpload.FileName);
                fileUpload.SaveAs(HttpContext.Current.Server.MapPath(".") + @"\Pictures\" + filename);
                Image1.ImageUrl = "Pictures/" + filename;
                Image1.Visible = true;

                DisplayMessage("Uploaded Successfully!");

                string result = AddPictureToProducts(filename);

                if(result != "OK")
                {
                    DisplayMessage("Upload Status: The file could not be uploaded. The following error occurred" + result);
                }
            }
            catch(Exception ex)
            {
                DisplayMessage("Upload Status: The file could not be uploaded. The following error occurred" + ex.Message);
            }

        }

        private string AddPictureToProducts(string filename)
        {
            SqlDataAdapter sqlDataAdapter = null;
            DataSet ds = null;
            SqlConnection connectFill = null;
            SqlConnection connectCmd = null;
            SqlCommand cmd = null;
            SqlCommand scmd = null;

            TextPictureName.Text = filename;

            connectCmd = new SqlConnection(dbConnect);
            connectCmd.Open();

            string sqlString = "INSERT INTO Products(SupplierCode, Description, PictureName, QtyOnHand, Price) VALUES (@SupplierCode, @Description, @PictureName, @QtyOnHand, @Price)";

            try
            {
                cmd = new SqlCommand(sqlString, connectCmd);
                cmd.Parameters.AddWithValue("@SupplierCode", TextSupplierCode.Text);
                cmd.Parameters.AddWithValue("@Description", TextDescription.Text);
                cmd.Parameters.AddWithValue("@PictureName", TextPictureName.Text);
                cmd.Parameters.AddWithValue("@QtyOnHand", Convert.ToInt32(TextQOH.Text));
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(TextPrice.Text));
                cmd.ExecuteNonQuery();

                // get the primary key value just created
                cmd = new SqlCommand("SELECT IDENT_CURRENT('Products') FROM Products", connectCmd);
                int identValue = Convert.ToInt32(cmd.ExecuteScalar());
                return TextProdID.Text = Convert.ToString(identValue);
            }
            catch(Exception ex)
            {
                DisplayMessage("Product Table Update Failed. The following error occured: " + ex.Message);
                DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
                return ex.Message;
            }
            DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
            return "OK";
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
    }
}