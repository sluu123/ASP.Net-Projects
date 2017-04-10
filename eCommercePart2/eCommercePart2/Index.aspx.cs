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
    public partial class Index : System.Web.UI.Page
    {
        string dbConnect = @"integrated security=true; data source = (localdb)\Projects; persist security info=False; initial catalog=Store";

        // public static string webSiteData = HttpContext.Current.Server.MapPath(".") + @"\Data\Products";
        public static int[] cartInfo = new int[10];
        public static int numItems = 0;

        public static string[] pics;
        public static string[] descrip;
        public static string[] price;
        public static string[] qty;
        public static int catCount = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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

                    catCount = ds.Tables["Products"].Rows.Count;
                    pics = new string[catCount];
                    descrip = new string[catCount];
                    price = new string[catCount];
                    qty = new string[catCount];
                }
                catch (Exception ex)
                {
                    DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);
                }
                DisposeResources(ref sqlDataAdapter, ref ds, ref connectFill, ref connectCmd, ref cmd, ref scmd);

                CatCartFrame.Attributes.Add("src", "Catalog.aspx");

                for (int i = 0; i < catCount; i++)
                {
                    Index.qty[i] = "1";
                }
            }
        }

        protected void BtnCatCart_Click(object sender, EventArgs e)
        {
            CatCartFrame.Attributes.Add("src", "Cart.aspx");
        }

        protected void BtnCatalog_Click(object sender, EventArgs e)
        {
            CatCartFrame.Attributes.Add("src", "Catalog.aspx");
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