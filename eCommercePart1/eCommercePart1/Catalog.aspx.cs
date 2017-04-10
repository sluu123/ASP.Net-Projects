using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;

namespace eCommercePart1
{
    public partial class Catalog : System.Web.UI.Page
    {
        const int PROD_ID = 0;
        const int NAME = 1;
        const int IMAGE = 2;
        const int PHONE = 3;
        const int PRICE = 4;

        string websiteData = HttpContext.Current.Server.MapPath(".") + @"\Data\";
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] productFiles = Directory.GetFiles(websiteData, "Product*.txt");

            int i = 0;

            foreach (string productFile in productFiles)
            {
                tblProducts.Rows.Add(GetProductRow(productFile, i));
                i++;
            }
        }

        private System.Collections.ArrayList GetProduct(string fileName)
        {
            StreamReader product = new StreamReader(fileName);

            System.Collections.ArrayList prodData = new System.Collections.ArrayList();
            string di;
            while ((di = product.ReadLine()) != null)
            {
                prodData.Add(di);
            }
            product.Close();
            return prodData;

        }
        private TableRow GetProductRow(string fileName, int index)
        {
            ArrayList prodData = GetProduct(fileName);

            // create the row to be returned
            TableRow tr = new TableRow();
            tr.CssClass = "row" + (index % 2).ToString();

            // add the image for this row
            TableCell tcImage = new TableCell();
            Image productImage = new Image();
            productImage.ImageUrl = prodData[IMAGE].ToString();
            productImage.Height = 100;
            productImage.Width = 100;
            tcImage.Controls.Add(productImage);
            tr.Cells.Add(tcImage);

            // create a cell that will hold the productID
            TableCell tcProdID = new TableCell();
            tcProdID.Text = prodData[PROD_ID].ToString();
            tr.Cells.Add(tcProdID);

            // create a cell that will hold the name
            TableCell tcName = new TableCell();
            tcName.Text = prodData[NAME].ToString();
            tr.Cells.Add(tcName);

            // create a cell that will hold the name
            TableCell tcPrice = new TableCell();
            decimal price = decimal.Parse(prodData[PRICE].ToString().Trim());
            tcPrice.Text = price.ToString("C");
            tcPrice.HorizontalAlign = HorizontalAlign.Right;
            tr.Cells.Add(tcPrice);

            // add a button to add items to the cart
            TableCell tcButton = new TableCell();
            Button btnAddToCart = new Button();
            btnAddToCart.ID = "btnAddToCart_" + prodData[PROD_ID].ToString();
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.Click += new EventHandler(btnAddToCart_Click); // tell this new button to call its event handler
            tcButton.Controls.Add(btnAddToCart);
            tr.Cells.Add(tcButton);

            // return the table row so the caller can use it
            return tr;
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string id = b.ID;
            string[] idParts = id.Split('_');
            id = idParts[1]; 

            ArrayList prodData = GetProduct(Index.websiteData + "Product" + id + ".txt");

            Index.cart.Add(prodData);

            lblOutput.Text = string.Format("{0} has been added to your cart.", prodData[NAME]);
        }
    }
}