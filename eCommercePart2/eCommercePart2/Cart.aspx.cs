using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommercePart2
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateCartGrid();
            CalculateTotal();
        }

        protected void ButtonRecalculate_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string id = b.ID;

            string[] idParts = id.Split('_');

            int row = int.Parse(idParts[1]);
            LabelRowSelected.Text = "You selected row " + idParts[1];

            Index.qty[Index.cartInfo[row]] = "1";

            // delete the cart item from the Main.cartInfo array
            // ... then rebuild the cart grid
            for (int i = row; i < Index.numItems; i++)
                Index.cartInfo[i] = Index.cartInfo[i + 1];

            Index.numItems--;
            CreateCartGrid();
            CalculateTotal();
        }

        private void CreateCartGrid()
        {
            Table1.Rows.Clear();
            for (int i = 0; i < Index.numItems; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < 5; j++)
                {
                    // create a cell object to work with
                    TableCell cell = new TableCell();

                    // depending on the column, we'll add either...
                    // a picture, a description, a price or a button to add the item to the cart
                    if (j == 0)
                    {
                        Image image = new Image();
                        image.ImageUrl = "Images/" + Index.pics[Index.cartInfo[i]];
                        image.Height = 100;
                        image.Width = 100;
                        cell.Controls.Add(image);
                    }
                    else if (j == 1)
                    {
                        Label label = new Label();
                        label.Text = Index.descrip[Index.cartInfo[i]];
                        label.Style["font-family"] = "helvetica";
                        label.Style["color"] = "blue";
                        label.Style["background-color"] = "#BFC9DC";

                        cell.Controls.Add(label);
                    }
                    else if (j == 2)
                    {
                        //cell.Text = Main.price[Main.cartInfo[i]];
                        Label label = new Label();
                        label.Text = Index.price[Index.cartInfo[i]];
                        label.Style["font-family"] = "helvetica";
                        label.Style["color"] = "blue";
                        label.Style["background-color"] = "#BFC9DC";

                        cell.Controls.Add(label);
                    }
                    else if (j == 3)
                    {
                        // it's easy enough to add a button however
                        // a button we couldn't click would be useless
                        Button btnAddToCart = new Button();
                        btnAddToCart.ID = "btnSelect_" + i + "_" + j;

                        // add the alraedy existing event handler to the button for the current row
                        btnAddToCart.Click += new EventHandler(Button1_Click);
                        btnAddToCart.Text = "Remove";
                        cell.Controls.Add(btnAddToCart);
                    }
                    else
                    {
                        TextBox text = new TextBox();
                        text.Text = Index.qty[Index.cartInfo[i]];
                        text.Style["font-family"] = "helvetica";
                        text.Style["color"] = "blue";
                        text.Style["background-color"] = "white";
                        text.Style["width"] = "20px";
                        text.Style["border"] = "solid 1px #002594";

                        cell.Controls.Add(text);
                    }
                    // now add all the cells for the current row
                    row.Cells.Add(cell);
                }

                // finally, add the current row to the table
                Table1.Rows.Add(row);
            }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < Index.numItems; i++)
            {
                TableRow row = Table1.Rows[i];
                decimal rowPrice = 0;

                for (int j = 0; j < 5; j++)
                {
                    TableCell cell = row.Cells[j];

                    if (j == 2)
                    {
                        Control ctrl = cell.Controls[0];
                        Label lbl = (Label)ctrl;
                        string price = lbl.Text;
                        rowPrice = decimal.Parse(price);
                    }
                    else if (j == 4)
                    {
                        Control ctrl = cell.Controls[0];
                        TextBox txt = (TextBox)ctrl;
                        string qty = txt.Text;
                        Index.qty[Index.cartInfo[i]] = qty;

                        decimal rowTotal = rowPrice * int.Parse(qty);
                        total += rowTotal;
                    }
                }
            }

            LabelTotal.Text = total.ToString("$##,##0.##");
        }
    }
}