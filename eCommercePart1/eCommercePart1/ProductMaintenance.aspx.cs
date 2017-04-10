using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace eCommercePart1
{
    public partial class ProductMaintenance : System.Web.UI.Page
    {
        string webSiteData = HttpContext.Current.Server.MapPath(".") + @"\Data\";
        string imageLocation = HttpContext.Current.Server.MapPath(".") + @"\Images\";
        protected void Page_Load(object sender, EventArgs e)
        {            
            LabelOutput.Text = "";
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // set up the string verification
                String PhoneRegex = @"^(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$";
                String MoneyRegex = @"^([0-9]{3}, ([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$";

                if (!System.Text.RegularExpressions.Regex.IsMatch(TextPhone.Text, PhoneRegex))
                {
                    LabelOutput.Text = "The phone number is not an appropriate format for saving.";
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(TextPrice.Text, MoneyRegex))
                {
                    LabelOutput.Text = "The price is not an appropriate format for saving.";
                }
                else if (TextProdID.Text.Trim().Length == 0 || TextName.Text.Trim().Length == 0 || TextPhone.Text.Trim().Length == 0)
                {
                    LabelOutput.Text = "You missed some important data. Please provide the information so it can be saved.";
                }
                else
                {
                    if (fulImage.HasFile)
                    {
                        // upload the image to the images folder
                        fulImage.SaveAs(imageLocation + fulImage.FileName);

                        // save the data to a text file
                        StreamWriter output = new StreamWriter(webSiteData + "Product" + TextProdID.Text + ".txt");
                        output.WriteLine(TextProdID.Text);
                        output.WriteLine(TextName.Text);
                        output.WriteLine(@"/Images/" + fulImage.FileName);
                        output.WriteLine(TextPhone.Text);
                        output.WriteLine(TextPrice.Text);
                        output.Close();
                        // thank the user
                        LabelOutput.Text = "Thanks for the information.";
                    }
                    else
                    {
                        LabelOutput.Text = "Please supply an image for this product.";
                    }
                }
            }
            catch (Exception ex)
            {
                // generally asking a user to debug the code is not a good idea
                LabelOutput.Text = "There was an error. Please debug!";
            }
        }
    }
}