using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;

public partial class print_Sales_Product : System.Web.UI.Page
{
    decimal Totalamount = 0;
    SqlDataReader objReader;
    ProductMgmt pm = new ProductMgmt();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblDate.Text = DateTime.UtcNow.ToShortDateString();

        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }

        clsAccount objAccount = new clsAccount();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString);

        SqlDataReader dr = null;

        //byte[] bytes;

        //string Base64String = string.Empty;

        //SqlCommand cmd = new SqlCommand("comp_sett_details_select", con);

        //cmd.CommandType = CommandType.StoredProcedure;


        //con.Open();

        //try
        //{

        //    dr = cmd.ExecuteReader();

        //    if (dr.HasRows)
        //    {

        //        dr.Read();

        //        //lblcity.Text = Convert.ToString(dr["city"]);
        //        //lblcompname.Text = Convert.ToString(dr["CompName"]);
        //        lbladdresss.Text = Convert.ToString(dr["comp_address"]);

        //        if (!string.IsNullOrEmpty(Convert.ToString(dr["Comp_photo"])))
        //        {

        //            bytes = (byte[])dr["Comp_photo"];

        //            Base64String = Convert.ToBase64String(bytes, 0, bytes.Length);

        //            //  imgprvw1.ImageUrl = "data:images/png;base64," + Base64String;

        //        }


        //    }
        //}
        //catch (Exception)
        //{


        //}
        //finally
        //{

        //    dr.Dispose();

        //    con.Close();

        //    cmd.Dispose();

        //    bytes = null;

        //    Base64String = null;
        //}
        if (!IsPostBack)
        {
            GridView1.DataSource = pm.Invoice_Product_print(Request.QueryString["seno"].ToString());
            GridView1.DataBind();

            objReader = pm.Invoice_select_print(Request.QueryString["seno"].ToString());
            if (objReader.Read())
            {
                //lblAdv.Text = objReader["Adv"].ToString();
                //lblcstno.Text = objReader["cst"].ToString();
               // lbltin.Text = objReader["tin_no"].ToString();
                lblMobile.Text = objReader["mobile"].ToString();
                lblsno.Text = objReader["s_no"].ToString();
                lblDate.Text = objReader["Invoice_Date"].ToString();
                //lblInvoiceNo.Text = objReader["Invoice_No"].ToString();
                lblname.Text = objReader["first_name"].ToString();
                lbl_lastname.Text = objReader["last_name"].ToString();
                lblemail.Text = objReader["email"].ToString();
                LBLEXTRA.Text = objReader["extra_charge"].ToString();
                lblextrachargeAMOUNT.Text = objReader["extra_amount"].ToString();

                l1.Text = objReader["vat"].ToString();
                l2.Text = objReader["cst"].ToString();
               // l3.Text = objReader["tax"].ToString();
              //  l4.Text = objReader["Insurance"].ToString();

                LblVatpt.Text = objReader["vat"].ToString();
                Lblcstpt.Text = objReader["cst"].ToString();
              //  Lbltaxpt.Text = objReader["tax"].ToString();
               // lblinsupt.Text = objReader["Insurance"].ToString();

            }

            objReader = pm.Sale_Invoice_total_price(Request.QueryString["seno"].ToString());
            if (objReader.Read())
            {

                lblSubTotal.Text = objReader["TotalSelling_Price"].ToString();
                lblvat.Text = Math.Round((Decimal.Parse(lblSubTotal.Text) * Decimal.Parse(l1.Text) / 100), 2).ToString();
                lblcst.Text = Math.Round((Decimal.Parse(lblSubTotal.Text) * Decimal.Parse(l2.Text) / 100), 2).ToString();
                //lbltax.Text = Math.Round((Decimal.Parse(lblSubTotal.Text) * Decimal.Parse(l3.Text) / 100), 2).ToString();
                //lblinsu.Text = Math.Round((Decimal.Parse(lblSubTotal.Text) + Decimal.Parse(lblvat.Text) + Decimal.Parse(lblcst.Text) + Decimal.Parse(lbltax.Text)) * (Decimal.Parse(l4.Text) / 100), 2).ToString();

                lblGrandTotal.Text = Math.Round((Decimal.Parse(lblSubTotal.Text) + Decimal.Parse(lblvat.Text) + Decimal.Parse(lblcst.Text)  + Decimal.Parse(lblextrachargeAMOUNT.Text)), 2).ToString();

            }

            objReader.Close();


        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // ImageButton imgincentive = (ImageButton)e.Row.FindControl("imgincentive");


            Totalamount = Totalamount + Convert.ToDecimal(e.Row.Cells[7].Text);

        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {

            e.Row.Cells[1].Text = "Total";

            e.Row.Cells[7].Text = Convert.ToString(Totalamount);

        }
    }
}