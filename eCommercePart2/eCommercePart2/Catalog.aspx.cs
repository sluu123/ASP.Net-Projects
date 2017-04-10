using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace eCommercePart2
{
    public partial class Catalog : System.Web.UI.Page
    {
        string dbConnect = @"integrated security=true; data source = (localdb)\Projects; persist security info=False; initial catalog=Store";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = null;
            DataSet ds = null;
            SqlConnection connectFill = null;
            SqlConnection connectCmd = null;
            SqlCommand cmd = null;
            SqlCommand scmd = null;

            string sqlString = "";

            try
            {
                ds = new DataSet();
                connectFill = new SqlConnection(dbConnect);

                sqlString = "SELECT * FROM Products";
                scmd = new SqlCommand(sqlString, connectFill);

                sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = scmd;
                sqlDataAdapter.Fill(ds, "Products");
            }
            catch (Exception ex)
            {
                DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
                return;
            }

            if (ds.Tables["Products"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["Products"].Rows.Count; i++)
                {
                    Index.pics[i] = ds.Tables["Products"].Rows[i]["PictureName"].ToString();
                    Index.descrip[i] = ds.Tables["Products"].Rows[i]["Description"].ToString();
                    Index.price[i] = ((decimal)ds.Tables["Products"].Rows[i]["Price"]).ToString();
                }
            }

            DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);

            for (int i = 0; i < ds.Tables["Products"].Rows.Count; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < 4; j++)
                {
                    // create a cell object to work with
                    TableCell cell = new TableCell();

                    // depending on the column, we'll add either...
                    // a picture, a description, a price or a button to add the item to the cart
                    if (j == 0)
                    {
                        Image image = new Image();
                        image.ImageUrl = "Images/" + Index.pics[i];
                        image.Height = 100;
                        image.Width = 100;
                        cell.Controls.Add(image);
                    }
                    else if (j == 1)
                    {
                        Label label = new Label();
                        label.Text = Index.descrip[i];
                        label.Style["font-family"] = "helvetica";
                        label.Style["color"] = "blue";
                        label.Style["background-color"] = "#BFC9DC";

                        cell.Controls.Add(label);
                    }
                    else if (j == 2)
                    {
                        cell.Text = Index.price[i];
                    }
                    else
                    {
                        // it's easy enough to add a button however
                        // a button we couldn't click would be useless
                        Button btnAddToCart = new Button();
                        btnAddToCart.ID = "btnSelect_" + i + "_" + j;

                        // add the alraedy existing event handler to the button for the current row
                        btnAddToCart.Click += new EventHandler(Button1_Click);
                        btnAddToCart.Text = "Add To Cart";
                        cell.Controls.Add(btnAddToCart);
                    }
                    // now add all the cells for the current row
                    row.Cells.Add(cell);
                }

                // finally, add the current row to the table
                Table1.Rows.Add(row);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string id = b.ID;

            string[] idParts = id.Split('_');

            int row = int.Parse(idParts[1]);
            LabelRowSelected.Text = "You selected " + Index.descrip[row];

            if (Index.numItems > 0)
            {
                bool matchRow = false;
                for (int i = 0; i < Index.numItems; i++)
                {
                    if (row == Index.cartInfo[i])
                        matchRow = true;
                }

                if (!matchRow)
                {
                    Index.cartInfo[Index.numItems] = row;
                    Index.numItems++;
                }
            }
            else
            {
                Index.cartInfo[Index.numItems] = row;
                Index.numItems++;
            }
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