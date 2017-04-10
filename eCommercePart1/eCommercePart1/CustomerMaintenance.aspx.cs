using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace eCommercePart1
{
    public partial class CustomerMaintenance : System.Web.UI.Page
    {
        string webSiteData = HttpContext.Current.Server.MapPath(".") + @"\Data\";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonNewCustomer_Click(object sender, EventArgs e)
        {
            string customerNumber = TextCustomerNumber.Text;
            StreamWriter output = new StreamWriter(webSiteData + customerNumber + ".txt");
            output.WriteLine(TextCustomerNumber.Text);
            output.WriteLine(TextFirstName.Text);
            output.WriteLine(TextLastname.Text);
            output.WriteLine(TextAddress.Text);
            output.WriteLine(TextCity.Text);
            output.WriteLine(TextProvince.Text);
            output.WriteLine(TextPostalCode.Text);
            output.Close();
        }

        protected void ButtonUpdateCustomer_Click(object sender, EventArgs e)
        {
            string customerNumber = TextCustomerNumber.Text;
            StreamWriter output = new StreamWriter(webSiteData + customerNumber + ".txt");
            output.WriteLine(TextFirstName.Text);
            output.WriteLine(TextLastname.Text);
            output.WriteLine(TextAddress.Text);
            output.WriteLine(TextCity.Text);
            output.WriteLine(TextProvince.Text);
            output.WriteLine(TextPostalCode.Text);
            output.Close();
            TextCustomerNumber.Text = "";
            TextFirstName.Text = "";
            TextLastname.Text = "";
            TextAddress.Text = "";
            TextCity.Text = "";
            TextProvince.Text = "";
            TextPostalCode.Text = "";
        }

        protected void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            string customerNumber = TextCustomerNumber.Text;
            string fullPath = webSiteData + customerNumber + ".txt";
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }

        protected void ButtonFindCustomer_Click(object sender, EventArgs e)
        {
            string customerNumber = TextCustomerNumber.Text;
            string fullPath = webSiteData + customerNumber + ".txt";

            if (File.Exists(fullPath))
            {
                StreamReader input = new StreamReader(fullPath);
                TextFirstName.Text = input.ReadLine();
                TextLastname.Text = input.ReadLine();
                TextAddress.Text = input.ReadLine();
                TextCity.Text = input.ReadLine();
                TextProvince.Text = input.ReadLine();
                TextPostalCode.Text = input.ReadLine();
                input.Close();
            }
        }

        protected void CheckBoxDisableCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxDisableCustomer.Checked)
            {
                TextCustomerNumber.Enabled = false;
            }
            else
            {
                TextCustomerNumber.Enabled = true;
            }
        }        
    }
}